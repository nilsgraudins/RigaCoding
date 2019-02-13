using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManiUzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {

            Cetrasrindas();
            //Vecums20();
            //Xyz();
            //Videjs();
            //ReizTab();
            //SasAtnReizDal();
            //ReizinaTrisSkaitlus();
            //MainaSkaitlus();
            //SpecOper();
            //Divide();
            //TwoNumbers();
            //HelloName();
            Console.ReadLine();

        }
        static void HelloName()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Nils Graudiņš");
        }
        static void TwoNumbers()
        {
            Console.WriteLine(3 + 4);
        }
        static void Divide()
        {
            Console.WriteLine(12 / 2);
        }
        static void SpecOper()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine(16 % 7);

        }
        static void MainaSkaitlus()
        {
            int sk1, sk2, tukss;

            Console.Write("Ievadi pirmo skaitli: ");
            sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            sk2 = int.Parse(Console.ReadLine());

            tukss = sk1;
            sk1 = sk2;
            sk2 = tukss;
            Console.WriteLine("\nPēc maiņas 1. skaitlis ir {0}, 2.skaitlis ir {1}", sk1, sk2);

        }
        static void ReizinaTrisSkaitlus()
        {
            int sk1, sk2, sk3;

            Console.Write("Ievadi pirmo skaitli: ");
            sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi trešo skaitli: ");
            sk3 = int.Parse(Console.ReadLine());

            int result = sk1 * sk2 * sk3;
            Console.WriteLine("Skatļu reizinājums ir: {0}", result);
        }
        static void SasAtnReizDal()
        {
            int sk1, sk2;

            Console.Write("Ievadi pirmo skaitli: ");
            sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            sk2 = int.Parse(Console.ReadLine());

            int summa = sk1 + sk2;
            int starpiba = sk1 - sk2;
            int reizinajums = sk1 * sk2;
            float dalijums = sk1 / (float)sk2;

            Console.WriteLine(sk1 + " + " + sk2 + " = " + summa);
            Console.WriteLine(sk1 + " - " + sk2 + " = " + starpiba);
            Console.WriteLine(sk1 + " * " + sk2 + " = " + reizinajums);
            Console.WriteLine(sk1 + " / " + sk2 + " = " + dalijums);
        }
        static void ReizTab()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * 0 = {1}", sk, sk * 0);
            Console.WriteLine("{0} * 1 = {1}", sk, sk * 1);
            Console.WriteLine("{0} * 2 = {1}", sk, sk * 2);
            Console.WriteLine("{0} * 3 = {1}", sk, sk * 3);
            Console.WriteLine("{0} * 4 = {1}", sk, sk * 4);
            Console.WriteLine("{0} * 5 = {1}", sk, sk * 5);
            Console.WriteLine("{0} * 6 = {1}", sk, sk * 6);
            Console.WriteLine("{0} * 7 = {1}", sk, sk * 7);
            Console.WriteLine("{0} * 8 = {1}", sk, sk * 8);
            Console.WriteLine("{0} * 9 = {1}", sk, sk * 9);
            Console.WriteLine("{0} * 10 = {1}", sk, sk * 10);
        }
        static void Videjs()
        {
            int sk1, sk2, sk3, sk4;

            Console.Write("Ievadi pirmo skaitli: ");
            sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi trešo skaitli: ");
            sk3 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi ceturto skaitli: ");
            sk4 = int.Parse(Console.ReadLine());

            float vid = (sk1 + sk2 + sk3 + sk4) / 4f;

            Console.Write("Vidējā vērtība no {0}, {1}, {2}, {3} ir {4}", sk1, sk2, sk3, sk4, vid);
        }
        static void Xyz()
        {
            int x, y, z;

            Console.Write("Ievadi pirmo skaitli x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Ievadi trešo skaitli z: ");
            z = int.Parse(Console.ReadLine());

            int sum1 = (x + y) * z;
            int sum2 = x * y + y * z;

            Console.WriteLine("Skaitļu {0}, {1} un {2} rezultāts ir: (x+y)*z = {3}, x*y+y*z = {4}"
                , x, y, z, sum1, sum2);

        }
        static void Vecums20()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vec = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu izskaties vecāks par " + vec);
        }
        static void Cetrasrindas()
        {
            Console.Write("Ievadi skaitli: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}{0}", a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);

        }
    }
}
