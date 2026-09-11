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
    public partial class frmConfigurar : Form

    {
        public DateTime hora { get; set; }
        public frmConfigurar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            hora = dtpConfigura.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtpConfigura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmConfiguarar_Load(object sender, EventArgs e)
        {

        }
    }
}
