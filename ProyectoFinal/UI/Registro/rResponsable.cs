using ProyectoFinal.Entidades;
using System;
using ProyectoFinal.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registro
{
    public partial class rResponsable : Form
    {
        public rResponsable()
        {
            InitializeComponent();
        }
        private Responsable LlenarClase()
        {
            Responsable responsable = new Responsable();
            responsable.ResponsableId = Convert.ToInt32(ResponsableIdNumericUpDown.Value);
            responsable.Nombre = NombreTextBox.Text;
            responsable.Apellido = ApellidoTextBox.Text;
            responsable.Direccion = DireccionTextBox.Text;
            responsable.TelefonoCasa = TelCasaTextBox.Text;
            responsable.TelefonoCelular = TelCelTextBox.Text;
            responsable.TelefonoOtro = TelOtroTextBox.Text;
            responsable.Cedula = CedulaTextBox.Text;
            responsable.FechaNacimiento = Convert.ToDateTime(NacimientoFechaPicker.Text);
            responsable.Numero = Convert.ToInt32(NumeroResponsableUpDown.Value);

            return responsable;
        }

        private Responsable Vaciar()
        {
            Responsable responsable = new Responsable();

            ResponsableIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            DireccionTextBox.Clear();
            TelCasaTextBox.Clear();
            TelCelTextBox.Clear();
            TelOtroTextBox.Clear();
            CedulaTextBox.Clear();
            NumeroResponsableUpDown.Value = 0;


            return responsable;
        }
      
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && TotalResponsableNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(ResponsableIdNumericUpDown, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }


        private void rResponsable_Load(object sender, EventArgs e)
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

            int id = Convert.ToInt32(ResponsableIdNumericUpDown.Value);
            Responsable responsable = BLL.ResponsableBLL.Buscar(id);

            if (responsable != null)
            {

                ResponsableIdNumericUpDown.Value = responsable.ResponsableId;
                NombreTextBox.Text = responsable.Nombre;
                ApellidoTextBox.Text = responsable.Apellido;
                DireccionTextBox.Text = responsable.Direccion;
                TelCasaTextBox.Text = responsable.TelefonoCasa;
                TelCelTextBox.Text = responsable.TelefonoCelular;
                TelOtroTextBox.Text = responsable.TelefonoOtro;
                CedulaTextBox.Text = responsable.Cedula;
                NumeroResponsableUpDown.Value = responsable.Numero;



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


            if (ResponsableIdNumericUpDown.Value == 0)
                paso = BLL.ResponsableBLL.Guardar(LlenarClase());
            else
                paso = BLL.ResponsableBLL.Modificar(LlenarClase());


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

            int id = Convert.ToInt32(ResponsableIdNumericUpDown.Value);

            if (BLL.ResponsableBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }
    }
    }

