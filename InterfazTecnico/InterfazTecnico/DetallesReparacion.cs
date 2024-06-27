using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazTecnico
{
    public partial class DetallesReparacion : Form
    {
        public DetallesReparacion()
        {
            InitializeComponent();
        }

        private void btnDetalleSalir_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la vista de la interfaz actual.

            ClienteConsultaReparacion consultaReparacion = new ClienteConsultaReparacion(); // Creación del objeto a partir del formulario Cliente Consulta Reparación.
            consultaReparacion.Show(); // Abrir la interfaz de Consultas de Reparación.
        }
    }
}
