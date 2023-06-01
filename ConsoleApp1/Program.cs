using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Feladat
            List<Nobel> lista = new List<Nobel>(File.ReadAllLines("C:/GCs/ConsoleApp1/ConsoleApp1/nobel.csv").Skip(1).Select(x => new Nobel(x)).ToList());

            //4.Feladat
            List<Nobel> irodalmiDijak = lista.Where(x => x.Tipus == "irodalmi" && x.Evszam == 2017).ToList();
            foreach (var item in irodalmiDijak)
            {
                Console.WriteLine($"4.Feladat: {item.Keresztnev} {item.Vezeteknev}");
            }


            //6.Feladat
            List<Nobel> curieTagok = lista.Where(x => x.Vezeteknev.Contains("Curie")).ToList();
            Console.WriteLine("6.Feladat:");
            foreach (var item in curieTagok)
            {
                Console.WriteLine($"\t{item.Evszam}:{item.Keresztnev} {item.Vezeteknev} ({item.Tipus})");
            }

            //7.Feladat
            Console.WriteLine("7.Feladat");
            Console.WriteLine($"\tfizikai                            {lista.Count(x => x.Tipus=="fizikai")} db");
            Console.WriteLine($"\tkémiai                             {lista.Count(x => x.Tipus == "kémiai")} db");
            Console.WriteLine($"\torvosi                             {lista.Count(x => x.Tipus == "orvosi")} db");
            Console.WriteLine($"\tirodalmi:                          {lista.Count(x => x.Tipus == "irodalmi")} db");
            Console.WriteLine($"\tbéke                               {lista.Count(x => x.Tipus == "béke")} db");
            Console.WriteLine($"\tközgazdaságtani                     {lista.Count(x => x.Tipus == "közgazdaságtani")} db");

            //8.Feladat
            StreamWriter sr = new StreamWriter("orvosi.txt");
            foreach (var item in lista)
            {
                if (item.Tipus == "orvosi")
                {
                    sr.WriteLine($"{item.Evszam}:{item.Keresztnev} {item.Vezeteknev}");
                }
            }
            Console.WriteLine("Sikeres mentés!");

        }
    }
}
