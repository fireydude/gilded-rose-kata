using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class AgedBrieDayUpdater : NormalDayUpdater, IDayUpdater
    {
        public AgedBrieDayUpdater()
        {
            QualityDegrade = QualityDegrade * -1;
            QualityDegradeAfterSellBy = QualityDegrade;
        }
    }
}