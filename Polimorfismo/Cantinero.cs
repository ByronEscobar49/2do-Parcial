using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cantinero : Persona
    { 
        public Cantinero(string Nombre) : base(Nombre) { }
        public override void Accion()
        {
            Console.WriteLine("Hace bebidas");
        }
    }
}
