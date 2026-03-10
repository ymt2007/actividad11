Console.WriteLine("Ingrese el primer numero ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int m=int.Parse(Console.ReadLine());
bool resultado=EsMultiplo(n,m);
Console.WriteLine($"El numero ingresado es multiplo? {resultado}");
static bool EsMultiplo(int n, int m)
{
    return n % m == 0;
}