namespace Delegados
{
    class Program
    {
        delegate int buscarMayorNumero(List<int> lst);
        static int Buscador(List<int> lst_)
        {
            return lst_.OrderByDescending(d => d).First();
        }   
        static void Main(string[]args)
        {
            buscarMayorNumero fn1 = Buscador;
            Console.WriteLine(fn1(new List<int> { 2,3,4,6,9,14,47}));
            Console.Read();
        }
    }
}
