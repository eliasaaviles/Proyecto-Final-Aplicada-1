using ProyectoFinal.UI.Login;
using ProyectoFinal.UI.Registro;
using ProyectoFinal.UI.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void hermanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rHermano abrir = new rHermano();
            abrir.Show();
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rResponsable abrir = new rResponsable();
            abrir.Show();
        }

        private void lecturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLectura abrir = new rLectura();
            abrir.Show();
        }

        private void cantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCantos abrir = new rCantos();
            abrir.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario abrir = new rUsuario();
            abrir.Show();
        }

        private void hermanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cHermanos abrir = new cHermanos();
            abrir.Show();
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cResponsables abrir = new cResponsables();
            abrir.Show();
        }

        private void lecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLecturas abrir = new cLecturas();
            abrir.Show();
        }

        private void cantosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCantos abrir = new cCantos();
            abrir.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rUsuario abrir = new rUsuario();
            abrir.Show();
        }
    }
}
