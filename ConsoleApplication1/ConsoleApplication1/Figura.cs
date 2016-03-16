using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Figura:ICalculable
    {
        protected float Base;
        protected float Altura;
        protected float Radio;
        
        public virtual float Area()
        {
            return 0;
        }
        public virtual float Perimetro()
        {
            return 0;
        }
    }
}