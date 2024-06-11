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
    public partial class EliminarReparacion : Form
    {
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
    }
}
