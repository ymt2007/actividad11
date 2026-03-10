Console.WriteLine("Ingrese el texto");
string texto=Console.ReadLine();
int resultado=ContarVocales(texto);
Console.WriteLine($"El total de las vocales en las palabras es de: {resultado}");
static int ContarVocales(string texto)
{
    int cont = 0;
    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == 'a'|| texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
        {
            cont++;
        }
    }
    return cont;
}