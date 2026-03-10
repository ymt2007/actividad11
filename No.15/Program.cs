Console.WriteLine("Ingrese el numero a verificar");
int n=int.Parse(Console.ReadLine());
bool resultado = EsPar(n);
Console.WriteLine(resultado);
static bool EsPar(int n)
{
    return n % 2 == 0;
}