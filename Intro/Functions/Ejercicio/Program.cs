using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrar el total de compra: ");
        double totalBill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrar el porcentage de propina (ej. 15 para 15%): ");
        double tipPercent = Convert.ToDouble(Console.ReadLine());

        double tipAmount = totalBill * (tipPercent / 100.0);
        double totalAmount = totalBill + tipAmount;

        Console.WriteLine($"Propina: {tipAmount:C}");
        Console.WriteLine($"Total: {totalAmount:C}");
    }
}
