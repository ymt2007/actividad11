Console.WriteLine("Ingrese el numero a verificar");
int numero=int.Parse(Console.ReadLine());
if(EsPrimo(numero))
{
    Console.WriteLine($"El numero {numero} es primo");
}
else
{
    Console.WriteLine($"El numero {numero} no es primo");
}
static bool EsPrimo(int n)
    {
        if(n<=1)
            return false;
        if(n==2)
            return true;
        if(n%2==0)
            return false;
        for(int i=3;i*i<=n;i++)
        {
            if(n%i==0)
            {
                return false;
            }
        }
        return true;
    }