using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class NormalDayUpdater
    {
        public Item Add(Item item)
        {
            var degradeAmount = item.SellIn < 0 ? 2 : 1;
            var newQuality = item.Quality - degradeAmount;
            if(newQuality < 0)
            {
                newQuality = 0;
            }
            return new Item(item.Name, item.SellIn - 1, newQuality);
        }
    }
}