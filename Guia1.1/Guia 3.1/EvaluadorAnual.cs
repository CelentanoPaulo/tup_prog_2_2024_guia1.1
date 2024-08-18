using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._1
{
    internal class EvaluadorAnual : Evaluador
    {
        private double tasaDepreciacion;
        public double TasaDepreciacion { get { return tasaDepreciacion; } }

        public EvaluadorAnual(Moto Vehiculo, int añoACalcular, double tasaDepreciacion) : base(Vehiculo, añoACalcular)
        {
            this.tasaDepreciacion = tasaDepreciacion;
        }

        public override double CalcularDepreciacion()
        {
            int añosDeUso = AñoACalcuar - Vehiculo.Modelo;
            tasaDepreciacion = Vehiculo.ValorFabricacion * (Math.Pow(1 - tasaDepreciacion, añosDeUso));
            return tasaDepreciacion;
        }

        public override string VerDescripcion()
        {
            return "Vehiculo: " + Vehiculo.Marca
                  + "Modelo: " + Vehiculo.Modelo
                  + "Valor Fabricacion : " + Vehiculo.ValorFabricacion
                  + "Depreciacion Lineal: " + TasaDepreciacion;
        }
    }
}
