Console.WriteLine("Ingrese el texto que desea que se repita");
string texto=Console.ReadLine();
Console.WriteLine("Ingrese la cantidad de veces que desea que se repita");
int veces=int.Parse(Console.ReadLine());
string resultado = Repetir(texto, veces);
Console.WriteLine(resultado);
static string Repetir(string texto, int veces)
{
    string resultado = "";
    for (int i = 0; i < veces; i++)
    {
        resultado = resultado + texto + "\n";
    }
    return resultado;
}