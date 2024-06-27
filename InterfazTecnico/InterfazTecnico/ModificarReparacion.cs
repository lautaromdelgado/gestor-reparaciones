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

    public partial class ModificarReparacion : Form
    {
        static string conexiondb = "server=localhost;database=Fixify;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public ModificarReparacion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarReparacion_Load(object sender, EventArgs e)
        {

        }

        private void ModificarReparaciones(int reparacionId, string nuevoEquipo, string nuevoTipoReparacion, decimal nuevoMonto)
        {
            string query = "UPDATE Reparaciones SET Equipo = @NuevoEquipo, TipoReparacion = @NuevoTipoReparacion, Monto = @NuevoMonto WHERE ReparacionId = @ReparacionId";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@NuevoEquipo", nuevoEquipo);
                command.Parameters.AddWithValue("@NuevoTipoReparacion", nuevoTipoReparacion);
                command.Parameters.AddWithValue("@NuevoMonto", nuevoMonto);
                command.Parameters.AddWithValue("@ReparacionId", reparacionId);

                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
        }



    }
}
