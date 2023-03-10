// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese su nombre");
string st = Console.ReadLine();

if (st != "")
{
    Console.WriteLine("Su nombre es: " + st);    
}
else
{
    Console.WriteLine("Hello word!");
}
Console.ReadKey(true);