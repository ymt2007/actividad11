Console.WriteLine("Ingrese un nombre");
string nombre = Console.ReadLine();
Saludar(nombre);
static void Saludar(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}