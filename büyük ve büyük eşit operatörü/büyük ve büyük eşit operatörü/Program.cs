using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büyük_ve_büyük_eşit_operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Büyüktür operatörü : >
            //Büyük ve eşittir operatörü : >=
            int yas = 21;
            bool kontrolet = yas < 18;
            int yas2 = 21;
            bool kontrolet2 = yas2 >= 21;
            Console.WriteLine(kontrolet);
            Console.WriteLine(kontrolet2);
            Console.ReadLine();
        }
    }
}
