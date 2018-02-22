using System;

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

                
            }
            else
            {
                Console.WriteLine("Please supply one argument which should be the path to the input file");
            }
        }
    }
}
