using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrasesDeAmorApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string contraseña = TBPass.Text;

            // Puedes cambiar estos valores según prefieras
            if (usuario == "novia" && contraseña == "amor123")
            {
                this.Hide();  // Ocultamos la ventana de login
                VentanaPrincipal principal = new VentanaPrincipal();
                principal.Show();
            }
            else
            {
                lblerror.Text = "Usuario o contraseña incorrectos.";
                lblerror.Visible = true;
            }
        }
    }
}
