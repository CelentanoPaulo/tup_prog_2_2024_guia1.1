using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Viaje
    {
        private int transportados=0;
        private int asientos;
        private int hDemora;
        private int mDemora;
        private int cantParadas=0;
        private int hDuracionViaje;
        private int mDuracionViaje;
        private int hInicio;
        private int mInicio;
        private int tiempototaldemora=0;
        

        public int Transportados {  get { return transportados; } set {  transportados = value; } }
        public int Asientos { get { return asientos; } set {  asientos = value; } }
        public int HDemora { get {  return hDemora; } set {  hDemora = value; } }
        public int MDemora { get { return mDemora; } set {  mDemora = value; } }
        public int CantParadas { get {  return cantParadas; } set {  cantParadas = value; } }
        public int HDuracionViaje {  get { return hDuracionViaje; } set { hDuracionViaje= value; } }    
        public int MDuracionViaje { get { return mDuracionViaje; } set { mDuracionViaje = value; } }
        public int TiempoTotalParada { get { return tiempototaldemora; } set { tiempototaldemora = value; } }


        public Viaje (int hInicio,int mInicio,int asientos)
        {
            this.asientos = asientos;
            this.hInicio=hInicio;
            this.mDemora=mInicio;
        }

       

        public void RealizarParada(int hLlegadaParada,int mLlegadaParada,int hSalidaParada,int mSalidaParada,int Desciende,int asciencen)
        {
            cantParadas += 1;
            int asientosDisp = asientos;
            int intervaloParada= hSalidaParada*60+mSalidaParada-(hLlegadaParada*60+mLlegadaParada);
            tiempototaldemora += intervaloParada;
            transportados += asciencen;
            asientosDisp-=asciencen;
            asientosDisp += Desciende;

            
            
        }

        public int Finalizar (int hLlegada, int mLlegada)
        {
            int intervalo = hLlegada * 60 + mLlegada - (hInicio * 60 + mInicio);
            return intervalo;
        }
    }
}
