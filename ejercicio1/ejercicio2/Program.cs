using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de masa producida (en gramos): ");   
            int masaTotal = Convert.ToInt32(Console.ReadLine());

            int budinesTotales = masaTotal / 55;
            int masaSobrante = masaTotal % 55;

            int paquetesTotales = budinesTotales / 12;
            int budinesSobrantes = budinesTotales % 12;

            int cajasCompletas = paquetesTotales / 20;
            int paquetesSobrantes = paquetesTotales % 20;   

            Console.WriteLine($"Cantidad de budines producidos: {budinesTotales}"); 
            Console.WriteLine($"Masa sobrante: {masaSobrante} gramos");
            Console.WriteLine($"Cantidad total de paquetes {paquetesTotales}");
            Console.WriteLine($"Budines sobrantes: {budinesSobrantes}");
            Console.WriteLine($"Cantidad de cajas completas: {cajasCompletas}");
            Console.WriteLine($"Paquetes sobrantes: {paquetesSobrantes}");

            Console.ReadKey();

        }
    }
}