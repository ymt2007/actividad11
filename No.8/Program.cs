string op:
do
{
    Console.WriteLine("Ingrese el numero");
    int n=int.Parse(Console.ReadLine());
    Console.WriteLine("Desea ingresar otro numero? (s/n)");
    op=Console.ReadLine();
} while (op != "n");
