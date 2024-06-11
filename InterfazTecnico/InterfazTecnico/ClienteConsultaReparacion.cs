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
    public partial class ClienteConsultaReparacion : Form
    {
        public ClienteConsultaReparacion()
        {
            InitializeComponent();
        }

        private void btnClienteSalir_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos este interfaz para la vista del usuario.

            IniciarSesion inicio = new IniciarSesion(); // Creación de un objeto para el formulario "IniciarSesion".
            inicio.Show(); // Mostramos la interfaz "Inicio".
        }

        private void btnClienteIngresar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Para cerrar el formulario.

            DetallesReparacion Detalles = new DetallesReparacion(); // Creación de un objeto, a partir del formulario "Detalles Reparación".
            Detalles.ShowDialog(); // Abre el formulario y bloqueando la interacción con los demás formularios.
        }
    }
}
