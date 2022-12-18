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
    public partial class LG : Form
    {
        double[] xi;
        double[] fx;
        int n;
        double suma;
        double producto;
        double x;

        double vx1;
        double vx2;
        double vx3;
        double vx4;

        double vy1;
        double vy2;
        double vy3;
        double vy4;

        double sum1;
        double sum2;
        double sum3;
        double sum4;

        public LG()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Puntos en X
            vx1 = Convert.ToDouble(txtVx1.Text);
            vx2 = Convert.ToDouble(txtVx2.Text);
            vx3 = Convert.ToDouble(txtVx3.Text);
            vx4 = Convert.ToDouble(txtVx4.Text);

            //Puntos en Y
            vy1 = Convert.ToDouble(txtVy1.Text);
            vy2 = Convert.ToDouble(txtVy2.Text);
            vy3 = Convert.ToDouble(txtVy3.Text);
            vy4 = Convert.ToDouble(txtVy4.Text);

            double dk1, dk2, dk3, dk4;

            dk1 = (vx1 - vx2) * (vx1 - vx3) * (vx1 - vx4);
            dk2 = (vx2 - vx1) * (vx2 - vx3) * (vx2 - vx4);
            dk3 = (vx3 - vx1) * (vx3 - vx2) * (vx3 - vx4);
            dk4 = (vx4 - vx1) * (vx4 - vx2) * (vx4 - vx3);

            //Cálculo ax3
            double ax01 = vy1 / dk1;
            double ax02 = vy2 / dk2;
            double ax03 = vy3 / dk3;
            double ax04 = vy4 / dk4;

            //Cálculo bx2
            double bx01 = +-(vy1 / dk1) * (vx2 + vx3 + vx4);
            double bx02 = +-(vy2 / dk2) * (vx1 + vx3 + vx4);
            double bx03 = +-(vy3 / dk3) * (vx1 + vx2 + vx4);
            double bx04 = +-(vy4 / dk4) * (vx1 + vx2 + vx3);

            //Cálculo CX
            double cx01 = (ax01) * (vx2 * vx3 + vx2 * vx4 + vx3 * vx4);
            double cx02 = (ax02) * (vx1 * vx3 + vx1 * vx4 + vx3 * vx4);
            double cx03 = (ax03) * (vx1 * vx2 + vx1 * vx4 + vx2 * vx4);
            double cx04 = (ax04) * (vx1 * vx2 + vx1 * vx3 + vx2 * vx3);

            //Cálculo d
            double d01 = +-(ax01 * vx2 * vx3 * vx4);
            double d02 = +-(ax02 * vx1 * vx3 * vx4);
            double d03 = +-(ax03 * vx1 * vx2 * vx4);
            double d04 = +-(ax04 * vx1 * vx2 * vx3);

            //Cálculo sumatoria
            sum1 = ax01 + ax02 + ax03 + ax04;
            sum2 = bx01 + bx02 + bx03 + bx04;
            sum3 = cx01 + cx02 + cx03 + cx04;
            sum4 = d01 + d02 + d03 + d04;

            txtResultado.Text = $"{Math.Round(sum1, 4)} x^3 + {Math.Round(sum2, 4)} x^2 + {Math.Round(sum3, 4)} x + {Math.Round(sum4, 4)}";
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            n = 4;

            xi = new double[20];
            fx = new double[20];

            xi[0] = vx1;
            xi[1] = vx2;
            xi[2] = vx3;
            xi[3] = vx4;

            fx[0] = vy1;
            fx[1] = vy2;
            fx[2] = vy3;
            fx[3] = vy4;

            suma = 0;
            x = Convert.ToDouble(txtValorX.Text);
            for (int i = 0; i < n; i++)
            {
                chart1.Series["P(x)"].Points.Add(fx[i]);
            }

            for (int i = 0; i < 21; i++)
            {
                chart2.Series[0].Points.AddXY(x, (sum1 * Math.Pow(x, 3) + sum2 * Math.Pow(x, 2) + sum3 * x + sum4));
                x = x + 0.5;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVx1.Text = "";
            txtVx2.Text = "";
            txtVx3.Text = "";
            txtVx4.Text = "";
            txtVy1.Text = "";
            txtVy2.Text = "";
            txtVy3.Text = "";
            txtVy4.Text = "";

            txtValorX.Text = "";
            txtResultado.Text = "";

            chart1.Series["P(x)"].Points.Clear();
            chart2.Series["P(x)"].Points.Clear();
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
