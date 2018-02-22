using System;
using GuildedRose.Inventory.Input;
using GuildedRose.Inventory.Update;

namespace GuildedRose.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1)
            {
                var path = args[0];
                var fileParser = new Input.FileParser();
                var items = fileParser.ReadFile(path);

                foreach(var item in items)
                {
                    var dayAdder = new NormalDayUpdater();
                    var updatedItem = dayAdder.Add(item);
                    Console.WriteLine($"{updatedItem.Name} {updatedItem.SellIn} {updatedItem.Quality}");
                }
            }
            else
            {
                Console.WriteLine("Please supply one argument which should be the path to the input file");
            }
        }
    }
}
