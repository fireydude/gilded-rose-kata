using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class ConjuredUpdater : NormalDayUpdater, IDayUpdater
    {
        public ConjuredUpdater()
        {
            QualityDegrade = QualityDegrade * 2;
            QualityDegradeAfterSellBy = QualityDegradeAfterSellBy * 2;
        }
    }
}