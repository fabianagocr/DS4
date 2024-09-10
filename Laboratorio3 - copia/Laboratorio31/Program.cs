using System;
internal class Program
{

    private static void Main(string[] args)
    {
        int a, b, resultado;

        Console.WriteLine("Introduzca el valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());

        resultado = CalculosMatematicos.Calcular(a, b);

        Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: {0}", resultado);

    }

    internal class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}
