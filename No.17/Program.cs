Console.WriteLine("Ingrese el primer numero");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int b=int.Parse(Console.ReadLine());
int resultado = Mayor(a, b);
Console.WriteLine($"El mayor es: {resultado}");

static int Mayor(int a, int b)
{
    if(a>b)
        return a;
    else 
        return b;
}