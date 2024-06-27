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
    public partial class EliminarReparacion : Form
    {
        static string conexiondb = "server=localhost;database=Fixify;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public EliminarReparacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la interfaz actual.

            AgregarReparacion agregarReparacion = new AgregarReparacion(); // Crea un objeto a partir de la instancia AgregarReparación.
            agregarReparacion.Show(); // Abre el formulario del objeto agregarReparación.
        }

        private void btnEliminarAtrasbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar interfaz actual.

            AgregarReparacion agregarReparacion = new AgregarReparacion(); // Crear un objeto a partir de la instacia AgregarReparación.
            agregarReparacion.Show(); // Mostrar el formulario del objeto creado anteriormente.
        }

        private void EliminarReparacion_Load(object sender, EventArgs e)
        {

        }

        private void EliminarReparacionPorID(int reparacionId)
        {
            string query = "DELETE FROM Reparaciones WHERE ReparacionId = @ReparacionId";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@ReparacionId", reparacionId);

                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reparacionId = int.Parse(txtReparacionId.Text);
            EliminarReparacionPorId(reparacionId);
            MessageBox.Show("Reparación eliminada exitosamente");
        }
    }
}
