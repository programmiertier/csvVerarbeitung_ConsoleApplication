using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csvVerarbeitung_ConsoleApplication
{
    class Program
    {
        public static void warten()
        {
            WriteLine("Weiter mit Enter");
            ReadLine();
        }

        static void Main(string[] args)
        {
            // ein Objekt mit Daten erstellen
            // PLZ dieDaten = new PLZ();
            // WriteLine(dieDaten.ortsangaben[0].id);  // geht nur, wenn ort public gemacht ist
            string[] csvZeilen = File.ReadAllLines("plz.csv");
            for (int zaehler = 0; zaehler < csvZeilen.Length; zaehler++)
            {
                WriteLine("{0}", csvZeilen[zaehler].Split(',')[0]);
            }
            warten();
            // Abfragen LINQ an das Objekt richten

            // alle vorhandenen Orte nennen

            // macht das selbe
            /*var alleOrte = (from alles in dieDaten.ortsangaben orderby alles.ort select alles.ort).Distinct();
            // var alleOrte = (from alles in dieDaten.ortsangaben select alles.ort).Distinct().OrderBy(platzhalter => platzhalter);
            foreach ( var item in alleOrte )
            {
                WriteLine(item);
            }*/
            warten();
        }
    }
}
