using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class NormalDayUpdater : IDayUpdater
    {
        protected int QualityDegrade = 1;
        protected int QualityDegradeAfterSellBy = 2;
        
        public virtual Item Add(Item item)
        {
            var degradeAmount = item.SellIn < 0 ? QualityDegradeAfterSellBy : QualityDegrade;
            var newQuality = item.Quality - degradeAmount;
            if(newQuality < 0)
            {
                newQuality = 0;
            }
            else if(newQuality > 50)
            {
                newQuality = 50;
            }
            return new Item(item.Name, item.SellIn - 1, newQuality);
        }
    }
}