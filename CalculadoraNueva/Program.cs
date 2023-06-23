using Calculator;
using System;
using System.Security.Cryptography;

namespace CalculadoraNueva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacion = 0;
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;

            Console.WriteLine("¡Hola Amigos esta es una nueva calculadora!");
            Console.WriteLine("Debes elegir que tipo de operacion quieres realizar!");
            Console.WriteLine("1 = Suma | 2 = Resta");

            operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Elegiste sumar jeje");
                    Console.WriteLine("Escribe los numeros que quieres sumar por favor");
                    Console.WriteLine("Numero 1:");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero 2:");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Suma suma = new Suma();
                    resultado = suma.Sumar(numero1, numero2);

                    Console.WriteLine("El resultado de su operacion es: " + resultado);

                    break;
                case 2:
                    Console.WriteLine("Elegiste restar");
                    Console.WriteLine("Escribe los numeros que quieres restar");
                    Console.WriteLine("Numero 1:");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero 2:");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Resta restarnegro = new Resta();
                    resultado = restarnegro.Restar(numero1, numero2);

                    Console.WriteLine("El resultado de su operacion es: " + resultado);

                    break;
            }
        }
    }
}
