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
    public partial class BS : Form
    {
        double Xi;
        double Xd;
        double iteraciones;
        double xm;
        int a;
        int b;
        int c;
        int d;

        public BS()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstXm.Items.Add("Sustitución de f(x)");
            for (int i = 0; i < iteraciones; i++)
            {
                xm = ((Xi + Xd) / (2));
                xm = Math.Round(xm, 4);

                if (((a * xm * xm * xm) + (b * xm * xm) + (c * xm) + (d)) < 0)
                {
                    Xi = xm;
                }
                else
                {
                    Xd = xm;
                }
                chart1.Series["f(xm)"].Points.Add(xm);
                lstXm.Items.Add(xm);
            }
            MessageBox.Show($"La raíz es: {xm}", "Respuesta de convergencia");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);
            d = Convert.ToInt32(txtD.Text);

            lblFunción.Text = $"f(x) = {a}x^3 + {b}x^2 + {c}x + {d}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Xi = Convert.ToDouble(txtXi.Text);
            Xd = Convert.ToDouble(txtXd.Text);

            iteraciones = ((Math.Log(Xd - Xi)) - (Math.Log(0.001))) / (Math.Log(2));
            iteraciones = Math.Round(iteraciones);

            lblIteraciones.Text = $"{iteraciones} iteraciones";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtXd.Text = "";
            txtXi.Text = "";
            lblIteraciones.Text = "...";
            lblFunción.Text = "ax^3 + bx^2 + cx + d = 0";
            lstXm.Items.Clear();
            chart1.Series["f(xm)"].Points.Clear();
        }

        private void newtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NR = new NR();
            NR.Show();
            this.Hide();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
