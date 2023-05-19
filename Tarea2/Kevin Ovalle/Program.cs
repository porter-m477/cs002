using System;

class ComisionCalculator
{
    static void Main()
    {

        Console.WriteLine("nombre de vendedor: ");
        string nombre = Convert.ToString(Console.ReadLine());

        Console.WriteLine("total de venta: ");
        double totalVenta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("porcentaje de comision: ");
        int totalPorcentaje = Convert.ToInt32(Console.ReadLine());

        double totalComision = totalVenta * totalPorcentaje / 100;

        Console.WriteLine("total de comision es: Q" + totalComision.ToString("0.00"));


    }

}