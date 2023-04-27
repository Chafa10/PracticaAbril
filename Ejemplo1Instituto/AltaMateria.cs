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
    public partial class AltaMateria : Form
    {
        public AltaMateria()
        {
            InitializeComponent();
        }

        private void AltaMateria_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Materias nuevaMateria = new Materias();
                NegocioMaterias negocio = new NegocioMaterias();

                nuevaMateria.Nombre = txtNombre.Text;
                nuevaMateria.Horas = int.Parse(txtHoras.Text);

                negocio.altaMateria(nuevaMateria);
                MessageBox.Show("Agregado exitoszmente");
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
    }
}
