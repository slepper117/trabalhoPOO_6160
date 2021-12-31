using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO_6160
{
    class Program
    {
        static void Main(string[] args)
        {
            Client p1 = new Client("Cliente 1", "Endereço Cliente 1");
            string x = p1.Address;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
