using GuildedRose.Inventory.Models;
using GuildedRose.Inventory.Update;
using Xunit;

namespace GuildedRose.Inventory.Spec.Update
{
    public class NormalDayUpdaterSpec
    {
        [Fact]
        public void SellByDateNotPassed_Quality_LowersValueByOne()
        {
            var input = new Item(string.Empty, 5, 2);

            var day = new NormalDayUpdater();
            var result = day.Add(input);

            Assert.Equal(input.Quality - 1, result.Quality);
        }

        [Fact]
        public void OnSellByDate_Quality_LowersValueByOne()
        {
            var input = new Item(string.Empty, 0, 2);

            var day = new NormalDayUpdater();
            var result = day.Add(input);

            Assert.Equal(input.Quality - 1, result.Quality);
        }

        [Fact]
        public void SellByDateHasPassed_Quality_LowersValueByTwo()
        {
            var input = new Item(string.Empty, -1, 2);

            var day = new NormalDayUpdater();
            var result = day.Add(input);

            Assert.Equal(input.Quality - 2, result.Quality);
        }

        [Fact]
        public void SellByDateNotPassed_ZeroQuality_DoesNotLower()
        {
            var input = new Item(string.Empty, 5, 0);

            var day = new NormalDayUpdater();
            var result = day.Add(input);

            Assert.Equal(0, result.Quality);
        }

    }
}