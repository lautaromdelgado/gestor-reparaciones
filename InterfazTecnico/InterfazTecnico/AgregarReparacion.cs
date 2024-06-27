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
    public partial class AgregarReparacion : Form
    {
        static string conexiondb = "server=localhost;database=Fixify;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public AgregarReparacion()
        {
            InitializeComponent();
        }


        private void AgregarReparaciones(int clienteId, int tecnicoId, string equipo, string tipoReparacion, decimal monto, string token)
        {
            string query = "INSERT INTO Reparaciones (ClienteId, TecnicoId, Equipo, TipoReparacion, Monto, Token) VALUES (@ClienteId, @TecnicoId, @Equipo, @TipoReparacion, @Monto, @Token)";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@ClienteId", clienteId);
                command.Parameters.AddWithValue("@TecnicoId", tecnicoId);
                command.Parameters.AddWithValue("@Equipo", equipo);
                command.Parameters.AddWithValue("@TipoReparacion", tipoReparacion);
                command.Parameters.AddWithValue("@Monto", monto);
                command.Parameters.AddWithValue("@Token", token);

                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar interfaz de la vista.

            IniciarSesion iniciarSesion = new IniciarSesion(); // Creación de un objeto, a partir de la instancia AgregarReparación.
            iniciarSesion.Show(); // Abrir el formulario AgregarReparación.
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar interfaz actual.

            ModificarReparacion modificarReparacion = new ModificarReparacion(); // Creación de un objeto, a partir de la instacia ModificarReparación.
            modificarReparacion.Show(); // Mostrar la interfaz ModificarReparación.
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la interfaz para el usuario.

            EliminarReparacion newForm = new EliminarReparacion(); // Creación del objeto a partir de la instancia EliminarReparación
            newForm.Show(); // Mostrar la interfaz EliminarReparación.
        }

        private void AgregarReparacion_Load(object sender, EventArgs e)
        {

        }
    }
}
