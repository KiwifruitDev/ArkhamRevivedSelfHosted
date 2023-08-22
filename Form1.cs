using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace ArkhamRevivedSelfHosted;

public partial class Form1 : Form
{
    public static Form1 instance;
    public string apiKey = "";
    public bool serverRunning = false;
    public BackgroundWorker httpListenerWorker;
    public HttpListener listener;
    public Form1()
    {
        instance = this;

        InitializeComponent();

        // Load API key from file if it exists
        if (File.Exists("steamwebapi.key"))
            apiKey = File.ReadAllText("steamwebapi.key");

        // Load global data from json files
        GlobalData.SaveData = JsonConvert.DeserializeObject<UserSaveData>(File.ReadAllText("savedata.json"));
        GlobalData.Inventory = JsonConvert.DeserializeObject<UserInventoryData>(File.ReadAllText("inventory.json"));
        GlobalData.Catalog = JsonConvert.DeserializeObject<CatalogData>(File.ReadAllText("catalog.json"));
        GlobalData.MessageOfTheDay = JsonConvert.DeserializeObject<IndexedObject<MessageOfTheDayItem>>(File.ReadAllText("motd.json"));
        GlobalData.Store = JsonConvert.DeserializeObject<IndexedObject<StoreItem>>(File.ReadAllText("store.json"));
        GlobalData.CreditsStore = JsonConvert.DeserializeObject<IndexedObject<StoreItem>>(File.ReadAllText("credits.json"));

        // Set frontend version
        versionToolStripMenuItem.Text = "Version: v" + Application.ProductVersion;
    }

    private void LogToFrontend(string message)
    {
        // richTextBox1 is the name of the RichTextBox control.
        richTextBox1.AppendText(message + "\n");
        // Scroll to bottom
        richTextBox1.SelectionStart = richTextBox1.Text.Length;
        richTextBox1.ScrollToCaret();
    }

    // Public function to log to frontend
    public void Log(string message)
    {
        // Prepend timestamp to message
        richTextBox1.Invoke(new Action(() => LogToFrontend(DateTime.Now.ToString("HH:mm:ss") + " " + message)));
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        switch (e.Node.Name)
        {
            case "SaveData":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data;
                break;
            case "CustomizationProfileData":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.CustomizationProfileData;
                break;
            case "LoadoutData":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.LoadoutData;
                break;
            case "RecentUnlocks":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.RecentUnlocks;
                break;
            case "BaneTeamRecentUnlocks":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.RecentUnlocks.BaneTeamRecentUnlocks;
                break;
            case "JokerTeamRecentUnlocks":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.RecentUnlocks.JokerTeamRecentUnlocks;
                break;
            case "MatchmakingData":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.MatchmakingData;
                break;
            case "WeaponScores":
                propertyGrid1.SelectedObject = GlobalData.SaveData.data.WeaponScores;
                break;
            case "Inventory":
                propertyGrid1.SelectedObject = GlobalData.Inventory.inventory;
                break;
            case "Catalog":
                propertyGrid1.SelectedObject = GlobalData.Catalog.items;
                break;
            case "MessageOfTheDay":
                propertyGrid1.SelectedObject = GlobalData.MessageOfTheDay;
                break;
            case "ItemStore":
                propertyGrid1.SelectedObject = GlobalData.Store;
                break;
            case "CreditsStore":
                propertyGrid1.SelectedObject = GlobalData.CreditsStore;
                break;
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "https://steamcommunity.com/dev/apikey",
            UseShellExecute = true
        };
        Process.Start(psi);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "https://steamid.xyz/",
            UseShellExecute = true
        };
        Process.Start(psi);
    }

    private void button6_Click(object sender, EventArgs e)
    {
        // Prompt user with text box to set Steam Web API Key
        apiKey = Interaction.InputBox("Enter Steam Web API Key", "Steam Web API Key");
        // Save API key to file
        File.WriteAllText("steamwebapi.key", apiKey);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        // Prompt user to find "Batman Arkham Origins" folder and start in
        // C:\Program Files (x86)\Steam\steamapps\common\Batman Arkham Origins
        // with the default selection being "Select Folder"
        FolderBrowserDialog fbd = new FolderBrowserDialog
        {
            Description = "Select Batman Arkham Origins Folder",
            SelectedPath = @"C:\Program Files (x86)\Steam\steamapps\common\Batman Arkham Origins"
        };
        DialogResult result = fbd.ShowDialog();
        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
            // Find Batman Arkham Origins\Online\BmGame\Config\DefaultWBIDVars.ini and ensure it exists
            string defaultWBIDVarsPath = Path.Combine(fbd.SelectedPath, @"Online\BmGame\Config\DefaultWBIDVars.ini");
            if (File.Exists(defaultWBIDVarsPath))
            {
                // Read DefaultWBIDVars.ini
                string defaultWBIDVars = File.ReadAllText(defaultWBIDVarsPath);
                // Find the line that starts with "BaseUrl=" and replace it with "BaseUrl=http://localhost:8385/"
                defaultWBIDVars = Regex.Replace(defaultWBIDVars, @"BaseUrl=.*", "BaseUrl=http://localhost:8385/");
                // Write DefaultWBIDVars.ini
                File.WriteAllText(defaultWBIDVarsPath, defaultWBIDVars);
                // Prompt user that the file was modified
                MessageBox.Show("DefaultWBIDVars.ini was modified successfully.", "Success");
            }
            else
            {
                // Prompt user that the file was not found
                MessageBox.Show("DefaultWBIDVars.ini was not found.", "Error");
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (serverRunning)
        {
            // Stop server
            button2.Text = "Start";
            Log("Stopping server...");

            // Stop HTTP listener
            listener.Stop();

            // Stop background worker
            httpListenerWorker.CancelAsync();
        }
        else
        {
            // Start server
            button2.Text = "Stop";
            Log("Starting server...");

            // Start HTTP listener
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8385/");
            listener.Start();

            // Start background worker
            httpListenerWorker = new BackgroundWorker();
            httpListenerWorker.DoWork += new DoWorkEventHandler(httpListenerWorker_DoWork);
            httpListenerWorker.WorkerSupportsCancellation = true;
            httpListenerWorker.RunWorkerAsync();

            // Set serverRunning to true
            serverRunning = true;
        }
    }

    private void httpListenerWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        // GET:
        // - /files/netvars.dat
        // - /motd
        // - /store/catalog/general
        // - /store/offers
        // - /users/[uuid]/[subpage1?]/[subpage2?]
        // POST:
        // - /auth/token
        // - /store/vouchers/transactions
        // - /store/purchases/transactions
        // PUT:
        // - /store/vouchers/[transactionid]
        // - /store/purchases/[transactionid]
        // - /users/[uuid]/[subpage1?]/[subpage2?]

        // Loop until background worker is cancelled
        while (!httpListenerWorker.CancellationPending)
        {
            try
            {
                // Wait for request
                HttpListenerContext context = listener.GetContext();

                // Get request
                HttpListenerRequest request = context.Request;

                // Get response
                HttpListenerResponse response = context.Response;

                // Set response headers
                response.Headers.Add("Access-Control-Allow-Origin", "*");
                response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT");
                response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Accept, Authorization");

                // Set response content type
                response.ContentType = "application/json";

                // Get request method
                string requestMethod = request.HttpMethod;

                // Get request URL
                string requestUrl = request.Url.AbsolutePath;

                // Get request URL parameters
                string[] requestUrlSplit = requestUrl.Split("/");
                string[] requestUrlParameters = new string[requestUrlSplit.Length - 3];
                Array.Copy(requestUrlSplit, 3, requestUrlParameters, 0, requestUrlSplit.Length - 3);

                // Handle request
                switch (requestMethod)
                {
                    case "GET":
                        switch (requestUrl)
                        {
                            case "/files/netvars.dat":
                                // Build JSON response with a "data" field containing a base64 encoded netvars.dat
                                string netvarsDat = File.ReadAllText("netvars.dat");
                                byte[] netvarsDatBytes = Encoding.UTF8.GetBytes(netvarsDat);
                                string netvarsDatBase64 = Convert.ToBase64String(netvarsDatBytes);
                                JsonObject netvarsDatJson = new JsonObject
                                {
                                    { "data", netvarsDatBase64 }
                                };
                                string netvarsDatJsonString = netvarsDatJson.ToString();
                                byte[] netvarsDatJsonBytes = Encoding.UTF8.GetBytes(netvarsDatJsonString);
                                response.ContentLength64 = netvarsDatJsonBytes.Length;
                                response.OutputStream.Write(netvarsDatJsonBytes, 0, netvarsDatJsonBytes.Length);
                                break;
                            case "/motd":
                                // Build JSON response with serialized MessageOfTheDay
                                string motdJsonString = JsonConvert.SerializeObject(GlobalData.MessageOfTheDay);
                                byte[] motdJsonBytes = Encoding.UTF8.GetBytes(motdJsonString);
                                response.ContentLength64 = motdJsonBytes.Length;
                                response.OutputStream.Write(motdJsonBytes, 0, motdJsonBytes.Length);
                                break;
                            case "/store/catalog/general":
                                // Build JSON response with serialized Catalog
                                string catalogJsonString = JsonConvert.SerializeObject(GlobalData.Catalog);
                                byte[] catalogJsonBytes = Encoding.UTF8.GetBytes(catalogJsonString);
                                response.ContentLength64 = catalogJsonBytes.Length;
                                response.OutputStream.Write(catalogJsonBytes, 0, catalogJsonBytes.Length);
                                break;
                            case "/store/offers":
                                // Check request JSON
                                string requestJsonString = new StreamReader(request.InputStream).ReadToEnd();
                                // If req.query.vendor is 4, send CreditsStore
                                if (requestJsonString.Contains("\"vendor\":4"))
                                {
                                    // Build JSON response with serialized CreditsStore
                                    string creditsStoreJsonString = JsonConvert.SerializeObject(GlobalData.CreditsStore);
                                    byte[] creditsStoreJsonBytes = Encoding.UTF8.GetBytes(creditsStoreJsonString);
                                    response.ContentLength64 = creditsStoreJsonBytes.Length;
                                    response.OutputStream.Write(creditsStoreJsonBytes, 0, creditsStoreJsonBytes.Length);
                                }
                                else
                                {
                                    // Build JSON response with serialized Store
                                    string storeJsonString = JsonConvert.SerializeObject(GlobalData.Store);
                                    byte[] storeJsonBytes = Encoding.UTF8.GetBytes(storeJsonString);
                                    response.ContentLength64 = storeJsonBytes.Length;
                                    response.OutputStream.Write(storeJsonBytes, 0, storeJsonBytes.Length);
                                }
                                break;
                            case "/users/me":
                                // Build JSON response with a user_id field containing 00000000-0000-0000-0000-000000000000
                                JsonObject usersMeJson = new JsonObject
                                {
                                    { "user_id", "00000000-0000-0000-0000-000000000000" }
                                };
                                string usersMeJsonString = usersMeJson.ToString();
                                byte[] usersMeJsonBytes = Encoding.UTF8.GetBytes(usersMeJsonString);
                                response.ContentLength64 = usersMeJsonBytes.Length;
                                response.OutputStream.Write(usersMeJsonBytes, 0, usersMeJsonBytes.Length);
                                break;
                            case "/users/me/inventory":
                                // Build JSON response with serialized Inventory
                                string inventoryJsonString = JsonConvert.SerializeObject(GlobalData.Inventory);
                                byte[] inventoryJsonBytes = Encoding.UTF8.GetBytes(inventoryJsonString);
                                response.ContentLength64 = inventoryJsonBytes.Length;
                                response.OutputStream.Write(inventoryJsonBytes, 0, inventoryJsonBytes.Length);
                                break;
                            case "/users/00000000-0000-0000-0000-000000000000/profile/private":
                                // Build JSON response with serialized SaveData
                                string saveDataJsonString = JsonConvert.SerializeObject(GlobalData.SaveData);
                                byte[] saveDataJsonBytes = Encoding.UTF8.GetBytes(saveDataJsonString);
                                response.ContentLength64 = saveDataJsonBytes.Length;
                                response.OutputStream.Write(saveDataJsonBytes, 0, saveDataJsonBytes.Length);
                                // Log to frontend
                                Log("Save data was requested.");
                                break;
                        }
                        break;
                    case "POST":
                        switch (requestUrl)
                        {
                            case "/auth/token":
                                // Build JSON response with a dummy access token
                                JsonObject authTokenJson = new JsonObject
                                {
                                    { "token_type", "bearer" },
                                    { "access_token", "00000000-0000-0000-0000-000000000000" },
                                    { "expires_in", 1000000 },
                                    { "refresh_token", "" }
                                };
                                string authTokenJsonString = authTokenJson.ToString();
                                byte[] authTokenJsonBytes = Encoding.UTF8.GetBytes(authTokenJsonString);
                                response.ContentLength64 = authTokenJsonBytes.Length;
                                response.OutputStream.Write(authTokenJsonBytes, 0, authTokenJsonBytes.Length);
                                // Log to frontend
                                Log("Log in request was made.");
                                break;
                            case "/store/vouchers/transactions":
                                // Free vouchers from the game
                                List<string> vouchers = new() {
                                    "e8fd70ec-f3ec-519b-8b57-70518c4c4f74",
                                    "640144eb-7862-5186-90d0-606211ec2271",
                                    "54d80a04-cfbc-51a4-91a1-a88a5c96e7ea",
                                    "82a9febc-5f11-57db-8464-2ed2b4df74f9",
                                };
                                // Does the request body contain a voucher? If so, which one?
                                string requestBody = new StreamReader(request.InputStream).ReadToEnd();
                                string voucher = "";
                                foreach (string v in vouchers)
                                {
                                    if (requestBody.Contains(v))
                                    {
                                        voucher = v;
                                        break;
                                    }
                                }
                                // If the voucher is valid, build JSON response with a "transaction_id" field containing the voucher
                                if (voucher != "")
                                {
                                    JsonObject voucherJson = new JsonObject
                                    {
                                        { "transaction_id", voucher }
                                    };
                                    string voucherJsonString = voucherJson.ToString();
                                    byte[] voucherJsonBytes = Encoding.UTF8.GetBytes(voucherJsonString);
                                    response.ContentLength64 = voucherJsonBytes.Length;
                                    response.OutputStream.Write(voucherJsonBytes, 0, voucherJsonBytes.Length);
                                }
                                break;
                            case "/store/purchases/transactions":
                                // Same as above, but don't check for valid vouchers
                                // The "offer_id" field in the request body is the voucher
                                string requestBody2 = new StreamReader(request.InputStream).ReadToEnd();
                                // Find the "offer_id" field
                                string offerId = Regex.Match(requestBody2, @"(?<=offer_id"":"").*?(?="")").Value;
                                // Build JSON response with a "transaction_id" field containing the voucher
                                JsonObject voucherJson2 = new JsonObject
                                {
                                    { "transaction_id", offerId }
                                };
                                string voucherJsonString2 = voucherJson2.ToString();
                                byte[] voucherJsonBytes2 = Encoding.UTF8.GetBytes(voucherJsonString2);
                                response.ContentLength64 = voucherJsonBytes2.Length;
                                response.OutputStream.Write(voucherJsonBytes2, 0, voucherJsonBytes2.Length);
                                break;
                        }
                        break;
                    case "PUT":
                        // Store PUTs will be ignored for now.
                        switch (requestUrl)
                        {
                            case "/users/00000000-0000-0000-0000-000000000000/profile/private":
                                // Read request body
                                string requestBody = new StreamReader(request.InputStream).ReadToEnd();
                                // Deserialize request body
                                UserSaveData requestBodySaveData = JsonConvert.DeserializeObject<UserSaveData>(requestBody);
                                // Update GlobalData.SaveData
                                GlobalData.SaveData = requestBodySaveData;
                                // Write GlobalData.SaveData to file
                                File.WriteAllText("savedata.json", JsonConvert.SerializeObject(GlobalData.SaveData));
                                // Log to frontend
                                Log("Save data was updated.");
                                break;
                        }
                        break;
                }
            }
            catch
            {
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Request Steam API for lobby ID
        // Get "lobbysteamid" field from response, then copy "steam://joinlobby/209000/[LOBBYID]/[STEAMID] to clipboard

        // If the API key is not set, prompt user to set it
        if (apiKey == "")
        {
            MessageBox.Show("Steam Web API Key is not set.", "Error");
            return;
        }

        string steamId = textBox1.Text;
        if (steamId == "")
        {
            MessageBox.Show("Steam ID is not set.", "Error");
            return;
        }

        // Build request URL
        string requestUrl = "https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=" + apiKey + "&format=json&steamids=" + steamId;

        // Send request
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
        request.Method = "GET";
        request.ContentType = "application/json";
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        // Read response
        string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        // Deserialize response
        JsonNode responseJson = JsonNode.Parse(responseString);

        try
        {

            // Get "lobbysteamid" field from response
            string lobbyId = responseJson["response"]["players"][0]["lobbysteamid"].ToString();

            // Copy "steam://joinlobby/209000/[LOBBYID]/[STEAMID] to clipboard
            Clipboard.SetText("steam://joinlobby/209000/" + lobbyId + "/" + steamId);

            // Log to frontend
            Log("Copied steam://joinlobby/209000/" + lobbyId + "/" + steamId + " to clipboard.");
        }
        catch
        {
            // Log to frontend
            Log("Failed to get lobby ID.");
        }
    }

    private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "https://github.com/KiwifruitDev/ArkhamRevivedSelfHosted",
            UseShellExecute = true
        };
        Process.Start(psi);
    }

    private void discordToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "https://discord.gg/rrwWcy82fr",
            UseShellExecute = true
        };
        Process.Start(psi);
    }

    private void openProgramDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = Directory.GetCurrentDirectory(),
            UseShellExecute = true
        };
        Process.Start(psi);
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
