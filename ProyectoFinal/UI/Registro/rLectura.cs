using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registro
{
    public partial class rLectura : Form
    {
        public rLectura()
        {
            InitializeComponent();
        }
        private Lectura Vaciar()
        {
            Lectura lectura = new Lectura();
            LecturaIdNumericUpDown.Value = 0;
            AutorTextBox.Clear();
            TipoComboBox.SelectedIndex = -1;
            AbreviaturaTextBox.Clear();
            
            return lectura;

        }
        private Lectura LlenarClase()
        {
            Lectura lectura = new Lectura();

            lectura.LecturaId = Convert.ToInt32(LecturaIdNumericUpDown.Value);
            lectura.Autor = AutorTextBox.Text;
            lectura.Tipo = TipoComboBox.Text;
            lectura.Abreviatura = AbreviaturaTextBox.Text;

            return lectura;
        }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && LecturaIdNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(LecturaIdNumericUpDown, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }


        private void rLectura_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(LecturaIdNumericUpDown.Value);
            Lectura lectura = BLL.LecturaBLL.Buscar(id);

            if (lectura != null)
            {

                AutorTextBox.Text = lectura.Autor;
                TipoComboBox.SelectedValue = lectura.Tipo;
                AbreviaturaTextBox.Text = lectura.Abreviatura;
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider1.Clear();


            if (LecturaIdNumericUpDown.Value == 0)
                paso = BLL.LecturaBLL.Guardar(LlenarClase());
            else
                paso = BLL.LecturaBLL.Modificar(LlenarClase());


            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(LecturaIdNumericUpDown.Value);

            if (BLL.LecturaBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }


