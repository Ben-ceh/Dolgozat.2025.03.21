using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listam2 = new List<int>();

            listam2 = ListaKiir(10);
            //Console.WriteLine(ListaKiir(10));
            Console.WriteLine(ListaOsszeg(listam2));
            Console.WriteLine(ListaSzorzat(listam2));
            Console.WriteLine(ListaAtlag(listam2));





            Console.ReadKey();
        }
        static List<int> ListaKiir(int szam1)
        {
            List<int> listam = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < szam1; i++)
            {
                int vltszam = rnd.Next(10, 100);

                listam.Add(vltszam);
            }
            Console.Write("A lista elemei: ");
            for (int i = 0; i < listam.Count; i++)
            {
                Console.Write($"{listam[i]}, ");
            }
            List<int>listam1 = new List<int>(listam);
            Console.WriteLine();
            return  listam; 
        }
        static int ListaOsszeg(List<int> listam)
        {
            int osszeg = 0;
            for (int i = 0; i < listam.Count; i++)
            {
                osszeg += listam[i];
            }
            Console.Write("Összeg: ");
            return osszeg;
        }
        static int ListaSzorzat(List<int> listam)
        {
            int szorzat=1;
            for (int i = 0; i < listam.Count; i++)
            {
                szorzat *= listam[i];
            }
            Console.Write("Szorzat: ");

            return szorzat;
        }
        static double ListaAtlag(List<int> listam)
        {
            int osszeg=0;
            int db = listam.Count;
            for (int i = 0; i < listam.Count; i++)
            {
                osszeg += listam[i];
            }
            Console.Write("Átlag: ");
            double atlagVeg = osszeg / db;
            return atlagVeg;
        }
    }
}
