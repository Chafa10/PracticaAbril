
namespace Ejemplo1Instituto
{
    partial class ElegirCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnAsignarMateriaCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(246, 52);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(396, 21);
            this.cmbCarreras.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(121, 181);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(727, 297);
            this.dgvCursos.TabIndex = 1;
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Location = new System.Drawing.Point(732, 52);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarCarrera.TabIndex = 2;
            this.btnAgregarCarrera.Text = "Agregar Carrera";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.btnAgregarCarrera_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(385, 516);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(156, 23);
            this.btnAgregarMateria.TabIndex = 3;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // btnAsignarMateriaCurso
            // 
            this.btnAsignarMateriaCurso.Location = new System.Drawing.Point(179, 516);
            this.btnAsignarMateriaCurso.Name = "btnAsignarMateriaCurso";
            this.btnAsignarMateriaCurso.Size = new System.Drawing.Size(156, 23);
            this.btnAsignarMateriaCurso.TabIndex = 4;
            this.btnAsignarMateriaCurso.Text = "Asignar Materia a un Curso";
            this.btnAsignarMateriaCurso.UseVisualStyleBackColor = true;
            this.btnAsignarMateriaCurso.Click += new System.EventHandler(this.btnAsignarMateriaCurso_Click);
            // 
            // ElegirCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 583);
            this.Controls.Add(this.btnAsignarMateriaCurso);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.cmbCarreras);
            this.Name = "ElegirCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElegirCarrera";
            this.Load += new System.EventHandler(this.ElegirCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAsignarMateriaCurso;
    }
}