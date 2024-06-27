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

namespace InterfazTecnico
{
    public partial class RegistrarTecnico : Form
    {
        static string conexiondb = "server=localhost;database=Fixify;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexiondb);

        public RegistrarTecnico()
        {
            InitializeComponent();
        }

        private void RegistrarTecnicos(string apellido, string nombre, string dni, string usuario, string contraseña)
        {
            string query = "INSERT INTO Tecnicos (NombreCompleto, DNI, Usuario, Contraseña) VALUES (@NombreCompleto, @DNI, @Usuario, @Contraseña)";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la interfaz actual.

            IniciarSesion inicio = new IniciarSesion(); // Crea un objeto a partir de la instancia AgregarReparación.
            inicio.Show(); // Muestra el formulario AgregarReparación
        }

        private void RegistrarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string apellidoynombre = txtNombreCompleto.Text;
                string dni = txtDNI.Text;
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                RegistrarTecnicos(apellidoynombre, dni, usuario, contraseña);
                MessageBox.Show("Técnico registrado exitosamente");

        }
    }
}
