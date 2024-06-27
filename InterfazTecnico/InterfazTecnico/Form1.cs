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


        private bool IniciarSesion(string usuario, string contraseña)
        {
            string query = "SELECT COUNT(*) FROM Tecnicos WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                conexion.Open();
                int count = (int)command.ExecuteScalar();
                conexion.Close();

                return count > 0;
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
