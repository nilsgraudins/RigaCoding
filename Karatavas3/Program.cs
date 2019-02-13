using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas k = new Karatavas();
            while (true)
            {
                k.SaktSpeli();
                Console.WriteLine(k.Vards());

                while (!k.IrAtminets())
                {
                    Console.Write("Ievadi burtu: ");
                    string burts = Console.ReadLine();

                    if (k.Minet(burts))
                    {
                        Console.WriteLine(k.Vards());
                    }
                    else
                    {
                        Console.WriteLine("Burts nav šajā vārdā!");
                    }
                }
                Console.WriteLine("Vārds ir atminēts, tu uzvarēji!");
                Console.Write("Vai spēlēsi vēl? J vai N ");
                string atbilde = Console.ReadLine().ToUpper();
                if(atbilde == "N")
                {
                    break;
                }

            }
            Console.ReadLine();

        }   
    }
}
