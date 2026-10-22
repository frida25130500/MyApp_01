using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            Agregar actualizar = new Agregar(dgvInformacion.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dgvInformacion.Rows[e.RowIndex].Cells[5].Value.ToString(),
                Convert.ToInt32(dgvInformacion.Rows[e.RowIndex].Cells[0].Value));
            actualizar.Show();
        }

        private void FRMInformacion_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvInformacion.CurrentRow;

            Agregar actualizar = new Agregar(
                fila.Cells[1].Value.ToString(),
                fila.Cells[2].Value.ToString(),
                fila.Cells[3].Value.ToString(),
                fila.Cells[4].Value.ToString(),
                fila.Cells[5].Value.ToString(),
                Convert.ToInt32(fila.Cells[0].Value));
            actualizar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvInformacion.CurrentRow;

            DialogResult r = MessageBox.Show(
                "¿Seguro que deseas eliminar este contacto?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                datos = new Datos();
                SqlCommand comando = new SqlCommand("Delete From Datos Where Id=@Id");
                comando.Parameters.AddWithValue("@Id", Convert.ToInt32(fila.Cells[0].Value));

                if (datos.ejecutar(comando))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    ActualizarGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro");
                }
            }
        }

        private void dgvInformacion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInformacion.ClearSelection();
                dgvInformacion.Rows[e.RowIndex].Selected = true;
                dgvInformacion.CurrentCell = dgvInformacion.Rows[e.RowIndex].Cells[1];
            }
        }

        private void dgvInformacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformacion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
