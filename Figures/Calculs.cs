using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    //punto 1
    /// <summary>
    /// Clase abtract que fue heredada por el proyecto Triangle
    /// </summary>
    public abstract class Calculs
    {
        /// <summary>
        /// Funcion sobreescrita para el futuro donde te calcula la area de algo y te devuelve un valor double
        /// </summary>
        /// <param name="dim1">Un parametro entero</param>
        /// <param name="dim2">Dos parametro entero</param>
        /// <returns></returns>
        public virtual double Area(int dim1, int dim2)
        {
            double result = dim1 * dim2;
            return result;
        }
        //punto 2
        /// <summary>
        /// Funcion que te calcula la area de un circulo con una unica variable
        /// </summary>
        /// <param name="dim1">Variable que se multiplicará por PI</param>
        /// <returns></returns>
        public double Area(int dim1)
        {
            double PI = 3.14;
            double result = PI * dim1;
            return result;
        }
        //
        /// <summary>
        /// Funcion que te calcula el volumen de algo
        /// </summary>
        /// <param name="dim1">Un parametro entero</param>
        /// <param name="dim2">Dos parametro entero</param>
        /// <param name="dim3">Tres parametro entero</param>
        /// <returns></returns>
        public double Volum(int dim1, int dim2, int dim3)
        {
            double result = dim1 * dim2 * dim3;
            return result;
        }
    }

}