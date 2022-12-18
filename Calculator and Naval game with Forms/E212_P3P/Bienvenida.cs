using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E212_P3P
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void tsmSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmCE(object sender, EventArgs e)
        {
            Form Estándar = new CE();
            Estándar.Show();
            this.Hide();
        }

        private void tsmCPB(object sender, EventArgs e)
        {
            Form Programador = new CPB();
            Programador.Show();
            this.Hide();
        }

        private void tsmCPD(object sender, EventArgs e)
        {
            Form Programador = new CPD();
            Programador.Show();
            this.Hide();
        }

        private void tsmBN(object sender, EventArgs e)
        {
            Form BatallaNaval = new BN();
            BatallaNaval.Show();
            this.Hide();
        }

      
    }
}
