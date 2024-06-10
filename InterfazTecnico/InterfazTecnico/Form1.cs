using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfazTecnico
{
    public partial class Form1 : Form
    {
        static string conexiondb = "server = localhost; database = Fixify; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del nuevo formulario
            RegistrarTecnico newForm = new RegistrarTecnico();
            // Mostrar el nuevo formulario
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarReparacion newForm = new AgregarReparacion();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form clienteSesion = new ClienteConsultaReparacion();
            clienteSesion.Show();
        }
    }
}
