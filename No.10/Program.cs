Console.WriteLine("Ingrese el texto que desea imprimir");
string texto=Console.ReadLine();
Console.WriteLine("Ingrese cuantas veces desea repetirlo");
int veces=int.Parse(Console.ReadLine());
ImprimirRepetido(texto, veces);
static void ImprimirRepetido(string texto, int veces)
{
    for(int i=1;i<=veces;i++)
    {
        Console.WriteLine(texto);
    }
}
