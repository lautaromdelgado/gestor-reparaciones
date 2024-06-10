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
            this.Close();
        }
    }
}
