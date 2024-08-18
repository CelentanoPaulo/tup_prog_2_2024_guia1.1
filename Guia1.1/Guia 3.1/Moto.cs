using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3._1
{
    internal class Moto
    {
        private string marca;
        private int modelo;
        private double valorFabricacion;

        public string Marca { get { return marca; } private set { } }
        public int Modelo { get { return modelo; } private set { } }
        public double ValorFabricacion { get {  return valorFabricacion; } private set { } }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorFabricacion = valorFabricacion;
            
        }

        public string VerDescripcion()
        {
            return "Marca: " + Marca + "Modelo: " + Modelo + "Valor Fabricacion: " + ValorFabricacion;
        }
    }
}
