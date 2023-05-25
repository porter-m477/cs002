using System;

namespace Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("001-12345-01","Mynor Lopez","Ahorro",12345678921,"Guatemalteco","zona 7 de mixco",5000);
            Console.WriteLine($"El numero de cuenta: {c1.NoCuenta} es de {c1.Nombre} y tiene Q.{c1.Saldo}");
            c1.Nombre = "Santiago Sandoval";
            Console.WriteLine($"El usario cambio su nombre y ahora es: {c1.Nombre}");
            Console.WriteLine($"Cuenta: {c1.NoCuenta} Usuario: {c1.Nombre} \nDeposito de Q.{c1.Deposito(500)} y el nuevo saldo es de Q.{c1.Saldo}");
            Console.WriteLine($"Cuenta: {c1.NoCuenta} Usuario: {c1.Nombre} \nRetiro   de Q.{c1.Retiro(1500)} y el nuevo saldo es de Q.{c1.Saldo}");

        }
    }
}