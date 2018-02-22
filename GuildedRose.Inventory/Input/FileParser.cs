using System;
using System.Collections.Generic;
using System.IO;
using GuildedRose.Inventory.Models;

namespace GuildedRose.Inventory.Input
{
    public class FileParser
    {
        public IEnumerable<Item> ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var remainingLine = line;
                var quality = int.Parse(GetLastItem(ref remainingLine));
                var day = int.Parse(GetLastItem(ref remainingLine));
                var name = remainingLine;

                yield return new Item(name, day, quality);
            }
        }

        public string GetLastItem(ref string line)
        {
            var lastItem = line.Substring(line.LastIndexOf(' ') + 1);
            line = line.Substring(0, line.Length - lastItem.Length - 1);
            return lastItem;
        }
    }
}