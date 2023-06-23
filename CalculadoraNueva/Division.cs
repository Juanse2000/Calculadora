using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNueva
{
    public class Division
    {
        public Division()
        {

        }
        public double Divisiones(double numero1, double numero2)
        {

            try
            {
                double resultado = 0;
                resultado = numero1 / numero2;

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
