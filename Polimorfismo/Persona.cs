﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Persona
    {
        public string Nombre {  get; set; }
        public Persona(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public virtual void Accion() { }
    }
}
