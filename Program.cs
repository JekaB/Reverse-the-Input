using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            Console.WriteLine("Когда надоеcт нажмине END");
            bool quit = true;

            string s = "";
            while (quit)
            {
                s = Console.ReadLine();
                if (s != "END")
                {
                    lst.Add(s);

                }
                else
                {
                    quit = false;
                }
            }

            lst.Reverse();
            foreach (var item in lst)
            {
                Console.WriteLine("-> {0}", item);
            }
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
