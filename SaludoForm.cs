using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm
    {
        public SaludoForm()
        {
            InitializeComponent();
        }
        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            MessageBox.Show("Hola, " + nombre);

            contar += 1;
            lbNombre.Text = "Ingresa tu nombre\nContador: " + contar.ToString();
        }
        internal void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNombre.Text = " ";
        }
    }
}
