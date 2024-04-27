using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracción
{
    public class Computadora
    {
        // ATRIBUTOS
        public string marca { get; }  
        public double tamaño { get; set; }
        public int precio { get; set; }

        // METODOS
        public void diseñar()
        {
            //Código del Metodo
            Console.WriteLine("diseñar");
        }
        public void trabajar() {
            //Código del Metodo
            Console.WriteLine("trabajar");
        }
    }
    
}



