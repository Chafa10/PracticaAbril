﻿
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
            this.cmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(167, 84);
            this.cmbCarreras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(592, 28);
            this.cmbCarreras.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(167, 202);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(676, 317);
            this.dgvCursos.TabIndex = 1;
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Location = new System.Drawing.Point(896, 84);
            this.btnAgregarCarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(188, 35);
            this.btnAgregarCarrera.TabIndex = 2;
            this.btnAgregarCarrera.Text = "Agregar Carrera";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.btnAgregarCarrera_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(566, 623);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(234, 35);
            this.btnAgregarMateria.TabIndex = 3;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // btnAsignarMateriaCurso
            // 
            this.btnAsignarMateriaCurso.Location = new System.Drawing.Point(256, 623);
            this.btnAsignarMateriaCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignarMateriaCurso.Name = "btnAsignarMateriaCurso";
            this.btnAsignarMateriaCurso.Size = new System.Drawing.Size(234, 35);
            this.btnAsignarMateriaCurso.TabIndex = 4;
            this.btnAsignarMateriaCurso.Text = "Curso/Asignar Materia";
            this.btnAsignarMateriaCurso.UseVisualStyleBackColor = true;
            this.btnAsignarMateriaCurso.Click += new System.EventHandler(this.btnAsignarMateriaCurso_Click);
            // 
            // ElegirCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 712);
            this.Controls.Add(this.btnAsignarMateriaCurso);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.cmbCarreras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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