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
                default:
                    return new NormalDayUpdater();
            }
        }
    }
}