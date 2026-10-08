using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp_01
{
    public partial class Agregar : Form
    {
        Datos datos;

        public Agregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos = new Datos();
            bool f= datos.Insertar(txtNombre.Text, txtPaterno.Text,txtMaterno.Text,txtTelefono.Text,txtCorreo.Text);

            if (f)
            {
                MessageBox.Show("Registro agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error a agregar el registro");

            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
