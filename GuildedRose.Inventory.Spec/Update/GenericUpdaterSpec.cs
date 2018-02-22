using Xunit;
using GuildedRose.Inventory.Update;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Spec.Update
{
    public class GenericUpdaterSpec
    {
        [Fact]
        public void Quality_IsNeverGreaterThan50()
        {
            var allUpdaters = new IDayUpdater[]
            {
                new AgedBrieDayUpdater(),
                new BackstagePassesDayUpdater(),
                new ConjuredUpdater(),
                new NormalDayUpdater(),
                new SulfurasUpdater()
            };
            foreach (var day in allUpdaters)
            {
                var input = new Item(string.Empty, 5, 100);

                var result = day.Add(input);

                Assert.False(50 < result.Quality, day.GetType().Name + " quality = " + result.Quality.ToString());
            }
        }

        [Fact]
        public void Quality_IsNeverNegative()
        {
            var allUpdaters = new IDayUpdater[]
            {
                new AgedBrieDayUpdater(),
                new BackstagePassesDayUpdater(),
                new ConjuredUpdater(),
                new NormalDayUpdater(),
                new SulfurasUpdater()
            };
            foreach (var day in allUpdaters)
            {
                var input = new Item(string.Empty, 5, -100);

                var result = day.Add(input);

                Assert.False(0 > result.Quality, day.GetType().Name + " quality = " + result.Quality.ToString());
            }
        }

        [Fact]
        public void PositiveDay_DayIsDescreasedBy1_ExceptSulfuras()
        {
            var allUpdatersExceptSulfuras = new IDayUpdater[]
            {
                new AgedBrieDayUpdater(),
                new BackstagePassesDayUpdater(),
                new ConjuredUpdater(),
                new NormalDayUpdater()
            };
            foreach (var day in allUpdatersExceptSulfuras)
            {
                var input = new Item(string.Empty, 5, 100);

                var result = day.Add(input);

                Assert.True(4 == result.SellIn, day.GetType().Name + " SellIn=" + result.SellIn);
            }
        }

        [Fact]
        public void NegativeDay_DayIsDescreasedBy1_ExceptSulfuras()
        {
            var allUpdatersExceptSulfuras = new IDayUpdater[]
            {
                new AgedBrieDayUpdater(),
                new BackstagePassesDayUpdater(),
                new ConjuredUpdater(),
                new NormalDayUpdater()
            };
            foreach (var day in allUpdatersExceptSulfuras)
            {
                var input = new Item(string.Empty, -5, 100);

                var result = day.Add(input);

                Assert.True(-6 == result.SellIn, day.GetType().Name + " SellIn=" + result.SellIn);
            }
        }
    }
}