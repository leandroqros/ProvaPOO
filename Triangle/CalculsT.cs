using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//punto 3
namespace Triangle
{
    public class CalculsT : Calculs
    {
        //punto 4
        public double Volum(double dim1, double dim2)
        {
            double result = ((dim1 * dim1) * dim2) / 3;
            return result;
        }
        //punto 5
        public override double Area(int dim1, int dim2)
        {
            double result = (dim1 * dim2) / 2;
            return result;
        }
        //punto 6
        public double AreaOriginal(int dim1, int dim2)
        {
            //punto 7
            return Area(dim1, dim2);
        }
    }
}
