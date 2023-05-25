    using System;   

    namespace CuentasDeBanco
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creación de instancias de cuentas
                CuentaAhorro cuentaAhorro1 = new CuentaAhorro("Darlin", 250);
                CuentaMonetaria cuentaMonetaria1 = new CuentaMonetaria("Axel", 2000, 1000);

                // Acceso a propiedades y métodos de las cuentas de ahorro
                Console.WriteLine("Cuenta de Ahorro 1:");
                Console.WriteLine("Titular: " + cuentaAhorro1.Titular);
                Console.WriteLine("Saldo: " + cuentaAhorro1.Saldo);
                cuentaAhorro1.Depositar(100);
                cuentaAhorro1.Retirar(200);
                Console.WriteLine("Saldo después de operaciones: " + cuentaAhorro1.Saldo);

                Console.WriteLine();

                // Acceso a propiedades y métodos de las cuentas monetarias
                Console.WriteLine("Cuenta Monetaria 1:");
                Console.WriteLine("Titular: " + cuentaMonetaria1.Titular);
                Console.WriteLine("Saldo: " + cuentaMonetaria1.Saldo);
                Console.WriteLine("Límite de sobregiro: " + cuentaMonetaria1.LimiteSobregiro);
                cuentaMonetaria1.Depositar(3000); 
                cuentaMonetaria1.Retirar(6000);
                Console.WriteLine("Saldo después de operaciones: " + cuentaMonetaria1.Saldo);

                Console.WriteLine();
               
            }
        }

       class CuentaAhorro
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public CuentaAhorro(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal cantidad)
    {
        Saldo += cantidad;
        Console.WriteLine("Se ha depositado " + cantidad + " en la cuenta de ahorro.");
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine("Se ha retirado " + cantidad + " de la cuenta de ahorro.");
        }
        else
        {
            Console.WriteLine("No se puede retirar. Fondos insuficientes.");
        }
    }
}

class CuentaMonetaria
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }
    public decimal LimiteSobregiro { get; }

    public CuentaMonetaria(string titular, decimal saldoInicial, decimal limiteSobregiro)
    {
        Titular = titular;
        Saldo = saldoInicial;
        LimiteSobregiro = limiteSobregiro;
    }

    public void Depositar(decimal cantidad)
    {
        Saldo += cantidad;
        Console.WriteLine("Se ha depositado " + cantidad + " en la cuenta monetaria.");
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad <= Saldo + LimiteSobregiro)
        {
            Saldo -= cantidad;
            Console.WriteLine("Se ha retirado " + cantidad + " de la cuenta monetaria.");
        }
        else
        {
            Console.WriteLine("No se puede realizar el retiro. El saldo más el límite de sobregiro no es suficiente.");
        }
    }
}
    }