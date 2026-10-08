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
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.Show();
        }
    }
}
