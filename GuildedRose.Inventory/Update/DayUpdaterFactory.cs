namespace GuildedRose.Inventory.Update
{
    public class DayUpdaterFactory  
    {
        public IDayUpdater GetDayUpdater(string itemName)
        {
            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrieDayUpdater();
                case "Backstage passes":
                    return new BackstagePassesDayUpdater();
                case "Normal Item":
                    return new NormalDayUpdater();
                case "Sulfuras":
                    return new SulfurasUpdater();
                case "Conjured":
                    return new ConjuredUpdater();
                default:
                    return null;
            }
        }
    }
}