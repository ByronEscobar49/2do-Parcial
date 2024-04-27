namespace Interfaces
{


public interface ICamara
    {
        void mostrarAppCamara();
        void Tomarfotografia();
        string NombreFoto { get; set;}
        int CantidadFoto {get; set;}
    }

    class Celular : ICamara
    {
        public string NombreFoto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CantidadFoto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void mostrarAppCamara()
        {
           Console.WriteLine("se esta mostrando la app de camara en el celular");
        }

        public void Tomarfotografia()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Celular cel = new Celular();
            cel.mostrarAppCamara();
            Console.ReadKey();
        }
    }
}


