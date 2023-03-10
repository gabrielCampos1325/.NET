string st = Console.ReadLine();

switch (st)
{
    case "Juan":
        Console.WriteLine("Hola amigo");
        break;
    case "Maria":
        Console.WriteLine("Buen dia señora");
        break;
    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;
    case "":
        Console.WriteLine("Buen dia mundo");
        break;
    default:
        Console.WriteLine("Buen dia " + st);
        break;
}
Console.ReadKey();