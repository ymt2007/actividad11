string op;
do
{
    Console.WriteLine("Ingrese el numero");
    int n=int.Parse(Console.ReadLine());
    int resultado=MostrarCuadrado(n);
    Console.WriteLine($"El resultado es {resultado}");
    Console.WriteLine("Desea ingresar otro numero? (s/n)");
    op=Console.ReadLine();
} while (op != "n");
static int MostrarCuadrado(int n)
{
    return n * n;
}