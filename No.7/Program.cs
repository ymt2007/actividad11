Console.WriteLine("Ingrese el numero de cual desea ver el doble");
int a=int.Parse(Console.ReadLine());
int res=MostrarDoble(a);
Console.WriteLine($"El resultado es: {res}");
static int MostrarDoble(int a)
{
    return a*2;
}
