using System;
using System.Collections.Generic;
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

            PLZ dieDaten = new PLZ();
            // WriteLine(dieDaten.ortsangaben[0].id);  // geht nur, wenn ort public gemacht ist

            // Abfragen LINQ an das Objekt richten

            // alle vorhandenen Orte nennen

            /*var alleOrte = (from alles in dieDaten.ortsangaben select alles.ort).Distinct();      // select distinct in SQL
            foreach ( var item in alleOrte )*/
            foreach ( var item in 
                (from alles in dieDaten.ortsangaben select alles.ort).Distinct())  // das selbe wie oben, nur anders geschrieben
            {
                WriteLine(item);
            }
            warten();
        }
    }
}
