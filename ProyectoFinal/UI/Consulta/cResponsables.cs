using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consulta
{
    public partial class cResponsables : Form
    {
        public cResponsables()
        {
            InitializeComponent();
        }
        private bool Validar(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                errorProvider1.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                errorProvider1.SetError(CriteriotextBox, "Debe de introducir una Palabra");
                paso = true;
            }

            return paso;
        }
        private void LimpiarError()
        {
            errorProvider1.Clear();
        }
        Expression<Func<Responsable, bool>> filtrar = x => true;
        private void cResponsables_Load(object sender, EventArgs e)
        {

        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;
            int numero;

            if (TipocomboBox.Text == string.Empty && CheckFecha.Checked == true)
            {
                filtrar = t => true && (t.FechaNacimiento.Day >= DesdePicker.Value.Day) && (t.FechaNacimiento.Month >= DesdePicker.Value.Month) && (t.FechaNacimiento.Year >= DesdePicker.Value.Year) && (t.FechaNacimiento.Day <= HastaPicker.Value.Day) && (t.FechaNacimiento.Month <= HastaPicker.Value.Month) && (t.FechaNacimiento.Year <= HastaPicker.Value.Year);
            }
            else
            {
                filtrar = t => true;
            }


            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    LimpiarError();
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.ResponsableId == id;
                    break;
                //Nombre
                case 1:
                    LimpiarError();
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduce una Palabra");
                        return;
                    }
                    filtrar = t => t.Nombre.Contains(CriteriotextBox.Text);
                    break;

                //NumeroResponsable
                case 2:
                    LimpiarError();
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduce un Numero");
                        return;
                    }
                    numero = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.Numero == numero;
                    break;
                    //Direccion
                case 3:
                    LimpiarError();
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduce una Palabra");
                        return;
                    }
                    filtrar = t => t.Direccion.Contains (CriteriotextBox.Text);
                    break;
                //Cedula
                case 4:
                    LimpiarError();
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Cedula == CriteriotextBox.Text;
                    break;
              
                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }


            ConsultadataGridView.DataSource = BLL.ResponsableBLL.GetList(filtrar);
        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.Clear();
            LimpiarError();
            if (TipocomboBox.SelectedIndex == 5)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }
    }
}
