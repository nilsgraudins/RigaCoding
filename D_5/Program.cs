using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_5
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            //Modinatajs();
            //Iznemot5();
            //DilstosaVirkne();
            //DalisanaAr3();
            Console.Read();
        }
        static void DalisanaAr3()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if (sk % 3 ==0)
            {
                Console.WriteLine("Skaitlis dalās ar 3.");

            }
            else
            {
                Console.WriteLine("Skaitlis nedalās ar 3.");
            }
        }
        static void DilstosaVirkne()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            for (int i = sk; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Iznemot5()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sk; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

        }
        static void Modinatajs()
        {
            Console.Write("Ievadi nedēļas dienu (P,O,T,C,Pk,Se,Sv): ");
            string dien = Console.ReadLine();

            Console.Write("Atvaļinājums (J vai N): ");
            string atv = Console.ReadLine();

            string sept = "7:00";
            string desm = "10:00";
            string off = "off";

            switch (dien)
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "Pk":
                    switch (atv)
                    {
                        case "J":
                            Console.Write("Modinatajs " + desm);// var ar "if", Console.Write
                            break;                              // (atv == "J" ? "Off" : "10:00");
                        case "N":
                            Console.Write("Modinatajs " + sept);
                            break;
                    }
                    break;
                case "Se":
                case "Sv":
                    switch (atv)
                    {
                        case "J":
                            Console.Write("Modinatajs " + off);
                            break;
                        case "N":
                            Console.Write("Modinatajs " + desm);
                            break;
                    }
                    break;
            }
        }
        static void FizzBuzz()
        {
            Console.Write("Ievadi sākuma vērtību: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi beigu vērtību: ");
            int sk2 = int.Parse(Console.ReadLine());

            for (int i = sk1; i <= sk2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            
        }
        static void Dzerieni()
        {
            Console.WriteLine("Pieejamās darbības: ");
            Console.WriteLine("1 - iemaksāt: ");
            Console.WriteLine("2 - pirkt: ");
            Console.WriteLine("3 - saņemt atlikumu: ");
            Console.WriteLine("e - pārtraukt: ");

            DzerienuAutomats dzerienu = new DzerienuAutomats();

            while(true)
            {
                Console.Write("Ievadi darbību: ");
                string darbiba = Console.ReadLine();

                switch(darbiba)
                {
                    case "e":
                        return;
                    case "1":
                        Console.Write("Ievadi summu: ");
                        double summa = double.Parse(Console.ReadLine());

                        dzerienu.Iemaksat(summa);
                        break;
                    case "2":
                        dzerienu.PirktDzerienu

                    
                }

            }
        }
    }
}
