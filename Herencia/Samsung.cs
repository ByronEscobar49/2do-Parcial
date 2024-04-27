using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Samsung : Teléfono
    {
        public string color { get; set; }
        public string modelo { get; set;}
        public int memoria { get; set; }

        public void llamar()
        {
            Console.WriteLine("a quien quieres llamar");
        }
        public void jugar()
        {
            Console.WriteLine("que quieres jugar");
    }
    }
}

