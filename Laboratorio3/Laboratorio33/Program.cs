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
        Console.WriteLine("El resultado de la operacion (a+b)*(a-b) es: {0}", resultado);

        double radio, area;

        Console.WriteLine("\nIntroduzca el radio del circulo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        area = CalculosMatematicos.CalculoArea(radio);
        Console.WriteLine("El area del circulo con radio {0} es: {1}", radio, area);

        double lado1, lado2, perimetro;

        Console.WriteLine("Introduzca la longitud del primer lado del rectangulo: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduzca la longitud del segundo lado del rectangulo: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        perimetro = CalculosMatematicos.CalculoPerimetroRectangulo(lado1, lado2);
        Console.WriteLine("El perimetro del rectangulo es: {0}", perimetro);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
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

    public static double CalculoPerimetroRectangulo(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}