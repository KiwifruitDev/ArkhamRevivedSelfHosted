namespace ArkhamRevivedSelfHosted;

public class CatalogData
{
    public Dictionary<string, CatalogItem> items { get; set; }
}

public class CatalogItem
{
    public string category { get; set; }
    public Dictionary<string, string> info { get; set; }
    public string name { get; set; }
    public string video_url { get; set; }
    public Dictionary<string, string> data { get; set; }
    public int flags { get; set; }
    public string icon_url { get; set; }
    public string category_id { get; set; }
    public int type { get; set; }
    public string id { get; set; }
    public string description { get; set; }
}
