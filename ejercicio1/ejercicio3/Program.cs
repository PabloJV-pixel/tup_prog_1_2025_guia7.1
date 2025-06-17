using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de patente: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int parteNumerica = numero % 1000;

            int letrasValor = numero / 1000;
            int letra1 = (letrasValor / (26 * 26)) % 26;
            int letra2 = (letrasValor / 26) % 26;
            int letra3 = letrasValor % 26;

            char b1 = (char)('A' + letra1); 
            char b2 = (char)('A' + letra2);
            char b3 = (char)('A' + letra3);

            string patente = $"{b1}{b2}{b3}-{parteNumerica:D3}";   
            Console.WriteLine(patente);

            Console.WriteLine();
        }
    }
}
