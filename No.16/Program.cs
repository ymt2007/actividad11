Console.WriteLine("Ingrese el numero a verificar");
int n=int.Parse(Console.ReadLine());
bool resultado= EsPositivo(n);
Console.WriteLine(resultado);
static bool EsPositivo(int n)
{
    return n > 0;
}