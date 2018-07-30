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


namespace ProyectoFinal.UI.Login
{
    
    public partial class LogIn : Form
    {
        public LogIn()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // VentanaPrincipal ventana = new VentanaPrincipal();
           // ventana.Show();
            int paso = 0;
          
            Expression<Func<Usuario, bool>> filtrar = x => true;
            List<Usuario> user = new List<Usuario>();

            limpiarError();

            if (UsuarioTextBox.Text == string.Empty)
            {
                paso = 1;
                errorProvider1.SetError(UsuarioTextBox, "Incorrecto");

            }
            if (ContrasenaTextBox.Text == string.Empty)
            {
                paso = 1;
                errorProvider1.SetError(ContrasenaTextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }

            filtrar = t => t.NombreUsuario.Equals(UsuarioTextBox.Text);
            user = BLL.UsuarioBLL.GetList(filtrar);

            if (user.Exists(x => x.NombreUsuario == UsuarioTextBox.Text) && user.Exists(x => x.Clave == ContrasenaTextBox.Text))
            {
                VentanaPrincipal ventana = new VentanaPrincipal();
               ventana.Show();
                LogIn login = new LogIn();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                errorProvider1.SetError(UsuarioTextBox, "Incorrecto");
                errorProvider1.SetError(ContrasenaTextBox, "Incorrecto");

            }
            ContrasenaTextBox.MaxLength = 14;
           

        }

        void limpiarError()
        {
            errorProvider1.Clear();
            errorProvider1.Clear();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContrasenaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
