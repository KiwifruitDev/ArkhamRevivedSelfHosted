namespace ArkhamRevivedSelfHosted;

public class IndexedObject<T>
{
    public int total_count { get; set; }
    public int next_page { get; set; }
    public List<T> items { get; set; }
    public int page { get; set; }
    public int pages { get; set; }
}

public class MessageOfTheDayItem
{
    public string published_at { get; set; }
    public string _id { get; set; }
    public string? contents { get; set; }
    public string title { get; set; }
}

public class StoreItem
{
    public string item_id { get; set; }
    public Dictionary<string, int> price { get; set; }
    public int vendor { get; set; }
    public string id { get; set; }
    public string product_id { get; set; }
}
