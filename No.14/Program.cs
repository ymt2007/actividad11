Console.WriteLine("Ingrese el dividendo");
double a=double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el divisor");
double b=double.Parse(Console.ReadLine());
double resultado = Dividir(a, b);
Console.WriteLine($"El resultado es {resultado}");
static double Dividir(double a, double b)
{
    return a / b;
}