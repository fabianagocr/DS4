using System;

namespace Laboratorio51
{
    class Program
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[6];
            for (int f = 0; f < 6; f++)  
            {
                Console.Write("Ingrese el sueldo del operador " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);  
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los sueldos de los operadores son: ");
            for (int f = 0; f < 6; f++)  
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program pv = new Program();  
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
