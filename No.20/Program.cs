Console.WriteLine("Ingrese una palabra");
string texto=Console.ReadLine();
int resultado=ContarLetras(texto);
Console.WriteLine($"Hay {resultado} letras");
static int ContarLetras(string texto)
{
    return texto.Count();
}