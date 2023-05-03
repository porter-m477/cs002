using System;

class TipCalculator
{
    static void Main()
    {
        // Prompt user for the total bill
        Console.Write("Entra el total de tun cuenta: $");
        double totalBill = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the tip percentage
        Console.Write("Entra la propina como porcentaje: ");
        int tipPercentage = Convert.ToInt32(Console.ReadLine());

        // Calculate the tip amount
        double tipAmount = totalBill * tipPercentage / 100;

        // Calculate the total amount
        double totalAmount = totalBill + tipAmount;

        // Display the tip amount and total amount
        Console.WriteLine("Propina: $" + tipAmount.ToString("0.00"));
        Console.WriteLine("Grand Total: $" + totalAmount.ToString("0.00"));
    }
}
