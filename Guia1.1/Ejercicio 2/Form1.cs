using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Moto MiMoto;
        ModalResultado MiModal;

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {

            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(tbModeloAño.Text);
            double valorfabricacion = Convert.ToDouble(tbValorFabricacion.Text);
            MiMoto = new Moto(marca, modelo, valorfabricacion);

            int añocalcular = Convert.ToInt32(tbAñoCalcular.Text);
            int vidautil= Convert.ToInt32(tbVidaUtil.Text);
            MiMoto.CalcularDepreciacionLineal(añocalcular,vidautil);

            double tasadepreciacion= Convert.ToDouble(tbTasaDepreciacion.Text);
            MiMoto.CalcularDepreciacionAnual(añocalcular,tasadepreciacion);

            MiModal=new ModalResultado();
            MiModal.lbResultado.Text= MiMoto.VerDespreciacion();
            MiModal.Show();


        }
    }
}
