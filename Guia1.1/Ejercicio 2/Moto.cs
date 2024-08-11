using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Moto
    {
        private string marca;
        private int modelo;
        private double valorfabricacion;
        private double depreciacionlineal ;
        private double depreciacionanual ;

        

        public string Marca { get { return marca; } set { marca = value; } }
        public double ValorFabricacion { get { return valorfabricacion; } set { valorfabricacion = value; } }
        public int Modelo { get { return modelo; } set { modelo = value; } }

        public Moto(string marca, int modelo, double valorfabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorfabricacion= valorfabricacion;
        }


        public double CalcularDepreciacionLineal(int añoCalcular,int vidaUtil)
        {
            //int añodeuso = añoCalcular - modelo;
            //int a = añodeuso/ vidaUtil;
            depreciacionlineal = valorfabricacion - (valorfabricacion *(añoCalcular-modelo)/vidaUtil);
            return depreciacionlineal;
        }


        public double CalcularDepreciacionAnual(int añoCalcular,double tasaDepreciacion)
        {
            
            double AñosDeUso= añoCalcular-modelo;
            depreciacionanual = valorfabricacion * (Math.Pow(1 - tasaDepreciacion, AñosDeUso));
            return depreciacionanual;

        }


        public string VerDespreciacion()
        {
            return ("Marca: " + Marca + "Modelo: " + Modelo + "Valor Fabricacion: $" + ValorFabricacion
                + Environment.NewLine + "Depreciacion lineal: $" + depreciacionlineal
                + Environment.NewLine + "Depreciacion Anual: $" + depreciacionanual);
        }

    }
}
