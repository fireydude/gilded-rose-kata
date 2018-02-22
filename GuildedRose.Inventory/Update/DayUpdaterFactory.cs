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
                break;
                case "Backstage passes":
                    return new BackstagePassesDayUpdater();
                case "Normal Item":
                    return new NormalDayUpdater();
                default:
                    return null;
            }
        }
    }
}