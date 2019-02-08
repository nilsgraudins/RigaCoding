using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {

            //skaitluSumma();
            //gradi();
            
            //videjaVertiba();
            skaitluReiz();
            Console.ReadLine(); //lai konsole paliek atverta
        }

        static void skaitluSumma()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skaitlu summa ir " + (skaitlis1 + skaitlis2));
            //Console.WriteLine("Skaitlu starpiba ir " + (skaitlis1 - skaitlis2));
            //Console.WriteLine("Skaitlu reizinajuma ir " + (skaitlis1 * skaitlis2));
            //Console.Write("Skaitlu dalijuma ir " + (skaitlis1 / skaitlis2));

            //vai

            int summa = skaitlis1 + skaitlis2;
            int starpiba = skaitlis1 - skaitlis2;
            int reizinajums = skaitlis1 * skaitlis2;
            float dalijums = skaitlis1 / (float)skaitlis2; //vai skaitlis2f


            Console.WriteLine("Skaitlu summa ir " + summa);
            Console.WriteLine("Skaitlu starpiba ir " + starpiba);
            Console.WriteLine("Skaitlu reizinajuma ir " + reizinajums);
            Console.Write("Skaitlu dalijuma ir " + dalijums);
        }
        static void gradi()
        {
            Console.Write("Ievadi gradus: ");
            int gr1 = int.Parse(Console.ReadLine());
            float kel = gr1 + (float)273.15;
            float far = gr1 * 1.8f + 32;
            Console.WriteLine("Temperatura Kelvinos ir " + kel);
            Console.WriteLine("Temperatura Farenheits ir " + far);

        }
        static void videjaVertiba()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi treso skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi ceturto skaitli: ");
            int sk4 = int.Parse(Console.ReadLine());
            float vid = (sk1 + sk2 + sk3 + sk4) / 4f;
            Console.WriteLine("Videja vertiba ir " + vid);
            

        }
        static void skaitluReiz()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi treso skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());

            Console.Write("Skaitlu reizinajums ir: " + sk1 * sk2 * sk3);
        }

    }
}
