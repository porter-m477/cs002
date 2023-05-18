using System;

// TODO: Functions pueden asignar valores a sus parametros
void PrintWithPrefix(string thestr, string prefix)
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test con default parameters

PrintWithPrefix("texto prueba", "*****");


// TODO: Test con parametros individualizados
PrintWithPrefix(thestr: "Hola string", prefix: ">>>>>>");

