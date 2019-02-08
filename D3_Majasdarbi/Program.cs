using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Majasdarbi
{
    class Program
    {
        static void Main(string[] args)
        {
            Minesana();
            //Skaitlis13();
            //Intervals();
            //SkaitluSumma();
            //Vecums();
            //ParaSkaitlis();
            //MazUnLiel();
            Console.Read();

        }
        static void Vecums()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vec = int.Parse(Console.ReadLine());
            if (vec < 50)
            {
                Console.WriteLine("Tev vēl nav 50 gadu.");

            }
            else if (vec == 50)
            {
                Console.WriteLine("Tev ir tieši 50 gadu!");
            }
            else
            {
                Console.WriteLine("Tev ir vairāk par 50 gadiem!");
            }
        }
        static void Intervals()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if (sk >= -50 && sk <= 50)
            {
                Console.WriteLine("Skaitlis ir starp -50 un 50.");
            }
            else
            {
                Console.WriteLine("Skaitlis nav intervālā starp -50 un 50.");
            }
        }
        static void ParaSkaitlis()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if (sk % 2 == 0)
            {
                Console.WriteLine("Tas ir pāra skaitlis.");
            }
            else
            {
                Console.WriteLine("Tas nav pāra skaitlis.");
            }
        }
        static void MazUnLiel()
        {
            Console.Write("Ievadi 1.skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 2.skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 3.skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("Lielākais ir skatlis {0}", sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine("Lielākais ir skatlis {0}", sk2);
            }
            else
            {
                Console.WriteLine("Lielākais ir skatlis {0}", sk3);
            }

            if (sk1 < sk2 && sk1 < sk3)
            {
                Console.WriteLine("Mazākais ir skatlis {0}", sk1);
            }
            else if (sk2 < sk1 && sk2 < sk3)
            {
                Console.WriteLine("Mazākais ir skatlis {0}", sk2);
            }
            else
            {
                Console.WriteLine("Mazākais ir skatlis {0}", sk3);
            }
        }
        static void SkaitluSumma()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            int summa = 0;
            while (sk > 0)
            {
                summa += sk % 10;
                sk /= 10;
            }
            
            Console.WriteLine("Ciparu summa ir {0}", summa);
            
        }
        static void Skaitlis13()
        {
            
            int summa = 0;
            // Ja zin uzreiz intervālu, tad izmanto "for" ciklu,ja ir nosacījums, pie kura jāpārtrauc,
            // tad "while".
            while (true) // vai arī "for ( ; ; )" ,abi atver bezgalīgu ciklu.
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis = int.Parse(Console.ReadLine());
                if (skaitlis == 13)
                {
                    break;
                }
                summa += skaitlis;
            }
            Console.WriteLine("Ievadīto skaitļu summa ir {0}", summa);
        }
        static void Minesana()
        {
            int skaitlis = 12;
            Console.WriteLine("Jāuzmin skaitlis no 1 līdz 20.");
            while(true)
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis2 = int.Parse(Console.ReadLine());
                if (skaitlis2 < skaitlis)
                {
                    Console.WriteLine("Ievadītais skaitlis ir par mazu!");
                }
                else if (skaitlis2 > skaitlis)
                {
                    Console.WriteLine("Ievadītais skaitlis ir par lielu!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Skaitlis ir atminēts!");

        }
    }
}
