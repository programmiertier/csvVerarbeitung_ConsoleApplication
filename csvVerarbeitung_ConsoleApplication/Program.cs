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
            string[] csvZeilen = File.ReadAllLines("plz.csv");
            var query = from csvZeile in csvZeilen
                        let ortsdaten = csvZeile.Split(',')
                        select new
                        {
                            id = ortsdaten[0],
                            plz = ortsdaten[1],
                            ort = ortsdaten[2],
                            kreisnr = ortsdaten[3],
                            kreisname = ortsdaten[4],
                            landnr = ortsdaten[5],
                            bundesland = ortsdaten[6]
                        };
            foreach ( var item in query )
            {
                WriteLine("Postleitzahlen mit Orten: {0} \t{1}", item.plz, item.ort);
            }
            warten();
        }
    }
}
