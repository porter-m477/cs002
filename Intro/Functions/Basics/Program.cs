using System;

// Demostracion de funciones


// TODO: Functions con return type, name, and optional parameters
float MillasAkm(float miles)
{
    float result = miles * 1.6f;
    return result;
}


// TODO: Function sin return value - es tipo 'void'
void imprimirPrefix(string theStr)
{
    Console.WriteLine($"::> {theStr}");
}


// TODO: Exec funct 1
Console.WriteLine($"resultado es {MillasAkm(8.0f)}");
Console.WriteLine($"resultado es {MillasAkm(53.0f)}");


// TODO: Exec funct 2
imprimirPrefix("Cadena de prueba");
imprimirPrefix("Texto de prueba");

