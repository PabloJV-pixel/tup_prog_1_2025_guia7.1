using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto total a repartir: ");
            double montoTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la niña 1: ");
            int edad1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la niña 2: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Ingrese la edad de la niña 3: ");
            int edad3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la niña 4: ");
            int edad4 = Convert.ToInt32(Console.ReadLine());

            int sumaEdades = edad1 + edad2 + edad3 + edad4;

            double porc1= (double)edad1 / sumaEdades;
            double porc2 = (double)edad2 / sumaEdades;
            double porc3 = (double)edad3 / sumaEdades;
            double porc4 = (double)edad4 / sumaEdades;

            double monto1 = montoTotal * porc1; 
            double monto2 = montoTotal * porc2;
            double monto3 = montoTotal * porc3;
            double monto4 = montoTotal * porc4;

            Console.WriteLine($"Niña 1: {porc1:P2} del total, recibe {monto1:C2}");
            Console.WriteLine($"Niña 2: {porc2:P2} del total, recibe {monto2:C2}");
            Console.WriteLine($"Niña 3: {porc3:P2} del total, recibe {monto3:C2}");
            Console.WriteLine($"Niña 4: {porc4:P2} del total, recibe {monto4:C2}");

            Console.ReadKey(); 
        }
    }
}
