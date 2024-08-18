using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._1
{
    internal  abstract class  Evaluador
    {
        private int añoACalcular;
        public int AñoACalcuar { get { return añoACalcular; }}

        private Moto vehiculo;
        public Moto Vehiculo { get { return vehiculo; } }
        public Evaluador(Moto vehiculo,int AñoAcalcular) 
        { 
            this.vehiculo=vehiculo;
            añoACalcular = AñoAcalcular;
        }

        public abstract double CalcularDepreciacion();

        public virtual string VerDescripcion()
        {
            return " ";
        }

    }
}
