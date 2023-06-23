using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNueva
{
    public class Multiplicacion
    {
        public Multiplicacion()
        {

        }
        public int Multiplicar(int numero1, int numero2)
        {

            try
            {
                int resultado = 0;
                resultado = numero1 * numero2;

                return resultado;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
