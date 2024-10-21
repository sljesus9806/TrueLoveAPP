using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FrasesDeAmorApp
{
    public partial class VentanaPrincipal : Form
    {
        private SQLiteConnection conexion;

        public VentanaPrincipal()
        {
            InitializeComponent();
            conexion = new SQLiteConnection("Data Source=frases.db;Version=3;");

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
