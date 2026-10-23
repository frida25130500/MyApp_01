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
        List<Estado> estados = new List<Estado>();
        List<Municipio> municipios = new List<Municipio>();

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

                // leer encabezado para saber si es estados o municipios
                csv.Read();
                csv.ReadHeader();
                bool esMunicipios = csv.HeaderRecord.Contains("id_estado");

                dgvRegistros.Rows.Clear();
                dgvRegistros.Columns.Clear();
                dgvRegistros.AllowUserToAddRows = false;

                if (esMunicipios)
                {
                    municipios = csv.GetRecords<Municipio>().ToList();

                    csv.Dispose();
                    reader.Close();

                    dgvRegistros.Columns.Add("id", "ID");
                    dgvRegistros.Columns.Add("nombre", "Municipio");
                    dgvRegistros.Columns.Add("id_estado", "ID Estado");

                    foreach (var registro in municipios)
                    {
                        dgvRegistros.Rows.Add(registro.id, registro.nombre, registro.id_estado);
                    }
                }
                else
                {
                    estados = csv.GetRecords<Estado>().ToList();

                    csv.Dispose();
                    reader.Close();

                    dgvRegistros.Columns.Add("id", "ID");
                    dgvRegistros.Columns.Add("nombre", "Estado");

                    foreach (var registro in estados)
                    {
                        dgvRegistros.Rows.Add(registro.id, registro.nombre);
                    }
                }

                dgvRegistros.AutoResizeColumns();
            }
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
