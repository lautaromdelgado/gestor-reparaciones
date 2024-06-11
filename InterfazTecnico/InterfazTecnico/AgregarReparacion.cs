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
    public partial class AgregarReparacion : Form
    {
        public AgregarReparacion()
        {
            InitializeComponent();
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
    }
}
