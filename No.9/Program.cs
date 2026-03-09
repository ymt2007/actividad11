Console.WriteLine("Ingrese el primer numero a sumar");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero a sumar");
int b=int.Parse(Console.ReadLine());
int resultado=SumaMostrar(a, b);
Console.WriteLine($"El resultado es: {resultado}");
static int SumaMostrar(int a, int b)
{
    return a + b;
}