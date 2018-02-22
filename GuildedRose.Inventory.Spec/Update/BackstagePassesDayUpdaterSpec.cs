using GuildedRose.Inventory.Models;
using GuildedRose.Inventory.Update;
using Xunit;

namespace GuildedRose.Inventory.Spec.Update
{
    public class BackstagePassesDayUpdaterSpec
    {
        [Fact]
        public void SellInMoreThan10Day_QualityIncreases_ByOne()
        {
            var input = new Item(string.Empty, 15, 2);

            var target = new BackstagePassesDayUpdater();

            var result = target.Add(input);

            Assert.Equal(input.Quality + 1, result.Quality);
        }

        [Fact]
        public void SellIn10OrLessDays_QualityIncreases_ByTwo()
        {
            var input = new Item(string.Empty, 9, 2);

            var target = new BackstagePassesDayUpdater();

            var result = target.Add(input);

            Assert.Equal(input.Quality + 2, result.Quality);
        }

        [Fact]
        public void SellIn5OrLessDays_QualityIncreases_By3()
        {
            var input = new Item(string.Empty, 5, 2);

            var target = new BackstagePassesDayUpdater();

            var result = target.Add(input);

            Assert.Equal(input.Quality + 3, result.Quality);
        }

    }
}