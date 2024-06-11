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
    public partial class ModificarReparacion : Form
    {
        public ModificarReparacion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar la vista de la interfaz para el usuario.

            AgregarReparacion agregarReparacion = new AgregarReparacion(); // Objeto creado a partir de la instancia AgregarReparación.
            agregarReparacion.Show(); // Mostrar la interfaz AgregarReparación.
        }
    }
}
