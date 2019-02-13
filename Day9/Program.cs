using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Taisnsturis t1 = new Taisnsturis(10.5, 20);
            Aprekini(t1);

            try
            {
                Console.Write("Ievadi apļa radiusu: ");
                double r = double.Parse(Console.ReadLine());

                Aplis a1 = new Aplis(5.7);
                Aprekini(a1);
            }
            catch(FormatException)
            {
                Console.WriteLine("Ievadīta nekorekta vērtība!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Notika neparedzēta kļūda!");
                Console.Write(ex.Message);
            }
            Kvadrats k = new Kvadrats(10.55);
            Aprekini(k);

            Console.ReadLine();
        }
        static void Aprekini(IGeometriskaFigura f)
        {
            //string nosaukums = "";
            //if(f is Taisnsturis)
            //{
            //    nosaukums = "taisnstūra";
            //}
            //else if(f is Aplis)
            //{
            //    nosaukums = "apļa";
            //}

            Console.WriteLine("{1} laukums = {0}", f.Laukums(), nosaukums);
            Console.WriteLine("{1} perimetrs = {0}", f.Perimetrs(), nosaukums);
        }


    }
}
