Console.WriteLine("Ingrese el numero hasta donde desea sumar");
int n=int.Parse(Console.ReadLine());
int resultado = SunarDel1AlN(n);
Console.WriteLine($"El resultado de la suma es: {resultado}");
static int SunarDel1AlN(int n)
{
    int suma = 0;
    for (int i = 0; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}