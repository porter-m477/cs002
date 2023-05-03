using System;

class ConvertidorMoneda
{
    static void Main()
    {
        Console.WriteLine ("--- Convertir de dolar a quetzales ---");
        Console.WriteLine ("--------------------------------------");
        Console.WriteLine ("Ingresa el tipo de cambio de 1$ en Q: ");
        double tipoCambio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Ingresa el monto a convertir : $");
        double dolares = Convert.ToDouble(Console.ReadLine());
        double total = dolares * tipoCambio;
        Console.WriteLine ("--------------------------------------");
        Console.WriteLine ("El monto $" + dolares.ToString("0.00") + " equivale a Q" + total.ToString("0.00"));
        Console.ReadLine();
    }
}
