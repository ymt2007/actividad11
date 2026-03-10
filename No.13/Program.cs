Console.WriteLine("Ingrese el primer numero a multiplicar");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero a multiplicar");
int b=int.Parse(Console.ReadLine());
int resultado = Multiplicar(a, b);
Console.WriteLine($"El resultado es: {resultado}");
static int Multiplicar(int a, int b)
{
    return a * b;
}