using System;
using System.Collections.Generic;
using ProyectoFinal.Entidades;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registro
{
    public partial class rCantos : Form
    {
        public rCantos()
        {
            InitializeComponent();
        }
        private Canto Vaciar()
        {
            Canto canto = new Canto();
            CantoNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            VersiculoTextBox.Clear();
            PaginaNumericUpDown.Value = 0;
            ColorComboBox.SelectedIndex= -1;
            MomentoComboBox.SelectedIndex = -1;
            TiempoComboBox.SelectedIndex = -1;

            return canto;
        }

        private Canto LlenaClase()
        {
            Canto canto = new Canto();

            canto.CantoId = Convert.ToInt32(CantoNumericUpDown.Value);
            canto.Nombre = NombreTextBox.Text;
            canto.Versiculo = VersiculoTextBox.Text;
            canto.pagina = Convert.ToInt32(PaginaNumericUpDown.Value);
            canto.Color = ColorComboBox.Text;
            canto.Momento = MomentoComboBox.Text;
            canto.Tiempo = TiempoComboBox.Text;

            return canto;
        }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && CantoNumericUpDown.Value == 0)
            {
                errorProvider.SetError(CantoNumericUpDown, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }

            private void rCantos_Load(object sender, EventArgs e)
        {

        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider.Clear();


            if (CantoNumericUpDown.Value == 0)
                paso = BLL.CantoBLL.Guardar(LlenaClase());
            else
                paso = BLL.CantoBLL.Modificar(LlenaClase());

            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(CantoNumericUpDown.Value);

            if (BLL.CantoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(CantoNumericUpDown.Value);
            Canto canto = BLL.CantoBLL.Buscar(id);

            if (canto != null)
            {

                NombreTextBox.Text = canto.Nombre;
                VersiculoTextBox.Text = canto.Versiculo;
                ColorComboBox.SelectedText = canto.Color;
                MomentoComboBox.SelectedText = canto.Momento;
                TiempoComboBox.SelectedText = canto.Tiempo;
                PaginaNumericUpDown.Value = canto.pagina;
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }


