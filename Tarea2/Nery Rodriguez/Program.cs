using System;


class Program {

  static void Main(string[] args) {

    Console.Write("Ingrese monto a calcular retención: ");

    double amount = double.Parse(Console.ReadLine());

    

    double withholding = 0;

    

    if (amount <= 2500) {

      Console.WriteLine("No aplica retención.");

    }

    else if (amount > 2500 && amount < 30000) {

      withholding = amount * 0.05;

      Console.WriteLine("Retención : " + withholding.ToString("C"));

    }

    else {

      double firstPortion = 30000 * 0.05;

      double secondPortion = (amount - 30000) * 0.07;

      withholding = firstPortion + secondPortion;

      Console.WriteLine("Retención: " + withholding.ToString("C"));

    }

  }

}