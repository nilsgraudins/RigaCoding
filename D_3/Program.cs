using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums20();
            //Skaitlino1dz30();
            //Uzdevums19();
            //Uzdevums18();
            //Uzdevums16();
            //ParaSkaitli();
            //DzimsanasGads();
            //Skaitli1lidz100();
            CikluPiemers();

            Console.ReadLine();

        }
        static void CikluPiemers()
        {
            Console.Write("Ievadi skaitlli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i <= 10; i++)
            {
                //pariet pie nakama cikla
                /*if (i == 5)
                {
                    continue;
                }
                */
                Console.Write(i + ", ");

                //Lai partrauktu cikla apstradi
                //if (i == 5)
                //{
                //  break;
                //}

            }
            Console.Write("Cikla beigas");


        }
        static void Skaitli1lidz100()
        {
            int summa = 0;

            for (int i = 1; i <= 100; i++)
            {

                Console.WriteLine(i);
                summa = summa + i;
                // summa +=i;
            }

            //jaizvada summa
            Console.Write("Summa = {0}", summa);
        }
        static void Skaitlino1dz30()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i=skaitlis; i<=30; i++)
            {
                Console.WriteLine(i);
                summa += i;
            }
            Console.Write("Summa ir: " + summa);
        }
        static void DzimsanasGads()
        {
            Console.Write("Ievadi savu dzimsanas gadu: ");


            //var arī uzreiz "for" ciklā rakstīt to "int", kas ir mainīgais
            //ciklā. Šajā gadījumā "gads"

            /*int gads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            for (; gads <= robeza; gads++)
            */


            //vēl viens variants
            /*while(gads <=robeza)
             {
                Console.WriteLine(gads);
                gads = gads + 1;
                */ 


            /*int dzgads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;


            for (int gads = dzgads; gads <= robeza; gads++)
            {
                Console.WriteLine(gads);
   
            }
            */
        }
        static void ParaSkaitli()
        {
            Console.Write("Ievadi skaitli: ");

            int n = int.Parse(Console.ReadLine());
            int summa = 0;


            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                  summa += i;
                }
                
                  
                
            }

            Console.Write("Summa = {0}", summa);
        }
        static void Uzdevums16()
        {
            Console.Write("Ievadi skaitu N: ");
            int skaits = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i=1; i<=skaits;i++)
            {
                Console.Write("Ievadi {0}. skaitli: ", i);

                //int sk = int.Parse(Console.ReadLine());
                //summa += sk;
                //vienā rindā
                summa += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summa = {0}", summa);
            Console.WriteLine("Videja vērtība = {0}", summa / (float)skaits);




        }
        static void Uzdevums18()
        {
            Console.Write("Ievadi skaitu N: ");
            int N = int.Parse(Console.ReadLine());

            for (int j = 1; j <= N; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
        }
        static void Uzdevums19()
        {
            Console.Write("Ievadi skaitu N: ");
            int N = int.Parse(Console.ReadLine());

            for (int a = 1; a <= N; a++)
            {
                for (int i = 1; i <= a; i++)
                {
                    
                    Console.Write(i);
                }
                
                Console.WriteLine();
            }
            
            for (int a = N - 1; a >= 1; a--)
            {
                for (int i = 1; i <= a; i++)
                {

                    Console.Write(i);
                }
                Console.WriteLine();
            }
            

        }
        static void Uzdevums20()
        {
            
            Console.Write("Ievadi rindu skaitu: ");
            int rinduskaits = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rinduskaits; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
