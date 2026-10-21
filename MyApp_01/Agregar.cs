using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        bool updateMode = false;
        int id;
        public Agregar()
        {
            InitializeComponent();
        }
        public Agregar (string nombre, string paterno, string materno, string telefono, string correo,int id)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = materno;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            updateMode = true;
            btnAgregar.Text = "Actualiza";
            this.id = id;
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
            if (updateMode == false)
            {
                bool f = datos.ejecutar("Insert Into Datos(Nombre,Paterno,Materno," +
                "Telefono,Correo)Values('"
                + txtNombre.Text + "','" + txtPaterno.Text + "','" + txtMaterno.Text
                + "','" + txtTelefono.Text + "','" + txtCorreo.Text + "')");
                if (f)
                {
                    MessageBox.Show("Registro agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro");
                }
            }
            else
            {
                SqlCommand comando = new SqlCommand("Update Datos Set Nombre=@Nombre," +
                    "Paterno=@Paterno,Materno=@Materno,Telefono=@Telefono," +
                    "Correo=@Correo Where Id=@Id");
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Paterno", txtPaterno.Text);
                comando.Parameters.AddWithValue("@Materno", txtMaterno.Text);
                comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                bool f = datos.ejecutar(comando);
                if (f)
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro");
                }
            }
        }
        

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
