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
    public partial class CPB : Form
    {
        string cadena = "";
        int número, dígito = 0, n;
        double aux, aux2;

        public CPB()
        {
            InitializeComponent();
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            pMenú.Visible = true;
        }

        private void btnCerrarMen_Click(object sender, EventArgs e)
        {
            pMenú.Visible = false;
        }

        private void lstOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOpciones.SelectedIndex == 5)
            {
                Application.Exit();
            }
            else if (lstOpciones.SelectedIndex == 0)
            {
                Form Estándar = new CE();
                Estándar.Show();
                this.Hide();
            }
            else if (lstOpciones.SelectedIndex == 1)
            {
                Form Programador = new CPB();
                Programador.Show();
                this.Hide();
            }
            else if (lstOpciones.SelectedIndex == 2)
            {
                Form Programador = new CPD();
                Programador.Show();
                this.Hide();
            }
            else if (lstOpciones.SelectedIndex == 4)
            {
                Form Bienvenida = new Bienvenida();
                Bienvenida.Show();
                this.Hide();
            }
            else if (lstOpciones.SelectedIndex == 3)
            {
                Form BatallaNaval = new BN();
                BatallaNaval.Show();
                this.Hide();
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            n = 0;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            n = 1;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            número = Convert.ToInt32(txtRes.Text);
            aux = 0;
            aux2 = 0;
            while ((int)(número / 10) != 0)
            {
                dígito = (int)número % 10;
                aux2 = aux2 + dígito * Math.Pow(2, aux);
                aux++;
                número = (int)(número / 10);
            }
            aux2 += número * Math.Pow(2, aux);
            txtRes.Text = $"{aux2}";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "")
            {
                MessageBox.Show("Por favor, intruduzca números.");
            }
            else
            {
                cadena = cadena.Remove(cadena.Length - 1);
                txtRes.Text = cadena;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
            cadena = "";
        }

    }
}
