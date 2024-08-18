using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._1
{
    internal class EvaluadorLineal:Evaluador
    {
        private int VidaUtil;
        //private Moto vehiculo;
        //private int añoAcalcular;
        public EvaluadorLineal(Moto vehiculo,int añoACalcular,int vidautil):base(vehiculo,añoACalcular)
        {
            VidaUtil = vidautil;
            //this.vehiculo = vehiculo;
            //añoAcalcular = añoACalcular;
        }

        double valor = 0;
        public override double CalcularDepreciacion()
        {
           int añosDeUso= AñoACalcuar - Vehiculo.Modelo;
            
            if (VidaUtil>0 && añosDeUso>0)
            {
                valor = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añosDeUso / VidaUtil);
            }
            return valor;
        }

        public override string VerDescripcion()
        {
            return "Vehiculo: " + Vehiculo.Marca
                   + "\nModelo: " + Vehiculo.Modelo
                   + "\nValor Fabricacion : " + Vehiculo.ValorFabricacion
                   + "\nVida util: " + VidaUtil
                   + "\nDepreciacion Lineal: " + valor;


        }
    }
}
