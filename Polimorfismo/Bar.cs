using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Bar
    {
        List<Persona> lstpersonas= new List<Persona>();
        public void Entrar (Persona oPersona)
        {
            lstpersonas.Add(oPersona);
            oPersona.Accion();
        }
    }
}
