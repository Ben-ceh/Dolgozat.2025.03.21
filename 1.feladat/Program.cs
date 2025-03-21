using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> listam = new List<int>{ 12, 10, 38, 1, -6, 23, 9, 15 };

            listam.Remove(-6);
            listam.Add(20);
            listam.Add(30);
            Console.WriteLine("A lista elemei: ");
            for (int i = 0; i < listam.Count; i++)
            {
                Console.Write($"{listam[i]}, ");
            }
            listam.Sort();
            Console.WriteLine();
            Console.WriteLine($"Legkisebb elem: {listam[0]}");
            listam.Reverse();
            Console.WriteLine($"Legnagyobb elem: {listam[0]}");
            Console.WriteLine("Páratlan számok:");
            listam.Reverse();
            for (int i = 0; i < listam.Count; i++)
            {
                if (listam[i] % 2 == 1)
                {
                    Console.Write($"{listam[i]}, ");
                }




            }












            Console.ReadKey();
        }
    }
}
