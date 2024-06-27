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
using System.Xml.Schema;

namespace InterfazTecnico
{
    public partial class IniciarSesion : Form
    {
        static string conexiondb = "server = localhost; database = Fixify; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerramos completamente la aplicación.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Ocultamos la vista, para que el usuario solo interactue con la nueva interfaz.

            RegistrarTecnico newForm = new RegistrarTecnico(); // Creando un objeto a partir del formulario
            newForm.Show();// Mostrar el nuevo formulario
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
            this.Hide(); // Ocultamos el formulario actual de la vista del usuario.

            AgregarReparacion newForm = new AgregarReparacion(); // Creación de un objeto a partir del formulario AgregarReparación.
            newForm.Show(); // Muestra el formulario Agregar Reparación.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos esta interfaz, para que el usuario solo interactue con la nueva.

            ClienteConsultaReparacion clienteSesion = new ClienteConsultaReparacion(); // Creación de un objeto a partir del formulario "ClienteConsultaReparacion".
            clienteSesion.Show(); // Abre la vista del formulario ClienteConsultaReparación.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
