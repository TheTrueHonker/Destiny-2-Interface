using System.ComponentModel;

namespace Destiny_2_Interface.Enum
{
    public enum DestinyComponentType
    {
        [Description("None")]
        None = 0,
        [Description("Profiles")]
        Profiles = 100,
        [Description("VendorReceipts")]
        VendorReceipts = 101,
        [Description("ProfileInventories")]
        ProfileInventories = 102,
        [Description("ProfileCurrencies")]
        ProfileCurrencies = 103,
        [Description("ProfileProgression")]
        ProfileProgression = 104,
        [Description("PlatformSilver")]
        PlatformSilver = 105,
        [Description("Characters")]
        Characters = 200,
        [Description("CharacterInventories")]
        CharacterInventories = 201,
        [Description("CharacterProgressions")]
        CharacterProgressions = 202,
        [Description("CharacterRenderData")]
        CharacterRenderData = 203,
        [Description("CharacterActivities")]
        CharacterActivities = 204,
        [Description("CharacterEquipment")]
        CharacterEquipment = 205,
        [Description("ItemInstances")]
        ItemInstances = 300,
        [Description("ItemObjectives")]
        ItemObjectives = 301,
        [Description("ItemPerks")]
        ItemPerks = 302,
        [Description("ItemRenderData")]
        ItemRenderData = 303,
        [Description("ItemStats")]
        ItemStats = 304,
        [Description("ItemSockets")]
        ItemSockets = 305,
        [Description("ItemTalentGrids")]
        ItemTalentGrids = 306,
        [Description("ItemCommonData")]
        ItemCommonData = 307,
        [Description("ItemPlugStates")]
        ItemPlugStates = 308,
        [Description("ItemPlugObjectives")]
        ItemPlugObjectives = 309,
        [Description("ItemReuseablePlugs")]
        ItemReuseablePlugs = 310,
        [Description("Vendors")]
        Vendors = 400,
        [Description("VendorCategories")]
        VendorCategories = 401,
        [Description("VendorSales")]
        VendorSales = 402,
        [Description("Kiosks")]
        Kiosks = 500,
        [Description("CurrencyLookups")]
        CurrencyLookups = 600,
        [Description("PresentationNodes")]
        PresentationNodes = 700,
        [Description("Collectibles")]
        Collectibles = 800,
        [Description("Records")]
        Records = 900,
        [Description("Transitory")]
        Transitory = 1000,
        [Description("Metrics")]
        Metrics = 1100
    }
}
