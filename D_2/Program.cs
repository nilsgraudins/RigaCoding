using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums11();
            //Uzdevums10();
            //Uzdevums9();
            //menesi();
            //vienadi();
            //MD5();
            //valstsUnGalvaspils();
            //Uzdevums10();
            Console.Read();
        }
        static void MD5()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());
            // >=
            // <=
            // <
            // >
            // == --> ir vienads
            // != --> nav vienads
            if (vecums > 18)
            {
                Console.Write("Tu esi pilngadigs!");
            }
            /*var but tikai :if: bloks.
             tikai :else: bloks nevar but
             */
            else if (vecums == 18)
            {
                Console.Write("Tev ir tiesi 18!");
            }
            else
            {
                Console.Write("Tu neesi pilngadins!");
            }

        }
        static void vienadi()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            /*if(sk1==sk2)
            {
                Console.Write("Skaitli ir vienadi!");
            }
            else
            {
                Console.Write("Skaitli nav vienadi!");
            }
                    šo nokomentēto koda gabalu var uzrakstīt vienā rindā
                    bez if un else. Jautājuma zīme nozīmē "tad", ja nosacījums ir patiess.
                    Kols nozīmē "citādi", ja nosacījums nav patiess. Šo var izmantot tikai
                    pie izvades konsolē, rakstot to pašu, kas ir "ifā".

            CONDITION ? TRUE : FALSE
            */
            Console.Write(sk1 == sk2 ? "Skaitli ir vienadi" : "Skaitli nav vienadi");

            /* "ifā" var būt arī vēl papidus nosacījumi 
             piemēram: (sk1==sk2 && sk1==5) Skaitļi ir vienādi un pirmais ir 5.
             && nozīmē "un".
            
            Piemēram: (sk1==sk2 || sk1==5) Skaitli ir vienadi vai ari 1.skaitlis ir 5.
            || nozīmē "vai".
            */
        }
        static void menesi()
        {
            //1.Vaicā ievadīt mēneša nosaukuma pirmos trīs burtus
            Console.Write("Ievadi menesa pirmos tris burtus: ");

            //2.Nolasa ievadīto vērtību
            string men = Console.ReadLine().ToLower();

            //3.Izvada dienu skaitu atkarībā no vērtības

            // 1.variants garais

            /*if(men=="jan")
            {
                Console.Write(31);
            }
            else if(men=="feb")
            {
                Console.Write(28);
            */
            //utt. visiem mēnešiem

            //variants otrais
            /*
            if (men == "apr" || men == "jun" || men == "sep" || men == "nov")
            {
                Console.Write("30 dienas");

            }
            else if(men == "feb")
            {
                Console.Write("28 dienas");
            }
            else
            {
                Console.Write("31 diena");
            }
            */
            //3.variants. Switch izmanto, ja jāpārbauda viena mainīgā vērtība.
            // Ja tiek lietoti saudzi "ifi", tad labāk to darīt ar switch.
            // "Break" apvieno grupas. "Default" var nebūt.

            switch (men)
            {
                case "apr":
                case "jun":
                case "sep":
                case "nov":
                    Console.Write("30 dienas");
                    break;
                case "feb":
                    Console.Write("28 dienas");
                    break;
                default:
                    Console.Write("31 diena");
                    break;

            }
        }
        static void Uzdevums9()
        {
            Console.Write("Ievadi valsts nosaukumu ar lielo burtu: ");
            string val = Console.ReadLine();

            // Viens variants: Console.Write("Valsts " + val + " galvaspilsēta ir ");

            Console.Write("Valsts {0} galvaspilsēta ir ", val);
            // {0} liekas pirmā vērtība, kura ir aiz komata, šeit "val".
            // Var salikt kur vajag {1}, {2}, {3} utt. tie, kas aiz komata secīgi liksies
            //pēc kārtas.

            switch (val)
            {
                case "Igaunija":
                    Console.Write("Tallina");
                    break;
                case "Somija":
                    Console.Write("Heksinki");
                    break;
                case "Ukraina":
                    Console.Write("Kijeva");
                    break;
                case "Zviedrija":
                    Console.Write("Stokholma");
                    break;
                default:
                    Console.Write("nezināma");
                    break;
            }



        }
        static void Uzdevums10()
        {
            Console.Write("Ievadi veicamo darbību: ");
            string dar = Console.ReadLine();
            Console.Write("Ievadi pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            switch (dar)
            {
                case "+":
                    Console.Write(sk1 + sk2);
                    break;
                case "-":
                    Console.Write(sk1 - sk2);
                    break;
                case "*":
                    Console.Write(sk1 * sk2);
                    break;
                case "/":
                    Console.Write(sk1 / (float)sk2);
                    break;
                default:
                    Console.Write("Neatļauta operācija");
                    break;
            }
        }
        static void Uzdevums11()
        {
            //Jāpabeidz!!!!
            // 1. ievada grādus
            Console.Write("Ievadi grādus: ");
            int gradi = int.Parse(Console.ReadLine());
            // 2. ievada grādu mērvienību
            Console.Write("Ievadi grādu mērvienību: "); //C, K, F
            string m1 = Console.ReadLine();
            // 3. ievada jauno mērvienību
            Console.Write("Ievadi jauno mērvienību: "); //C, K, F
            string m2 = Console.ReadLine();

            switch (m1)
            {
                case "C":
                    switch(m2)
                    {
                        case "K":
                            // no C uz K
                            break;
                        case "F":
                            // no C uz F
                            break;

                    }

                    break;
                case "K":
                    switch (m2)
                    {
                        case "C":
                            // no K uz C
                            break;
                        case "F":
                            // no K uz F
                            break;

                    }
                    break;
                case "F":
                    switch (m2)
                    {
                        case "C":
                            // no F uz C
                            break;
                        case "K":
                            // no F uz K
                            break;

                    }
                    break;
            }
        }
    }        
}    
