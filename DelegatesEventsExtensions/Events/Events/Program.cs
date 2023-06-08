using Essentials2.Library;

Delegate del = WriteHello;
del.DynamicInvoke("matt");

DelegateSample.PassWork(WriteHello);
static void WriteHello(string name)
{
    Console.WriteLine($"String {name}");
}