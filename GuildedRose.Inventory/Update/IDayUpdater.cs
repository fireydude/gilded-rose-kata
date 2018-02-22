using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Update
{
    public interface IDayUpdater
    {
        Item Add(Item item);
    }
}