using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using System.IO;


namespace MyApp_01
{
    public partial class Form1 : Form
    {
        List <Persona> registros = new List<Persona> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {

                var reader = new StreamReader(ofdCSV.FileName);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                registros = csv.GetRecords <Persona>().ToList();

                //tarea
                csv.Dispose();
                reader.Close();
                foreach (var registro in registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email);
                }

            }
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 editar = new Form2(
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString()
            );
            if (editar.ShowDialog() == DialogResult.OK)
            {
                string nombre = editar.ActualizaNombre;
                string correo = editar.ActualizaCorreo;
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;
                //tarea
                registros[e.RowIndex].name = nombre;   
                registros[e.RowIndex].email = correo;

                //tarea
                var writer = new StreamWriter(ofdCSV.FileName);
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

                // tarea
                csv.WriteRecords(registros);

                csv.Dispose();
                writer.Close();
            }
        }
    }
}
