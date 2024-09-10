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

        
        double radio, area;

        Console.WriteLine("\nIntroduzca el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());


        area = CalculosMatematicos.CalculoArea(radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}

internal class CalculosMatematicos
{

    public static int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }


    public static double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2); 
    }
}

