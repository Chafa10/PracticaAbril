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

              
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCursos negocio = new NegocioCursos();
                Cursos nuevoCurso = new Cursos();

                nuevoCurso.ExpedienteCarrera = (int)cmbCarrera.SelectedValue;
                nuevoCurso.Nombre = txtNombre.Text;
                nuevoCurso.Caracteristica = txtCaracteristica.Text;

                negocio.agregarCurso(nuevoCurso);

                MessageBox.Show("Agregaste un curso exitosamente");               
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
