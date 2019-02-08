using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {

            skaitlis5();
            //Preteji();
            //MasivsOtradi();
            //MasivsIr();
            //Piemers();
            Console.ReadLine();
            
        }
        static void Piemers()
        {
            

            int[] skaitli = new int[5]; // masivs at 5 elementiem - int
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // izmetis kludu - Index Out of Range
            //skaitli[5] = 6;

            int skaitlis = skaitli[3];// 4

            //for (int i = 0; i < skaitli.length; i++)
            //{
            //    int vertiba = skaitli[i];
            //    console.writeline(vertiba);
            //}
            //foreach (...in masivs)

            foreach (int vertiba in skaitli)
            {

                Console.WriteLine(vertiba);
            }

        }
        static void MasivsIr()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            //int[] masivs = new int[6];
            //masivs[0] = 0;
            //masivs[1] = 10;
            //masivs[2] = 20;
            //masivs[3] = 30;
            //masivs[4] = 40;
            //masivs[5] = 50;

            // vai ari aizpilda uzreiz
            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            bool irAtrasts = false;
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == sk)
                {
                    Console.WriteLine("Skaitlis ir atrasts pozicija {0}", i);
                    irAtrasts = true;
                    break;
                }
            }
            // if(irAtrasts == false)
            if(!irAtrasts)
            {
               Console.WriteLine("Skaitlis nav atrasts!");

            }
            //irAtrasts = masivs.Contains(sk); 
        }
        static void MasivsOtradi()
        {
            int[] masivs = new int[5];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = int.Parse(Console.ReadLine());
            }
            // izvade
            for (int a = masivs.Length - 1; a >= 0; a--)
            {
                Console.WriteLine(masivs[a]);
            }

        }
        static void Preteji()
        {
            List<int> saraksts = new List<int>();

            //for(int i = 1; i <= 5; i++)
            // jeb
            while(true)
            {
                Console.Write("Ievadi skaitli (vai nulli, lai pārtrauktu): ");

                int skaitlis = int.Parse(Console.ReadLine());

                if(skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis); //(int.Parse(Console.ReadLine()));
            }

            //int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(String.Join(", ", saraksts));
        }
        static void skaitlis5()
        {
            // skaitļu ievade

            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli (vai 0, lai pārtrauktu): ");

                int skaitlis = int.Parse(Console.ReadLine());

                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            // skaitīšana
            int skaits = 0;
            foreach(int skaitlis in saraksts)
            {
                if(skaitlis == 5)
                {
                    skaits++;
                }
            }
            Console.WriteLine("Skaitlis ir 5 atrasts {0} reizes", skaits);

            // 2. variants
            skaits = saraksts.Count(sk => sk == 5);
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);
        }
   
    }
}
