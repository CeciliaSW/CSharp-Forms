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
    public partial class CE : Form
    {
        string operación;
        double resultado, primero, segundo;

        public CE()
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
            else if(lstOpciones.SelectedIndex == 3)
            {
                Form BatallaNaval = new BN();
                BatallaNaval.Show();
                this.Hide();
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "9";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "6";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "3";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtRes.Text);

            switch (operación)
            {
                case "+":
                    resultado = primero + segundo;
                    txtRes.Text = resultado.ToString();
                    break;
                case "–":
                    resultado = primero - segundo;
                    txtRes.Text = resultado.ToString();
                    break;
                case "X":
                    resultado = primero * segundo;
                    txtRes.Text = resultado.ToString();
                    break;
                case "÷":
                    if (txtRes.Text != "0") {
                        resultado = primero / segundo;
                        txtRes.Text = resultado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                    }
                    break;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operación = "+";
            primero = double.Parse(txtRes.Text);
            txtRes.Clear();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operación = "–";
            primero = double.Parse(txtRes.Text);
            txtRes.Clear();
        }

        private void btnRaíz_Click_1(object sender, EventArgs e)
        {
            operación = "²√";
            primero = double.Parse(txtRes.Text);
            resultado = primero;
            txtRes.Text = Math.Sqrt(primero).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operación = "X";
            primero = double.Parse(txtRes.Text);
            txtRes.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operación = "÷";
            primero = double.Parse(txtRes.Text);
            txtRes.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtRes.Text = String.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtRes.Clear();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + ".";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            primero = Convert.ToDouble(txtRes.Text);
            primero *= -1;
            txtRes.Text = primero.ToString();
        }
    }
}
