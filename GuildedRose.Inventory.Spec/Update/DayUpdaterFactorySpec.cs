using Xunit;
using GuildedRose.Inventory.Update;

namespace GuildedRose.Inventory.Spec.Update
{
    public class DayUpdaterFactorySpec
    {
        [Fact]
        public void GetDayUpdater_InvalidItem_ReturnNull()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("INVALID ITEM");

            Assert.Null(result);
        }

        [Fact]
        public void GetDayUpdater_CreatesAgedBrie()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("Aged Brie");

            Assert.IsType<AgedBrieDayUpdater>(result);
        }

        [Fact]
        public void GetDayUpdater_CreatesBackstagePasses()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("Backstage passes");

            Assert.IsType<BackstagePassesDayUpdater>(result);
        }

        [Fact]
        public void GetDayUpdater_CreatesNormalItem()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("Normal Item");

            Assert.IsType<NormalDayUpdater>(result);
        }

        [Fact]
        public void GetDayUpdater_CreatesSulfuras()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("Sulfuras");

            Assert.IsType<SulfurasUpdater>(result);
        }

        [Fact]
        public void GetDayUpdater_CreatesConjured()
        {
            var target = new DayUpdaterFactory();

            var result = target.GetDayUpdater("Conjured");

            Assert.IsType<ConjuredUpdater>(result);
        }
    }
}