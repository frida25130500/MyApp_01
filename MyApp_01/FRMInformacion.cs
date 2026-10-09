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
    public partial class FRMInformacion : Form
    {
        Datos datos;
        public FRMInformacion()
        {
            InitializeComponent();
        }

        private void FRMInformacion_Load(object sender, EventArgs e)
        {
           datos = new Datos();
            DataSet ds = datos.Informacion("Select * from Datos");
                if (ds!=null)
            {
                dgvInformacion.DataSource= ds.Tables[0];

            }
            else
            {
                MessageBox.Show("Error al cargar informacion", "sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
