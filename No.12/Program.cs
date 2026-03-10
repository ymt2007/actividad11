Console.WriteLine("Ingrese el minuendo");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el sustraendo");
int b=int.Parse(Console.ReadLine());
int resultado=restar(a,b);
Console.WriteLine($"El resultado es: {resultado}");
static int restar(int a, int b)
{
    return a - b; 
}