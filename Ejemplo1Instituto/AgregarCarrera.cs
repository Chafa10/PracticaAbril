using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace Ejemplo1Instituto
{
    public partial class AgregarCarrera : Form
    {
        public AgregarCarrera()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Carreras nuevaCarrera = new Carreras();
            NegocioCarreras negocio = new NegocioCarreras();
            try
            {
                nuevaCarrera.Nombre = txtNombre.Text;
                nuevaCarrera.Modalidad = txtModalidad.Text;
                nuevaCarrera.HorasTotales = int.Parse(txtHorasTotales.Text);
                nuevaCarrera.EstadoDeLaCarrera = false;

                negocio.agregarCarrera(nuevaCarrera);

                MessageBox.Show("Agregaste la carrera exitozamente!!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
