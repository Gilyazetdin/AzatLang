using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzatLang
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser("example.azat");
            Interpretator inter = new Interpretator();
            foreach (var line in parser.ReadAll())
            {
                inter.Translate(line);
            }
            Console.ReadKey(false);
        }
    }
}
