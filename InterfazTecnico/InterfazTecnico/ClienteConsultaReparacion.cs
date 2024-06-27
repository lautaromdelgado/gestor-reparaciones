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
    public partial class ClienteConsultaReparacion : Form
    {
        static string conexiondb = "server=localhost;database=Fixify;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexiondb);
        public ClienteConsultaReparacion()
        {
            InitializeComponent();
        }

        private void btnClienteSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClienteIngresar_Click(object sender, EventArgs e)
        {
            Form Detalles = new DetallesReparacion();
            Detalles.ShowDialog(); // Abre el formulario y bloqueando la interacción con los demás formularios.
        }

        private void ClienteConsultaReparacion_Load(object sender, EventArgs e)
        {

        }
    }
}
