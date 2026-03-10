Console.WriteLine("Ingrese el primer numero");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
int c = int.Parse(Console.ReadLine());
int resultado = MenorDeTres(a, b, c);
Console.WriteLine($"El menor es: {resultado}");
static int MenorDeTres(int a, int b, int c)
{
    if (a < b && a < c)
        return a;
    else if (b < a && b < c)
        return b;
    else
        return c;
}