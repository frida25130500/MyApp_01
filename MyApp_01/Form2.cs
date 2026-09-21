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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
            txtNombre = nombre;
            txtCorreo = correo;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
