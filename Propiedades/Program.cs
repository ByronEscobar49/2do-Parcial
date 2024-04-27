namespace Propiedades
{
    public class Celular
    {
        public DateTime TiempodeHOy
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Celular cel= new Celular();
            Console.WriteLine("hoy es: {0}" + cel .TiempodeHOy);
            Console.ReadKey();  
        }
    }
}
