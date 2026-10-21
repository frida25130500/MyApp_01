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
            ActualizarGrid();
        }
        private void ActualizarGrid()
        {
            datos = new Datos();

            DataSet ds = datos.Informacion("Select * from datos");
            if (ds != null)
            {


                dgvInformacion.AutoGenerateColumns = false;

                dgvInformacion.Columns[0].DataPropertyName = "Id";
                dgvInformacion.Columns[1].DataPropertyName = "Nombre";
                dgvInformacion.Columns[2].DataPropertyName = "Paterno";
                dgvInformacion.Columns[3].DataPropertyName = "Materno";
                dgvInformacion.Columns[4].DataPropertyName = "Telefono";
                dgvInformacion.Columns[5].DataPropertyName = "Correo";

                dgvInformacion.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No se pudo obtener la informacion de la base de datos");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar frm = new Agregar();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRMInformacion_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
