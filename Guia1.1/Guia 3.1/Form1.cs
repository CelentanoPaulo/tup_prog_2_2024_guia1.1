using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJarc_Click(object sender, EventArgs e)
        {
            Moto miMoto = new Moto("Honda",1956,5000);
            
            

            //ejecutar y ver info de EvaluadorLineal
            //Evaluador miEvaluador = new EvaluadorLineal(miMoto, 2024, 50);
            //miEvaluador.CalcularDepreciacion();
            //tbInfo.Text = miEvaluador.VerDescripcion();

            //ejecutar y ver info de Evaluador anual
            Evaluador miEvaluadorAnual = new EvaluadorAnual(miMoto, 2024, 0.5);
            miEvaluadorAnual.CalcularDepreciacion();
            tbInfo.Text= miEvaluadorAnual.VerDescripcion();
        }
    }
}
