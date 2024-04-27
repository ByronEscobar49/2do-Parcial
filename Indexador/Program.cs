static void Main(string[] args)
{
    Console.WriteLine("¡Hola desde Jutiapa, Guatemala!");
}
class Estudiante
{
    private string[] nombres; // Arreglo para almacenar nombres

    public Estudiante(string[] nombres)
    {
        this.nombres = nombres;
    }

    // Indexador para acceder a los nombres por índice
    public string this[int indice]
    {
        get
        {
            if (indice >= 0 && indice < nombres.Length)
            {
                return nombres[indice];
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fuera del rango del arreglo");
            }
        }
        set
        {
            if (indice >= 0 && indice < nombres.Length)
            {
                nombres[indice] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fuera del rango del arreglo");
            }
        }
    }
}

