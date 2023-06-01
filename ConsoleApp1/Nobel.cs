using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nobel
    {
        int evszam;
        string tipus;
        string keresztnev;
        string vezeteknev;


        public Nobel(string sor)
        {
            string[] felosztas = sor.Split(';');
            this.evszam = int.Parse(felosztas[0]);
            this.tipus = felosztas[1];
            this.keresztnev = felosztas[2];
            this.vezeteknev = felosztas[3];
        }

        public int Evszam { get => evszam; }
        public string Tipus { get => tipus;}
        public string Keresztnev { get => keresztnev;}
        public string Vezeteknev { get => vezeteknev;}

        
    }
}
