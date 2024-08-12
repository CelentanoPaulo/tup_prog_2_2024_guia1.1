using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Viaje miViaje;
        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            modalIniciarViaje ModalIniciar = new modalIniciarViaje();
            
            if (ModalIniciar.ShowDialog() == DialogResult.OK)
            {
                int cantAsientos = Convert.ToInt32(ModalIniciar.tbCantAsientos.Text);
                int hinicio = Convert.ToInt32(ModalIniciar.tbentradaHH.Text);
                int minicio = Convert.ToInt32(ModalIniciar.tbentradaMM.Text);
                miViaje = new Viaje(hinicio, minicio, cantAsientos);
            }
            
        }

        private void btnFinalizarVIaje_Click(object sender, EventArgs e)
        {
            int hfinalizacion = Convert.ToInt32(tbHHfinalizacion.Text);
            int mfinalizacion = Convert.ToInt32(tbMMfinalizacion.Text);
           int IntervaloFinalizacion= miViaje.Finalizar(hfinalizacion,mfinalizacion);
            modalInforme miInforme= new modalInforme();
            miInforme.lbInforme.Items.Add("duracion del recorrido total: "+IntervaloFinalizacion);
            miInforme.lbInforme.Items.Add("cantidad de transportados en total: " + miViaje.Transportados);
            miInforme.lbInforme.Items.Add("cantidad de paradas en total: "+miViaje.CantParadas);
            miInforme.lbInforme.Items.Add("tiempo total de paradas: "+miViaje.TiempoTotalParada);
            miInforme.Show();
        }

        private void btnIngresarParada_Click(object sender, EventArgs e)
        {
            modalIngresoDatos modaldatos= new modalIngresoDatos();
            if (modaldatos.ShowDialog() == DialogResult.OK)
            {
                int hllegada = Convert.ToInt32(modaldatos.tbHHllegada.Text);
                int mllegada = Convert.ToInt32(modaldatos.tbMMllegada.Text);
                int hsalida = Convert.ToInt32(modaldatos.tbHHsalida.Text);
                int msalida = Convert.ToInt32(modaldatos.tbMMsalida.Text);
                int desciende = Convert.ToInt32(modaldatos.tbDesciende.Text);
                int asciende = Convert.ToInt32(modaldatos.tbAsciende.Text);
                miViaje.RealizarParada(hllegada, mllegada, hsalida, msalida, desciende, asciende);
            }
        }
    }
}
