using Xunit;
using GuildedRose.Inventory.Update;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Spec.Update
{
    public class ConjuredUpdaterSpec
    {
        [Fact]
        public void BeforeSellBy_DegradesAtDouble()
        {
            var input = new Item(string.Empty, 2, 2);

            var day = new ConjuredUpdater();
            var result = day.Add(input);

            Assert.Equal(input.Quality - 2, result.Quality);
        }

        [Fact]
        public void AfterSellBy_DegradesAtDouble()
        {
            var input = new Item(string.Empty, -1, 5);

            var day = new ConjuredUpdater();
            var result = day.Add(input);

            Assert.Equal(input.Quality - 4, result.Quality);
        }
    }
}