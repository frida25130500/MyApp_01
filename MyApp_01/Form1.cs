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
        DateTime tiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToLongTimeString() == tiempo.ToLongTimeString())
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\zvero\Music\Gallo.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void configurarAlarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigurar ventanaAlarma = new frmConfigurar();

            if (ventanaAlarma.ShowDialog() == DialogResult.OK)
            {
                tiempo = ventanaAlarma.hora;
                MessageBox.Show(tiempo.ToLongTimeString());
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
