using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
            start:
                Console.Write("Add meg a téglalap szélességét: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine("Negatív számot adtál meg. Csak pozitív számot adj meg.");
                    Console.ReadKey();
                    Console.Clear();
                    goto start;
                }
                //Console.WriteLine();
                Console.Write("Add meg a téglalap szélességét: ");
                int b = int.Parse(Console.ReadLine());
                if (b < 0)
                {
                    Console.WriteLine("Negatív számot adtál meg. Csak pozitív számot adj meg.");
                    Console.ReadKey();
                    Console.Clear();
                    goto start;
                }
                Console.WriteLine();
                Console.Write("A téglalap kerülete: ");
                Console.WriteLine(kerulet(a, b));
                Console.Write("A téglalap területe: ");
                Console.WriteLine(terulet(a, b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
           







            Console.ReadKey();
        }
        static int kerulet(int szam1, int szam2)
        {
            int szam = 2*(szam1 + szam2);
            return szam;
        }
        static int terulet(int szam1, int szam2)
        {
            int szam =  szam1 * szam2;
            return szam;
        }
    }
}
