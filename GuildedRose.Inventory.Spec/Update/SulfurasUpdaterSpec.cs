using Xunit;
using GuildedRose.Inventory.Update;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Spec.Update
{
    public class SulfurasUpdaterSpec
    {
        [Fact]
        public void PositiveDays_AlwaysReturn2()
        {
            var input = new Item(string.Empty, 99, 99);

            var day = new SulfurasUpdater();
            var result = day.Add(input);

            Assert.Equal(2, result.Quality);
        }

        [Fact]
        public void NegativeDays_AlwaysReturn2()
        {
            var input = new Item(string.Empty, -99, 99);

            var day = new SulfurasUpdater();
            var result = day.Add(input);

            Assert.Equal(2, result.Quality);
        }
    }
}