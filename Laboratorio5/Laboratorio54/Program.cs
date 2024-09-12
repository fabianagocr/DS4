﻿using System;

namespace Laboratorio54
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };

            int suma = 0;

            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }

            double promedio = suma / (double)calificaciones.Count;
            Console.WriteLine($"El promedio de las calificaiones es: {promedio}");
        }
    }
}
