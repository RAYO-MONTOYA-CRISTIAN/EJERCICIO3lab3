using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad del ganador:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas");
            int adivinanzasAcertadas = int.Parse(Console.ReadLine());
            double montoInicial = 0.0;

            if (edad >= 18)
            {
                if (adivinanzasAcertadas < 3)
                    montoInicial = 30.00;
                else
                    montoInicial = 50.00;
            }
            else
            {
                if (adivinanzasAcertadas < 3)
                    montoInicial = 50.00;
                else
                    montoInicial = 80.00;
            }
            double montoExtra = (edad * 5.00) + (adivinanzasAcertadas * 2.00);
            double montoFinal = montoInicial + montoExtra;

            Console.WriteLine($"El monto final queel ganador recibe como premio es:S/{montoFinal}");
            Console.ReadLine();

        }
    }
}
