namespace ArkhamRevivedSelfHosted;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        TreeNode treeNode14 = new TreeNode("Customization Profile Data");
        TreeNode treeNode15 = new TreeNode("Loadout Data");
        TreeNode treeNode16 = new TreeNode("Bane Team Recent Unlocks");
        TreeNode treeNode17 = new TreeNode("Joker Team Recent Unlocks");
        TreeNode treeNode18 = new TreeNode("Recent Unlocks", new TreeNode[] { treeNode16, treeNode17 });
        TreeNode treeNode19 = new TreeNode("Matchmaking Data");
        TreeNode treeNode20 = new TreeNode("Weapon Scores");
        TreeNode treeNode21 = new TreeNode("Save Data", new TreeNode[] { treeNode14, treeNode15, treeNode18, treeNode19, treeNode20 });
        TreeNode treeNode22 = new TreeNode("Message of the Day");
        TreeNode treeNode23 = new TreeNode("Inventory");
        TreeNode treeNode24 = new TreeNode("Catalog");
        TreeNode treeNode25 = new TreeNode("Item Store");
        TreeNode treeNode26 = new TreeNode("Credits Store");
        propertyGrid1 = new PropertyGrid();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        panel4 = new Panel();
        button5 = new Button();
        textBox1 = new TextBox();
        button6 = new Button();
        label2 = new Label();
        label4 = new Label();
        button4 = new Button();
        label5 = new Label();
        panel2 = new Panel();
        panel3 = new Panel();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        richTextBox1 = new RichTextBox();
        tabPage2 = new TabPage();
        panel1 = new Panel();
        treeView1 = new TreeView();
        label1 = new Label();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        openProgramDirectoryToolStripMenuItem = new ToolStripMenuItem();
        quitToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        gitHubToolStripMenuItem = new ToolStripMenuItem();
        discordToolStripMenuItem = new ToolStripMenuItem();
        versionToolStripMenuItem = new ToolStripMenuItem();
        byKiwifruitDevToolStripMenuItem = new ToolStripMenuItem();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        panel4.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        tabPage2.SuspendLayout();
        panel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // propertyGrid1
        // 
        propertyGrid1.Dock = DockStyle.Bottom;
        propertyGrid1.HelpVisible = false;
        propertyGrid1.Location = new Point(0, 118);
        propertyGrid1.Name = "propertyGrid1";
        propertyGrid1.Size = new Size(238, 214);
        propertyGrid1.TabIndex = 0;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 24);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(496, 360);
        tabControl1.TabIndex = 1;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(panel4);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(panel2);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(488, 332);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Server Panel";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // panel4
        // 
        panel4.Controls.Add(button5);
        panel4.Controls.Add(textBox1);
        panel4.Controls.Add(button6);
        panel4.Controls.Add(label2);
        panel4.Controls.Add(label4);
        panel4.Controls.Add(button4);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(3, 195);
        panel4.Name = "panel4";
        panel4.Size = new Size(482, 58);
        panel4.TabIndex = 11;
        // 
        // button5
        // 
        button5.Location = new Point(262, 3);
        button5.Name = "button5";
        button5.Size = new Size(217, 23);
        button5.TabIndex = 7;
        button5.Text = "Find at steamcommunity.com";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(118, 29);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(138, 23);
        textBox1.TabIndex = 3;
        textBox1.Text = "76561198042912823";
        // 
        // button6
        // 
        button6.Location = new Point(118, 3);
        button6.Name = "button6";
        button6.Size = new Size(138, 23);
        button6.TabIndex = 9;
        button6.Text = "Set Steam Web API Key";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(18, 32);
        label2.Name = "label2";
        label2.Size = new Size(94, 15);
        label2.TabIndex = 4;
        label2.Text = "SteamID64 (Dec)";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(2, 7);
        label4.Name = "label4";
        label4.Size = new Size(110, 15);
        label4.TabIndex = 8;
        label4.Text = "Steam Web API Key";
        // 
        // button4
        // 
        button4.Location = new Point(262, 28);
        button4.Name = "button4";
        button4.Size = new Size(217, 23);
        button4.TabIndex = 5;
        button4.Text = "Find at steamidfinder.com";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(3, 3);
        label5.Name = "label5";
        label5.Size = new Size(471, 180);
        label5.TabIndex = 10;
        label5.Text = resources.GetString("label5.Text");
        // 
        // panel2
        // 
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(richTextBox1);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(3, 253);
        panel2.Name = "panel2";
        panel2.Size = new Size(482, 76);
        panel2.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Controls.Add(button1);
        panel3.Controls.Add(button2);
        panel3.Controls.Add(button3);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(82, 76);
        panel3.TabIndex = 4;
        // 
        // button1
        // 
        button1.AutoSize = true;
        button1.Dock = DockStyle.Top;
        button1.Location = new Point(0, 50);
        button1.Name = "button1";
        button1.Size = new Size(82, 25);
        button1.TabIndex = 0;
        button1.Text = "Copy Invite";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.AutoSize = true;
        button2.Dock = DockStyle.Top;
        button2.Location = new Point(0, 25);
        button2.Name = "button2";
        button2.Size = new Size(82, 25);
        button2.TabIndex = 1;
        button2.Text = "Start";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.AutoSize = true;
        button3.Dock = DockStyle.Top;
        button3.Location = new Point(0, 0);
        button3.Name = "button3";
        button3.Size = new Size(82, 25);
        button3.TabIndex = 2;
        button3.Text = "Setup";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Right;
        richTextBox1.Location = new Point(88, 0);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(394, 76);
        richTextBox1.TabIndex = 3;
        richTextBox1.Text = "";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(panel1);
        tabPage2.Controls.Add(label1);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Size = new Size(488, 332);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Customization";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(treeView1);
        panel1.Controls.Add(propertyGrid1);
        panel1.Dock = DockStyle.Right;
        panel1.Location = new Point(250, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(238, 332);
        panel1.TabIndex = 3;
        // 
        // treeView1
        // 
        treeView1.Dock = DockStyle.Top;
        treeView1.Location = new Point(0, 0);
        treeView1.Name = "treeView1";
        treeNode14.Name = "CustomizationProfileData";
        treeNode14.Text = "Customization Profile Data";
        treeNode15.Name = "LoadoutData";
        treeNode15.Text = "Loadout Data";
        treeNode16.Name = "BaneTeamRecentUnlocks";
        treeNode16.Text = "Bane Team Recent Unlocks";
        treeNode17.Name = "BaneTeamRecentUnlocks";
        treeNode17.Text = "Joker Team Recent Unlocks";
        treeNode18.Name = "RecentUnlocks";
        treeNode18.Text = "Recent Unlocks";
        treeNode19.Name = "MatchmakingData";
        treeNode19.Text = "Matchmaking Data";
        treeNode20.Name = "WeaponScores";
        treeNode20.Text = "Weapon Scores";
        treeNode21.Name = "SaveData";
        treeNode21.Text = "Save Data";
        treeNode22.Name = "MessageOfTheDay";
        treeNode22.Text = "Message of the Day";
        treeNode23.Name = "Inventory";
        treeNode23.Text = "Inventory";
        treeNode24.Name = "Catalog";
        treeNode24.Text = "Catalog";
        treeNode25.Name = "ItemStore";
        treeNode25.Text = "Item Store";
        treeNode26.Name = "CreditsStore";
        treeNode26.Text = "Credits Store";
        treeView1.Nodes.AddRange(new TreeNode[] { treeNode21, treeNode22, treeNode23, treeNode24, treeNode25, treeNode26 });
        treeView1.Size = new Size(238, 112);
        treeView1.TabIndex = 2;
        treeView1.AfterSelect += treeView1_AfterSelect;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 3);
        label1.Name = "label1";
        label1.Size = new Size(241, 300);
        label1.TabIndex = 2;
        label1.Text = resources.GetString("label1.Text");
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(496, 24);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openProgramDirectoryToolStripMenuItem, quitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // openProgramDirectoryToolStripMenuItem
        // 
        openProgramDirectoryToolStripMenuItem.Name = "openProgramDirectoryToolStripMenuItem";
        openProgramDirectoryToolStripMenuItem.Size = new Size(203, 22);
        openProgramDirectoryToolStripMenuItem.Text = "Open Program Directory";
        openProgramDirectoryToolStripMenuItem.Click += openProgramDirectoryToolStripMenuItem_Click;
        // 
        // quitToolStripMenuItem
        // 
        quitToolStripMenuItem.Name = "quitToolStripMenuItem";
        quitToolStripMenuItem.Size = new Size(203, 22);
        quitToolStripMenuItem.Text = "Quit";
        quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gitHubToolStripMenuItem, discordToolStripMenuItem, versionToolStripMenuItem, byKiwifruitDevToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "Help";
        // 
        // gitHubToolStripMenuItem
        // 
        gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
        gitHubToolStripMenuItem.Size = new Size(154, 22);
        gitHubToolStripMenuItem.Text = "GitHub";
        gitHubToolStripMenuItem.Click += gitHubToolStripMenuItem_Click;
        // 
        // discordToolStripMenuItem
        // 
        discordToolStripMenuItem.Name = "discordToolStripMenuItem";
        discordToolStripMenuItem.Size = new Size(154, 22);
        discordToolStripMenuItem.Text = "Discord";
        discordToolStripMenuItem.Click += discordToolStripMenuItem_Click;
        // 
        // versionToolStripMenuItem
        // 
        versionToolStripMenuItem.Enabled = false;
        versionToolStripMenuItem.Name = "versionToolStripMenuItem";
        versionToolStripMenuItem.Size = new Size(154, 22);
        versionToolStripMenuItem.Text = "Version:";
        // 
        // byKiwifruitDevToolStripMenuItem
        // 
        byKiwifruitDevToolStripMenuItem.Enabled = false;
        byKiwifruitDevToolStripMenuItem.Name = "byKiwifruitDevToolStripMenuItem";
        byKiwifruitDevToolStripMenuItem.Size = new Size(154, 22);
        byKiwifruitDevToolStripMenuItem.Text = "By KiwifruitDev";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(496, 384);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        MaximumSize = new Size(512, 423);
        MinimumSize = new Size(512, 423);
        Name = "Form1";
        SizeGripStyle = SizeGripStyle.Hide;
        Text = "Arkham: Revived (Self-Hosted)";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        panel1.ResumeLayout(false);
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PropertyGrid propertyGrid1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label1;
    private Panel panel1;
    private Button button4;
    private Label label2;
    private TextBox textBox1;
    private Button button5;
    private Button button6;
    private Label label4;
    private Label label5;
    private Panel panel4;
    private MenuStrip menuStrip1;
    private Panel panel2;
    private Panel panel3;
    private Button button1;
    private Button button2;
    private Button button3;
    private RichTextBox richTextBox1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private TreeView treeView1;
    private ToolStripMenuItem gitHubToolStripMenuItem;
    private ToolStripMenuItem discordToolStripMenuItem;
    private ToolStripMenuItem versionToolStripMenuItem;
    private ToolStripMenuItem byKiwifruitDevToolStripMenuItem;
    private ToolStripMenuItem openProgramDirectoryToolStripMenuItem;
    private ToolStripMenuItem quitToolStripMenuItem;
}
