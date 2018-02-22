using System;
using Xunit;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Spec
{
    public class ItemSpec
    {
        [Fact]
        public void SellInValue()
        {
            var sellIn = 99;

            var input = new Item("",sellIn, 0);

            Assert.Equal(sellIn, input.SellIn);
        }

        [Fact]
        public void QualityValue()
        {
            var qualityValue = 101;

            var input = new Item("", 0, qualityValue);

            Assert.Equal(qualityValue, input.Quality);
        }
        
        [Fact]
        public void NameValue()
        {
            var name = "Item Name";

            var input = new Item(name, 0, 0);

            Assert.Equal(name, input.Name);
        }
    }
}
