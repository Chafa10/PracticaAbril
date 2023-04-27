using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace Ejemplo1Instituto
{
    public partial class ElegirCarrera : Form
    {
        public ElegirCarrera()
        {
            InitializeComponent();
        }

        private void ElegirCarrera_Load(object sender, EventArgs e)
        {
            NegocioCarreras negocio = new NegocioCarreras();

            cmbCarreras.DataSource = negocio.listaCarreras();
            cmbCarreras.ValueMember = "Expediente";
            cmbCarreras.DisplayMember = "Nombre";
        }

        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            AgregarCarrera agregarCarrera = new AgregarCarrera();
            agregarCarrera.ShowDialog();
        }
    }
}
