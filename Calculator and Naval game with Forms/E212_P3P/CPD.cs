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
    public partial class CPD : Form
    {
        string cadena = "";
        int n;
        int número;
        double resBinario = 0;
        string res = "", cadena2 = "";

        public CPD()
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

        private void btnIgual_Click(object sender, EventArgs e)
        {
            número = Convert.ToInt32(txtRes.Text);
            for (int i = 0; número > 0; i++)
            {
                resBinario = número % 2;
                res += resBinario;
                número /= 2;
            }
            foreach (char n in res)
            {
                cadena2 += n;
            }
            txtRes.Text = cadena2;
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

        private void btnDos_Click(object sender, EventArgs e)
        {
            n = 2;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            n = 3;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            n = 4;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            n = 5;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            n = 6;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            n = 7;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            n = 8;
            cadena += n;
            txtRes.Text = $"{cadena}";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            n = 9;
            cadena += n;
            txtRes.Text = $"{cadena}";
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

        private void btnSigno_Click(object sender, EventArgs e)
        {
            número *= -1;
        }
    }
}
