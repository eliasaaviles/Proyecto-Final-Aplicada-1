using ProyectoFinal.DAL;
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
    public partial class rHermano : Form
    {
        public rHermano()
        {
            InitializeComponent();
            TextBox();
            
        }

        private Hermano LlenarClase ()
        {
            Hermano hermano = new Hermano();
            hermano.HermanoId = Convert.ToInt32(HermanoIdNumericUpDown.Value);
            hermano.Nombre = NombreTextBox.Text;
            hermano.Apellido = ApellidoTextBox.Text;
            hermano.Direccion = DireccionTextBox.Text;
            hermano.TelefonoCasa = TelCasaTextBox.Text;
            hermano.TelefonoCelular = TelCelTextBox.Text;
            hermano.TelefonoOtro = TelOtroTextBox.Text;
            hermano.Cedula = CedulaTextBox.Text;
            hermano.FechaNacimiento = Convert.ToDateTime( NacimientoFechaPicker.Text);

            return hermano;
        }
        private void TextBox()
        {
            Hermano hermano = new Hermano();
            TotalBox.Text = hermano.TotalHermano.ToString();
        }

        private Hermano Vaciar()
        {
            Hermano hermano = new Hermano();

            HermanoIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            DireccionTextBox.Clear();
            TelCasaTextBox.Clear();
            TelCelTextBox.Clear();
            TelOtroTextBox.Clear();
            CedulaTextBox.Clear();
            

            return hermano;
           }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && HermanoIdNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(HermanoIdNumericUpDown, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rHermano_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(HermanoIdNumericUpDown.Value);
            Hermano hermano = BLL.HermanoBLL.Buscar(id);

            if (hermano != null)
            {

                HermanoIdNumericUpDown.Value = hermano.HermanoId;
                NombreTextBox.Text = hermano.Nombre;
                ApellidoTextBox.Text = hermano.Apellido;
                DireccionTextBox.Text = hermano.Direccion;
                TelCasaTextBox.Text = hermano.TelefonoCasa;
                TelCelTextBox.Text = hermano.TelefonoCelular;
                TelOtroTextBox.Text = hermano.TelefonoOtro;
                CedulaTextBox.Text = hermano.Cedula;
                TotalBox.Text = hermano.TotalHermano.ToString();

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void GuardarButto_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider1.Clear();
            Hermano hermano = new Hermano();

            if (HermanoIdNumericUpDown.Value == 0)
                paso = BLL.HermanoBLL.Guardar(LlenarClase());
                       
                
            else
                paso = BLL.HermanoBLL.Modificar(LlenarClase());


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

            int id = Convert.ToInt32(HermanoIdNumericUpDown.Value);

            if (BLL.HermanoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

