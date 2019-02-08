using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Majasdarbi
{
    class Program
    {
        static void Main(string[] args)
        {
            trijsturis();
            //vardiRinda();
            //skaitlisA();
            //uzCaps();

            Console.Read();
        }

        static void trijsturis()
        {
            Console.WriteLine("  *");
            Console.WriteLine(" ***");
            Console.WriteLine("*****");
        }

        static void vardiRinda()
        {
            Console.Write("Ievadi pirmo vardu: ");
            string v1 = Console.ReadLine();
            Console.Write("Ievadi otro vardu: ");
            string v2 = Console.ReadLine();
            Console.Write("Ievadi treso vardu: ");
            string v3 = Console.ReadLine();

            Console.WriteLine("Vardi ir: " + v1 + ", " + v2 + ", " + v3);

        }
        static void skaitlisA()
        {
            Console.Write("Ievadi skaitla a vertibu: ");
            int a = int.Parse(Console.ReadLine());

            // a + 5 --> int sk1 = a + 5;
            // a += 5 --> a = a + 5
            //a=a+5
            Console.WriteLine(a + 5);

            //a+=5; a=a+5
            Console.WriteLine(a + 5);

            //a-=3; a=a-3
            Console.WriteLine(a - 3);

            //a*=2; a=a*2
            Console.WriteLine(a * 2);

            //a=a+1
            Console.WriteLine(a + 1);

            //a+=1; a=a+1
            Console.WriteLine(a + 1);

            // a = a + 1 --> a += 1 --> a++ --> ++a

            //a++; palielina par viens, bet nerada jauno skaitli. Tas paradas nakosaja darbiba.
            Console.WriteLine(a++);
            //Console.WriteLine(a); bus par vienu vairak
        }
        static void uzCaps()
        {
            Console.Write("Ievadi vardu: ");
            string va = Console.ReadLine().ToUpper();
            //vai
            //va = va.ToUpper();

            string lielieBurti = "asdfgj".ToUpper();

            //bus lielie burti

            Console.WriteLine(va);

            /* var visu viena rinda,
               gan ievadi, gan uz Upper
            */
            

        }
    }
}
