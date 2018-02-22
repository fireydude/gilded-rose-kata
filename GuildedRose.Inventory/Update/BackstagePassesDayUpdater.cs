using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class BackstagePassesDayUpdater : NormalDayUpdater, IDayUpdater
    {
        public override Item Add(Item item)
        {
            if(item.SellIn > 10)
            {
                QualityDegrade = QualityDegrade * -1;                
            }
            else if(item.SellIn > 5)
            {
                QualityDegrade = QualityDegrade * -2;
            }
            else if(item.SellIn > 1)
            {
                QualityDegrade = QualityDegrade * -3;
            }
            else
            {
                QualityDegrade = 0;
            }
            return base.Add(item);
        }
    }
}