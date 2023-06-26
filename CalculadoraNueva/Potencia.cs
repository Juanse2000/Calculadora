using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNueva
{
    public class Potencia
    {
        public Potencia()
        {

        }
        public double Potenciar(double numero1, double numero2)
        {

            try
            {
                double resultado = 0;
                resultado = Math.Pow(numero1, numero2);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
