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
    public partial class MC : Form
    {
        string imp = "";
        int it = 0;
        double sumaXi = 0, sumaYi = 0, sumaXiAl2 = 0, sumaXiYi = 0, sumaXiAl3 = 0, sumaXiYiAl2 = 0, sumaXiAl4 = 0, sumaXiYiAl3 = 0, sumaXiAl5 = 0, sumaXiAl6 = 0, a01, a11, a02, a12, a22, a03, a13, a23, a33;
        double[] Xi;
        double[] Yi, XiAl2, XiYi, XiAl3, XiYiAl2, XiAl4, XiYiAl3, XiAl5, XiAl6;
        double[,] matrizAux1G, matrizAux2G;

        public static double[,] SolPol(double[,] matriz, int filas)
        {
            double aux, d;
            int o, p, q;
            for (o = 0; o < filas; o++)
            {
                aux = matriz[o, o];
                for (p = o; p < filas + 1; p++)
                {
                    matriz[o, p] = matriz[o, p] / aux;
                }
                for (q = 0; q < filas; q++)
                {
                    if (q != o)
                    {
                        d = matriz[q, o];
                        for (p = o; p < filas + 1; p++)
                        {
                            matriz[q, p] = matriz[q, p] - d * matriz[o, p];
                        }
                    }
                }
            }
            return matriz;
        }

        public MC()
        {
            InitializeComponent();
        }

        private void btnLlenarXi_Click(object sender, EventArgs e)
        {
            it = Convert.ToInt32(txtIteraciones.Text);
            Xi = new double[it];
            for (int i = 0; i < it; i++) 
            {
                Xi[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Proporcione Xi de la iteración " + (i + 1) + ":"));
            }
        }

        private void btnLlenarYi_Click(object sender, EventArgs e)
        {
            it = Convert.ToInt32(txtIteraciones.Text);
            Yi = new double[it];
            for (int i2 = 0; i2 < it; i2++)
            {
                Yi[i2] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Proporcione Yi de la iteración " + (i2 + 1) + ":"));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            it = Convert.ToInt32(txtIteraciones.Text);
            XiAl2 = new double[it];
            XiYi = new double[it];
            XiAl3 = new double[it];
            XiYiAl2 = new double[it];
            XiAl4 = new double[it];
            XiYiAl3 = new double[it];
            XiAl5 = new double[it];
            XiAl6 = new double[it];

            if (rd1.Checked == true)
            {
                lstTabla.Items.Add("i\tXi\tYi\tXi^2\tXiYi\t");
                for (int j = 0; j < it; j++)
                {
                    imp = "";
                    XiAl2[j] = Xi[j] * Xi[j];
                    XiYi[j] = Xi[j] * Yi[j];
                    sumaXi += Xi[j];
                    sumaYi += Yi[j];
                    sumaXiAl2 += XiAl2[j];
                    sumaXiYi += XiYi[j];
                    imp += lstTabla.Items.Add(j + 1 + "\t" + Xi[j] + "\t" + Yi[j] + "\t" + XiAl2[j] + "\t" + XiYi[j] + "\t");
                }
                imp += lstTabla.Items.Add("Suma\t" + sumaXi + "\t" + sumaYi + "\t" + sumaXiAl2 + "\t" + sumaXiYi + "\t");

                a01 = ((sumaYi * sumaXiAl2) - (sumaXi * sumaXiYi)) / ((it * sumaXiAl2) - (sumaXi * sumaXi));
                a11 = (it * sumaXiYi - sumaYi * sumaXi) / ((it * sumaXiAl2) - (sumaXi * sumaXi));

                lblPol.Text = $"P(x) = {Math.Round(a01, 4)} + {Math.Round(a11, 4)}x";
                for (int j2 = 0; j2 < it; j2++)
                {
                    chGráf.Series["P(x)"].Points.AddXY(Xi[j2], a01 + a11 * Xi[j2]);
                    chGráf.Series["P(x)"].Points[j2].Label = $"{Math.Round(a01, 4) + Math.Round(a11 * Xi[j2], 4)}";
                }
            }
            else if (rd2.Checked == true)
            {
                lstTabla.Items.Add("i\tXi\tYi\tXi^2\tXiYi\tXi^3\tXiYi^2\tXi^4");
                for (int k = 0; k < it; k++)
                {
                    imp = "";
                    XiAl2[k] = Xi[k] * Xi[k];
                    XiYi[k] = Xi[k] * Yi[k];
                    XiAl3[k] = Xi[k] * Xi[k] * Xi[k];
                    XiYiAl2[k] = XiAl2[k] * Yi[k];
                    XiAl4[k] = Xi[k] * Xi[k] * Xi[k] * Xi[k];
                    sumaXi += Xi[k];
                    sumaYi += Yi[k];
                    sumaXiAl2 += XiAl2[k];
                    sumaXiYi += XiYi[k];
                    sumaXiAl3 += XiAl3[k];
                    sumaXiYiAl2 += XiYiAl2[k];
                    sumaXiAl4 += XiAl4[k];
                    imp += lstTabla.Items.Add(k + 1 + "\t" + Xi[k] + "\t" + Yi[k] + "\t" + XiAl2[k] + "\t" + XiYi[k] + "\t" + XiAl3[k] + "\t" + XiYiAl2[k] + "\t" + XiAl4[k]);
                }
                imp += lstTabla.Items.Add("Suma\t" + sumaXi + "\t" + sumaYi + "\t" + sumaXiAl2 + "\t" + sumaXiYi + "\t" + sumaXiAl3 + "\t" + sumaXiYiAl2 + "\t" + sumaXiAl4);

                double[,] matriz1G = {{it, sumaXi, sumaXiAl2, sumaYi}, {sumaXi, sumaXiAl2, sumaXiAl3, sumaXiYi}, {sumaXiAl2, sumaXiAl3, sumaXiAl4, sumaXiYiAl2}};
                matrizAux1G = new double[4,3];
                matrizAux1G = SolPol(matriz1G, 3);

                a02 = matrizAux1G[0,3];
                a12 = matrizAux1G[1,3];
                a22 = matrizAux1G[2,3];
                lblPol.Text = $"P(x) = {Math.Round(a02,4)} + {Math.Round(a12,4)}x + {Math.Round(a22,4)}x^2";
                for (int k2 = 0; k2 < it; k2++)
                {
                    chGráf.Series["P(x)"].Points.AddXY(Xi[k2], a02 + a12*Xi[k2] + a22*XiAl2[k2]);
                    chGráf.Series["P(x)"].Points[k2].Label = $"{Math.Round(a02, 4) + Math.Round(a12 * Xi[k2], 4) + Math.Round(a22 * XiAl2[k2])}";
                }
            }
            else if(rd3.Checked == true)
            {
                lstTabla.Items.Add("i\tXi\tYi\tXi^2\tXiYi\tXi^3\tXiYi^2\tXi^4\tXiYi^3\tXi^5\tXi^6");
                for (int l = 0; l < it; l++)
                {
                    imp = "";
                    XiAl2[l] = Xi[l] * Xi[l];
                    XiYi[l] = Xi[l] * Yi[l];
                    XiAl3[l] = Xi[l] * Xi[l] * Xi[l];
                    XiYiAl2[l] = XiAl2[l] * Yi[l];
                    XiAl4[l] = Xi[l] * Xi[l] * Xi[l] * Xi[l];
                    XiYiAl3[l] = XiAl3[l] * Yi[l];
                    XiAl5[l] = Xi[l] * Xi[l] * Xi[l] * Xi[l] * Xi[l];
                    XiAl6[l] = Xi[l] * Xi[l] * Xi[l] * Xi[l] * Xi[l] * Xi[l];
                    sumaXi += Xi[l];
                    sumaYi += Yi[l];
                    sumaXiAl2 += XiAl2[l];
                    sumaXiYi += XiYi[l];
                    sumaXiAl3 += XiAl3[l];
                    sumaXiYiAl2 += XiYiAl2[l];
                    sumaXiAl4 += XiAl4[l];
                    sumaXiYiAl3 += XiYiAl3[l];
                    sumaXiAl5 += XiAl5[l];
                    sumaXiAl6 += XiAl6[l];
                    imp += lstTabla.Items.Add(l + 1 + "\t" + Xi[l] + "\t" + Yi[l] + "\t" + XiAl2[l] + "\t" + XiYi[l] + "\t" + XiAl3[l] + "\t" + XiYiAl2[l] + "\t" + XiAl4[l] + "\t"  + XiYiAl3[l] + "\t" + XiAl5[l] + "\t" + XiAl6[l]);
                }
                imp += lstTabla.Items.Add("Suma\t" + sumaXi + "\t" + sumaYi + "\t" + sumaXiAl2 + "\t" + sumaXiYi + "\t" + sumaXiAl3 + "\t" + sumaXiYiAl2 + "\t" + sumaXiAl4 + sumaXiYiAl3 + "\t" + sumaXiAl5 + "\t" + sumaXiAl6);
                
                double[,] matriz2G = {{it, sumaXi, sumaXiAl2, sumaXiAl3, sumaYi}, {sumaXi,sumaXiAl2,sumaXiAl3,sumaXiAl4,sumaXiYi}, {sumaXiAl2, sumaXiAl3, sumaXiAl4, sumaXiAl5, sumaXiYiAl2}, {sumaXiAl3,sumaXiAl4,sumaXiAl5,sumaXiAl6,sumaXiYiAl3}};
                matrizAux1G = new double[5,4];
                matrizAux2G = SolPol(matriz2G, 4);

                a03 = matrizAux2G[0,4];
                a13 = matrizAux2G[1,4];
                a23 = matrizAux2G[2,4];
                a33 = matrizAux2G[3,4];

                lblPol.Text = $"P(x) = {Math.Round(a03,4)} + {Math.Round(a13,4)}x + {Math.Round(a23,4)}x^2 + {Math.Round(a33,4)}x^3";
                for (int l2 = 0; l2 < it; l2++)
                {
                    chGráf.Series["P(x)"].Points.AddXY(Xi[l2], 03 + a13 * Xi[l2] + a23 * XiAl2[l2] + a33 * XiAl3[l2]);
                    chGráf.Series["P(x)"].Points[l2].Label = $"{Math.Round(a03,4) + Math.Round(a13 * Xi[l2],4) + Math.Round(a23 * XiAl2[l2],4) + Math.Round(a33 * XiAl3[l2],4)}";
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblPol.Text = "Polinomio resultante";
            txtIteraciones.Text = "";
            lstTabla.Items.Clear();
            Array.Clear(Xi, 0, Xi.Length);
            Array.Clear(Yi, 0, Yi.Length);
            Array.Clear(XiAl2, 0, XiAl2.Length);
            Array.Clear(XiYi, 0, XiYi.Length);
            Array.Clear(XiAl3, 0, XiAl3.Length);
            Array.Clear(XiYiAl2, 0, XiYiAl2.Length);
            Array.Clear(XiAl4, 0, XiAl4.Length);
            Array.Clear(XiYiAl3, 0, XiYiAl3.Length);
            Array.Clear(XiAl5, 0, XiAl5.Length);
            Array.Clear(XiAl6, 0, XiAl6.Length);
            sumaXi = 0;  sumaYi = 0; sumaXiAl2 = 0; sumaXiYi = 0; sumaXiAl3 = 0; sumaXiYiAl2 = 0; sumaXiAl4 = 0; sumaXiYiAl3 = 0; sumaXiAl5 = 0;  sumaXiAl6 = 0;
            chGráf.Series["P(x)"].Points.Clear();
        }

        private void newtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NR = new NR();
            NR.Show();
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
