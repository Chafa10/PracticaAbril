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
    public partial class AsignarMateriaAcurso : Form
    {
        public AsignarMateriaAcurso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AsignarMateriaAcurso_Load(object sender, EventArgs e)
        {

            try
            {
                NegocioCarreras negocioCarreras = new NegocioCarreras();
                NegocioMaterias negocioMaterias = new NegocioMaterias();
                cmbCarrera.DataSource = negocioCarreras.listaCarreras();
                cmbCarrera.ValueMember = "Expediente";
                cmbCarrera.DisplayMember = "Nombre";

                cmbMateria.DataSource = negocioMaterias.listaMaterias();
                cmbMateria.ValueMember = "IdMateria";
                cmbMateria.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            
        }
    }
}
