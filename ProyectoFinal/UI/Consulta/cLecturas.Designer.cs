﻿namespace ProyectoFinal.UI.Consulta
{
    partial class cLecturas
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
            this.components = new System.ComponentModel.Container();
            this.ReporteButton = new System.Windows.Forms.Button();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteButton
            // 
            this.ReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteButton.Location = new System.Drawing.Point(15, 279);
            this.ReporteButton.Name = "ReporteButton";
            this.ReporteButton.Size = new System.Drawing.Size(107, 31);
            this.ReporteButton.TabIndex = 54;
            this.ReporteButton.Text = "Reporte";
            this.ReporteButton.UseVisualStyleBackColor = true;
            // 
            // Consultabutton
            // 
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(292, 15);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(99, 37);
            this.Consultabutton.TabIndex = 53;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "ID",
            "Autor",
            "Abreviatura",
            "Listar Todo"});
            this.TipocomboBox.Location = new System.Drawing.Point(12, 24);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipocomboBox.TabIndex = 52;
            this.TipocomboBox.SelectedIndexChanged += new System.EventHandler(this.TipocomboBox_SelectedIndexChanged);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(158, 24);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(128, 20);
            this.CriteriotextBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Criterio";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(12, 8);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(29, 13);
            this.Tipo.TabIndex = 49;
            this.Tipo.Text = "Filtro";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 65);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(592, 199);
            this.ConsultadataGridView.TabIndex = 48;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cLecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 317);
            this.Controls.Add(this.ReporteButton);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "cLecturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Lecturas";
            this.Load += new System.EventHandler(this.cLecturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReporteButton;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}