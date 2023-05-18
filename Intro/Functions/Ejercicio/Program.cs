using System;

class Program
{
    static void Func1(double totalBill, double tipPercent)
    {
        double tipAmount = totalBill * (tipPercent / 100.0);
        double totalAmount = totalBill + tipAmount;
        Console.WriteLine($"Propina: {tipAmount:C1}");
        Console.WriteLine($"Total: {totalAmount:C1}");
    }
    static void Main(string[] args)
    {
        Console.Write("Entrar el total de compra: ");
        double totalBill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrar el porcentage de propina (ej. 15 para 15%): ");
        double tipPercent = Convert.ToDouble(Console.ReadLine());

        Func1(totalBill, tipPercent);

    }
}
