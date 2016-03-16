using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circulo : Figura
    {
        public override float Area ()
        {
            return (float)Math.PI * (Radio * Radio); 
            
        }
        public override float Perimetro()
        {
            return 2*(float)Math.PI * Radio;

        }
        public Circulo(float Radio)
        {
            this.Radio = Radio;
        }
    }
}
