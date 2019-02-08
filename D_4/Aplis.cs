using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_4
{
    class Aplis
    {
        /// <summary>
        /// Apļa rādiuss
        /// </summary>
        public int Radiuss;
        /// <summary>
        /// Apļa krāsa
        /// </summary>
        public string Krasa;

        public void Perimetrs()
        {
            Console.WriteLine("Apļa perimetrs = {0}", 2 * Math.PI * Radiuss);
        }
        public void Laukums()
        {
            Console.WriteLine("Apļa laukums = {0}", Math.PI * Radiuss * Radiuss);
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa = {0}", Krasa);
        }
    }
}
