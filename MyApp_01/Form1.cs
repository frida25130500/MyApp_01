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
    public partial class Form1 : Form
    {
       List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Add();
            dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = dgvInformacion.Rows.Count;
            dgvInformacion[1, dgvInformacion.Rows.Count-1].Value = txtNombre.Text;
            dgvInformacion[2, dgvInformacion.Rows.Count-1].Value =mtbTelefono.Text;

            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar datos en tiempo de ejecución aquí para evitar que el Diseñador intente ejecutar
            // código que manipula controles o datos durante el diseño.
            personas.Add(new Persona(1, "Frida Sofia", "8711850019"));
            personas.Add(new Persona(2, "Isabella Flores", "8715424433"));
            personas.Add(new Persona(3, "Miguel Angel", "8744557142"));

            foreach (var Persona in personas)
            {
                dgvInformacion.Rows.Add();
                dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = Persona.Id;
                dgvInformacion[1, dgvInformacion.Rows.Count - 1].Value = Persona.nombre;
                dgvInformacion[2, dgvInformacion.Rows.Count - 1].Value = Persona.telefono;

            }
            
        }
    }
}
