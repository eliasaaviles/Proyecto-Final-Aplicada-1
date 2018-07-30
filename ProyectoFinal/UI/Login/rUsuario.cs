using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Login
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }
        private void Vaciar()
        {
            UsuarioIdNumericUpDown.Text = string.Empty;
            UsuariotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            ConfirmartextBox.Clear();
            ComentariotextBox.Clear();
            LimpiarError();
        }
        private void LimpiarError()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
        }
        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();
            if (UsuarioIdNumericUpDown.Text == string.Empty)
            {

                usuario.IdUsuario = 0;
            }
            {
                usuario.IdUsuario = Convert.ToInt32(UsuarioIdNumericUpDown.Text);
            }

            usuario.NombreUsuario = UsuariotextBox.Text;
            usuario.Nombre = NombretextBox.Text;
            if (Validar(3) == 0)
            {
                usuario.Clave = ContraseñatextBox.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas son diferentes");
                usuario = null;
                return usuario;
            }
            usuario.Comentario = ComentariotextBox.Text;

            return usuario;
        }
        private int Validar(int error)
        {

            int paso = 0;
            List<Usuario> user = new List<Usuario>();
            if (error == 1 && UsuarioIdNumericUpDown.Value == 0)
            {

                errorProvider1.SetError(UsuarioIdNumericUpDown, "Llenar Campo!!");
                paso = 1;
                return paso;


            }
            if (error == 2 && UsuariotextBox.Text == string.Empty)
            {
                errorProvider2.SetError(UsuariotextBox, "Llenar Campo!!");
                paso = 1;

            }
            if (error == 2 && NombretextBox.Text == string.Empty)
            {
                errorProvider3.SetError(NombretextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && ContraseñatextBox.Text == string.Empty)
            {
                errorProvider4.SetError(ContraseñatextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && ConfirmartextBox.Text == string.Empty)
            {
                errorProvider4.SetError(ConfirmartextBox, "Llenar Campo!!");
                paso = 1;
            }

            if (error == 3 && ContraseñatextBox.Text != ConfirmartextBox.Text)
            {
                errorProvider4.SetError(ConfirmartextBox, "Llenar Campo!!");
                errorProvider4.SetError(ContraseñatextBox, "Llenar Campo!!");
                paso = 1;
            }

            if (error == 4 && BLL.UsuarioBLL.GetList(t => t.NombreUsuario == UsuariotextBox.Text).Exists(t => t.NombreUsuario == UsuariotextBox.Text) && UsuarioIdNumericUpDown.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Debe de crear otro usuario!!");
                paso = 1;
            }
            return paso;
        }
            private void rUsuario_Load(object sender, EventArgs e)
        {

        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (Validar(1) == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }

            if (BLL.UsuarioBLL.Eliminar(Convert.ToInt32(UsuarioIdNumericUpDown.Text)))
            {
                MessageBox.Show("Eliminado");
                Vaciar();
            }
            else
            {
                MessageBox.Show("No se pudo elimianar");
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            LimpiarError();

            if (Validar(1)==1)
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario usuario = BLL.UsuarioBLL.Buscar(id);

            if (usuario != null)
            {

                NombretextBox.Text = usuario.Nombre;
                UsuariotextBox.Text = usuario.NombreUsuario;
                ContraseñatextBox.SelectedText = usuario.Clave;
                ConfirmartextBox.SelectedText = usuario.Clave;
                ComentariotextBox.SelectedText = usuario.Comentario;
             }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2)==2)
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider1.Clear();


            if (UsuarioIdNumericUpDown.Value == 0)
                paso = BLL.UsuarioBLL.Guardar(LlenaClase());
            else
                paso = BLL.UsuarioBLL.Modificar(LlenaClase());


            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }
    }
    }


