Console.WriteLine("Ingrese el numero para factorial");
int n=int.Parse(Console.ReadLine());
int resultado = Factorial(n);
Console.WriteLine($"El resultado del factorial es: {resultado}");
static int Factorial(int n)
{
    int fac = 1;
    for (int i = 1; i <=n; i++)
    {
        fac *= i;
    }
    return fac;
}