using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Suma
    {
        public Suma() { }

        public int Sumar(int numero1, int numero2) 
        {
            try 
            {
                int resultado = 0;

                resultado = numero1 + numero2;

                return resultado;
            }
            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }
    }
}
