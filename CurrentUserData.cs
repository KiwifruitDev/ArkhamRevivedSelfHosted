namespace ArkhamRevivedSelfHosted;

public static class GlobalData
{
    public static UserSaveData SaveData { get; set; }
    public static UserInventoryData Inventory { get; set; }
    public static CatalogData Catalog { get; set; }
    public static IndexedObject<MessageOfTheDayItem> MessageOfTheDay { get; set; }
    public static IndexedObject<StoreItem> Store { get; set; }
    public static IndexedObject<StoreItem> CreditsStore { get; set; }
}