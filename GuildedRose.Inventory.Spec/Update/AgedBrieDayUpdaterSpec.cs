using Xunit;
using GuildedRose.Inventory.Update;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Spec.Update
{
    public class AgedBrieDayUpdaterSpec
    {
        [Fact]
        public void QualityIncreases_ByOne()
        {
            var input = new Item(string.Empty, 5, 2);

            var agedBrie = new AgedBrieDayUpdater();

            var result = agedBrie.Add(input);

            Assert.Equal(input.Quality + 1, result.Quality);
        }

        [Fact]
        public void QualityIncreases_AsPerSpecification()
        {
            var input = new Item(string.Empty, 1, 1);

            var agedBrie = new AgedBrieDayUpdater();

            var result = agedBrie.Add(input);

            Assert.Equal(input.Quality + 1, result.Quality);
        }

        [Fact]
        public void DayDecreases_AsPerSpecification()
        {
            var input = new Item(string.Empty, 1, 1);

            var agedBrie = new AgedBrieDayUpdater();

            var result = agedBrie.Add(input);

            Assert.Equal(input.SellIn - 1, result.SellIn);
        }
    }
}