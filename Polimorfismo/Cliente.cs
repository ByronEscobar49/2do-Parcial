﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cliente : Persona
    {
        public Cliente(string Nombre): base (Nombre) { }
        public override void Accion()
        {
            Console.WriteLine("Toma bebidas");
        }
    }
}
