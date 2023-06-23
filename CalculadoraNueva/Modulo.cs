using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNueva
{
    public class Modulo
    {
        public Modulo()
        {

        }
        public double Modular(int numero1, int numero2)
        {

            try
            {
                double resultado = 0;
                resultado = numero1 % numero2;

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
