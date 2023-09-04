using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, adivinanzas;
            float premio, premio_total;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas adivinanzas acertó (max. 5): ");
            adivinanzas = int.Parse(Console.ReadLine());
            premio = 0f;

            if (edad <= 17)
            {
                if (adivinanzas < 3)
                {
                    premio = 50f;
                }
                else
                {
                    premio = 80f;
                }
            }
            else if (edad >= 18)
            {
                if (adivinanzas < 3)
                {
                    premio = 30f;
                }
                else
                {
                    premio = 50f;
                }
            }
            premio_total = premio + (edad * 5) + (adivinanzas * 2);

            Console.WriteLine("Usted ganó el monto de: S/" +  premio_total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
