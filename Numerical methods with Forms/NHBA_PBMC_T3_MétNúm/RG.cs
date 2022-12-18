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
    public partial class RG : Form
    {
        double h;
        double y0 = 0;
        double t = 0;
        double n = 0;
        double k1 = 0;
        double k2 = 0;
        double k3 = 0;
        double k4 = 0;

        public RG()
        {
            InitializeComponent();
            txtYprima.Enabled = false;
            txtY1.Enabled = false;
            txtYprima.Text = "x-y";
        }

        public static double f(double t, double y0)
        {
            return y0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            h = Convert.ToDouble(txtH.Text);
            y0 = Convert.ToDouble(txtY0.Text);
            n = y0 / h;


            lstIteraciones.Items.Add("t\tExacto");
            for (int i = 0; i <= n; i++)
            {
                k1 = t - y0;
                k2 = ((t + (h / 2)) - (y0 + (h / 2) * k1));
                k3 = ((t + (h / 2)) - (y0 + (h / 2) * k2));
                k4 = ((t + h) - (y0 + h * (k3)));

                y0 = y0 + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                t = t + h;
                chart1.Series["y'"].Points.Add(y0);
                lstIteraciones.Items.Add($"{t}\t{Math.Round(y0,4)}");

            }
            txtY1.Text = "" + y0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtH.Text = "";
            txtY0.Text = "";
            txtY1.Text = "";
            txtYprima.Text = "x-y";
            lstIteraciones.Items.Clear();
            chart1.Series["y'"].Points.Clear();
            t = 0;
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
