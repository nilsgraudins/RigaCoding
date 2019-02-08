using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            Uzdevums22();
            Console.ReadLine();
        }


        static void Uzdevums23()
        {
            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Vards = "Aigars";
            darbinieks.Uzvards = "Liepa";
            darbinieks.Dzivesvieta = new Adrese();
            darbinieks.Dzivesvieta.Pilseta = "Riga";
            darbinieks.Dzivesvieta.Iela = "Republikas laukums";
            darbinieks.Darbavieta = new Adrese
            {
                Valsts = "Latvija",
                Pilseta = "Riga",
                Iela = "Brivibas iela"
            };

            darbinieks.Info();

        }
        static void Uzdevums22()
        {
            Aplis a = new Aplis();
            a.Radiuss = 5;
            a.Krasa = "sarkans";

            a.Laukums();
            a.Perimetrs();
            a.KrasasIzvade();


        }
        static void Piemers()
        {
            Kvadrats kv1 = new Kvadrats(5);
            

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums = {0}", laukums);
            Console.WriteLine("Perimetrs = {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);
            kv2.KonsolesIzvade();

            Kvadrats.FigurasNosaukums();
            
        }
    }
}
