using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Piemeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            tekstaIzvade();
            //tekstaIzvadeArParametru("teksts no funkcijas parametra");
            //tekstaIevade();
            //vecumaIevade();

            Console.Read();

            // komentars

            /*
             vairakas rindas
             */
        }

        static void tekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadits teksts");
        }

        static void tekstaIzvadeArParametru(string teksts)
        {
            Console.WriteLine("Izvade: " + teksts);
        }
         
        static void tekstaIevade()
        {
            //izvada
            Console.Write("Ievadi savu vardu: ");
            string vards = Console.ReadLine();
            //izvada
            Console.Write("Ievadi savu uzvardu: ");
            
            
            string uzvards = Console.ReadLine();

            Console.Write("Tevi sauc \n" + vards + " " + uzvards);
        }
        static void vecumaIevade()
        {
            Console.Write("Ievadi savu vecumu: ");
            //string vecums = console.readline();
            //int skaitlis = Convert.ToInt32(vecums);
            //vai
            int skaitlis = int.Parse(Console.ReadLine()) +1;
            //skaitlis = skaitlis + 1;
            //vai
            //skaitlis += 1;

            Console.Write("Pec gada tev bus " + skaitlis);

        }

    }


}
