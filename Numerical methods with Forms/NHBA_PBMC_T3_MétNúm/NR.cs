using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHBA_PBMC_T3_MétNúm
{
    public partial class NR : Form
    {
        double xi, xiS, xiT, a, b, a1, b1, c1, a2, b2, c2, d2, Gx, GxS, GxT;

        public NR()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            lblFunción.Text = $"f(x) = {a}x + {b}";
        }

        private void btnInsertarS_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(txtAS.Text);
            b1 = Convert.ToDouble(txtBS.Text);
            c1 = Convert.ToDouble(txtCS.Text);

            lblFunciónS.Text = $"f(x) = {a1}x^2 + {b1}x + {c1}";
        }

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            a2 = Convert.ToDouble(txtAT.Text);
            b2 = Convert.ToDouble(txtBT.Text);
            c2 = Convert.ToDouble(txtCT.Text);
            d2 = Convert.ToDouble(txtDT.Text);

            lblFunciónT.Text = $"f(x) = {a2}x^3 + {b2}x^2 + {c2}x + {d2}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "Registrado.";
        }

        private void btnOkS_Click(object sender, EventArgs e)
        {
            lblMsjS.Text = "Registrado.";
        }

        private void btnOkT_Click(object sender, EventArgs e)
        {
            lblMsjT.Text = "Registrado.";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            xi = Convert.ToDouble(txtXi.Text);
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
           
            double Función1G(double a, double b, double x)
            {
                return a*x + b;
            }

            lstNR1G.Items.Add("i\tXi\tG(x)");
            for (int i = 0; i < 10; i++)
            {
                Gx = xi - (Función1G(a, b, xi) / a);
                xi = Gx;
                chGráf.Series["G(x)"].Points.Add(Gx);
                lstNR1G.Items.Add(i+1 + "\t" + Math.Round(xi,4) + "\t" + Math.Round(Gx,4));
            }
            MessageBox.Show($"La solución es: {Math.Round(xi,4)}", "Respuesta de convergencia");
        }

        private void btnCalcularS_Click(object sender, EventArgs e)
        {
            xiS = Convert.ToDouble(txtXiS.Text);
            a1 = Convert.ToDouble(txtAS.Text);
            b1 = Convert.ToDouble(txtBS.Text);
            c1 = Convert.ToDouble(txtCS.Text);

            double Función2G(double a, double b, double c, double x)
            {
                return a*(x*x)+b*x+c;
            }

            double Derivada2G(double a, double b)
            {
                return 2*a + b;
            }

            lstNR2G.Items.Add("i\tXi\tG(x)");
            for (int j = 0; j < 10; j++)
            {
                GxS = xiS - (Función2G(a1, b1, c1, xiS) / Derivada2G(a1, b1));
                xiS = GxS;
                crtGráfS.Series["G(x)"].Points.Add(GxS);
                lstNR2G.Items.Add(j + 1 + "\t" + Math.Round(xiS,4) + "\t" + Math.Round(GxS, 4));
            }
            MessageBox.Show($"La solución es: {Math.Round(xiS, 4)}", "Respuesta de convergencia");
        }

        private void btnCalcularT_Click(object sender, EventArgs e)
        {
            xiT = Convert.ToDouble(txtXiT.Text);
            a2 = Convert.ToDouble(txtAT.Text);
            b2 = Convert.ToDouble(txtBT.Text);
            c2 = Convert.ToDouble(txtCT.Text);
            d2 = Convert.ToDouble(txtDT.Text);

            double Función3G(double a, double b, double c, double d, double x)
            {
                return a*(x*x*x) + b*(x*x) + c*x + d;
            }

            double Derivada3G(double a, double b, double c)
            {
                return 3*(a*a)+2*b+c;
            }

            lstNR3G.Items.Add("i\tXi\tG(x)");
            for (int k = 0; k < 10; k++)
            {
                GxT = xiT - (Función3G(a2, b2, c2, d2, xiT) /Derivada3G(a2, b2, c2));
                xiT = GxT;
                chrGráfT.Series["G(x)"].Points.Add(GxT);
                lstNR3G.Items.Add(k + 1 + "\t" + Math.Round(xiT, 4) + "\t" + Math.Round(GxT, 4));
            }
            MessageBox.Show($"La solución es: {Math.Round(xiT, 4)}", "Respuesta de convergencia");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblFunción.Text = "ax + b = 0";
            txtXi.Text = "";
            lblMsj.Text = "...";
            chGráf.Series["G(x)"].Points.Clear();
            lstNR1G.Items.Clear();
        }

        private void btnReiniciarS_Click(object sender, EventArgs e)
        {
            txtAS.Text = "";
            txtBS.Text = "";
            txtCS.Text = "";
            lblFunciónS.Text = "ax^2 + bx + c = 0";
            txtXiS.Text = "";
            lblMsjS.Text = "...";
            crtGráfS.Series["G(x)"].Points.Clear();
            lstNR2G.Items.Clear();
        }

        private void btnReiniciarT_Click(object sender, EventArgs e)
        {
            txtAT.Text = "";
            txtBT.Text = "";
            txtCT.Text = "";
            txtDT.Text = "";
            lblFunciónT.Text = "ax^3 + bx^2 + cx + d = 0";
            txtXiT.Text = "";
            lblMsjT.Text = "...";
            chrGráfT.Series["G(x)"].Points.Clear();
            lstNR3G.Items.Clear();
        }

        private void mínimosCuadradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MC = new MC();
            MC.Show();
            this.Hide();
        }

        private void rungeKuttaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RG = new RG();
            RG.Show();
            this.Hide();
        }


        private void polinomiosLagrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LG = new LG();
            LG.Show();
            this.Hide();
        }

        private void bisecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BS = new BS();
            BS.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
