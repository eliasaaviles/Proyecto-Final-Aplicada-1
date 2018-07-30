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
    public partial class cCantos : Form
    {
        public cCantos()
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
                errorProvider1.SetError(CriteriotextBox, "Debe de introducir una palabra");
                paso = true;
            }

            return paso;
        }
        private void LimpiarError()
        {
            errorProvider1.Clear();
        }

        Expression<Func<Canto, bool>> filtrar = x => true;

        private void cCantos_Load(object sender, EventArgs e)
        {

        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    LimpiarError();
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduce un ID");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.CantoId == id;
                    break;
                //Nombre
                case 1:
                    LimpiarError();
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduce un Nombre");
                        return;
                    }
                    filtrar = t => t.Nombre.Contains(CriteriotextBox.Text);
                    break;

                //Color
                case 2:
                    LimpiarError();
                    if (Validar(1))
                    {
                        MessageBox.Show("Introduce una cedula");
                        return;

                    }
                    filtrar = t => t.Color == CriteriotextBox.Text;
                    break;
                //Tiempo
                case 3:
                    LimpiarError();
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduce una Palabra");
                        return;
                    }
                    filtrar = t => t.Tiempo.Contains(CriteriotextBox.Text);
                    break;
                    //Momento
                case 4:
                    LimpiarError();
                    if (Validar(2))
                    {
                        MessageBox.Show("Introduce una Palabra");
                        return;
                    }
                    filtrar = t => t.Momento.Contains(CriteriotextBox.Text);
                    break;

                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }


            ConsultadataGridView.DataSource = BLL.CantoBLL.GetList(filtrar);
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
