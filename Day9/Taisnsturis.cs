using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Taisnsturis : IGeometriskaFigura
    {
        public double Mala1;

        public double Mala2;

        public Taisnsturis(double mala1, double mala2)
        {
            Mala1 = mala1;

            Mala2 = mala2;
        }

        public double Laukums()
        {
            return "Taisnstūris";
        }

        public double Perimetrs()
        {
            return (Mala1 + Mala2) * 2;
        }
    }
}
