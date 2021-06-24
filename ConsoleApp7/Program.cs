using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1, sayi2, toplam = 0;
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
            Console.ReadLine();
        }
    }
}
