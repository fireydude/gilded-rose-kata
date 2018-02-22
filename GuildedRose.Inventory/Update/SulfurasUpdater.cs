using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public class SulfurasUpdater : IDayUpdater
    {
        public Item Add(Item item)
        {
            return new Item(item.Name, 2, 2);
        }
    }
}