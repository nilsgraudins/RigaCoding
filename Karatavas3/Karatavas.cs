using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    public class Karatavas
    {
        private string minamaisVards;
        private string[] atminetaisVards;
        private string[] vardnica =
        {
            "KROKODILS",
            "KASTANIS",
            "BIEZPIENMAIZE",
            "VILKS",
            // var vēl
        };

        public Karatavas()
        {


        }
        public void SaktSpeli()
        {
            Random rnd = new Random();
            int pozicija = rnd.Next(vardnica.Length);
            minamaisVards = vardnica[pozicija];

            atminetaisVards = new string[minamaisVards.Length];
            for (int i = 0; i < minamaisVards.Length; i++)
            {
                atminetaisVards[i] = "*";
            }

        }
        public bool IrAtminets()
        {
            foreach(string burts in atminetaisVards)
            {
               if(burts == "*")
               {
                    return false;
               }
            }
            return true;
            // 2.variants
            // return !atminetaisVards.Contains("*");
        }
        public bool Minet(string burts)
        {
            burts = burts.ToUpper();
            if (!minamaisVards.Contains(burts))
            {
                return false;
            }
            
            int pozicija = minamaisVards.IndexOf(burts);
            while(pozicija != -1)
            {
                atminetaisVards[pozicija] = burts;
                pozicija = minamaisVards.IndexOf(burts, 1 + pozicija);
            }
            return true;
        }
        public string Vards()
        {
            string teksts = "";
            foreach(string burts in atminetaisVards) //"var" string vietā pats nosaka                                           
            {                                           // mainīgā tipu
                teksts += burts;
            }
            return teksts;
            // 2.variants
            // return String.Join(" ", atminetaisVards);
        }
    }

}
