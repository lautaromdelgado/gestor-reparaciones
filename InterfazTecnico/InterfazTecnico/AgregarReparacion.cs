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
            this.Close();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarReparacion newForm = new ModificarReparacion();
            newForm.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarReparacion newForm = new EliminarReparacion();
            newForm.Show();
        }
    }
}
