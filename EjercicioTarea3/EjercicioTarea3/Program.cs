using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir;
            try
            {
                do
                {
                    double volt, res;
                    double total;
                    Console.WriteLine("Ingrese el Voltaje");
                    volt = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Resistencia (Ohm)");
                    res = double.Parse(Console.ReadLine());
                    total = volt / res;
                    Console.WriteLine("La corriente es: "+ total +" Ampereos");
                    Console.WriteLine("Desea Continuar (Si, No)");
                    salir = Console.ReadLine();
                } while (salir == "Si");
                Console.WriteLine("Gracias por participar");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo ingrese numeros");
                Console.ReadKey();
                Console.WriteLine("El sistema se cerrara");
                Console.WriteLine("Adios");
                Console.ReadKey();
            }
        }
    }
}
