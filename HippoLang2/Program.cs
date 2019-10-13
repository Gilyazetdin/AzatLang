using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippoLang2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser("a.hippo");
            Interpretator inter = new Interpretator();
            foreach (var elem in parser.ReadAll())
            {
                inter.Translate(elem);
            }
            Console.ReadKey(false);
        }
    }
}
