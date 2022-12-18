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
    public partial class BN : Form
    {
        public BN()
        {
            InitializeComponent();
            btn1.Enabled = false; btn2.Enabled = false; btn3.Enabled = false; btn4.Enabled = false; btn5.Enabled = false;
            btn6.Enabled = false; btn7.Enabled = false; btn8.Enabled = false; btn9.Enabled = false; btn10.Enabled = false;
            btn11.Enabled = false; btn12.Enabled = false; btn13.Enabled = false; btn14.Enabled = false; btn15.Enabled = false;
            btn16.Enabled = false; btn17.Enabled = false; btn18.Enabled = false; btn19.Enabled = false; btn20.Enabled = false;
            btn21.Enabled = false; btn22.Enabled = false; btn23.Enabled = false; btn24.Enabled = false; btn25.Enabled = false;
            btn26.Enabled = false; btn27.Enabled = false; btn28.Enabled = false; btn29.Enabled = false; btn30.Enabled = false;
            btn31.Enabled = false; btn32.Enabled = false; btn33.Enabled = false; btn34.Enabled = false; btn35.Enabled = false; btn36.Enabled = false;
        }

        Button[] casillas;
        int cont = 0, puntaje = 0;
        Random r = new Random();
        int[] ram = new int[6];
        Image agua = Image.FromFile("mar.jpg");
        Image barcoD = Image.FromFile("barcoAdelante.png");
        Image barcoA = Image.FromFile("barcoAtras.png");
        Image isla = Image.FromFile("isla.png");
        Image fosa = Image.FromFile("torbellino.jpg");
        Font gradest = new Font("Arial", 8);
        Font smalles = new Font("Calibri", 1);

        public void finJuego()
        {
            if (puntaje <= 0)
            {
                MessageBox.Show("Juego terminado.");
                for (int i = 0; i < casillas.Length; i++)
                {
                    casillas[i].Enabled = false;
                    casillas[i].Font = gradest;
                }
                tableLayoutPanel1.Enabled = false;
            }
        }

        public void ganaste()
        {
            Button xd = new Button();
            if (cont == 6)
            {
                MessageBox.Show("Ganaste.");
                tableLayoutPanel1.Enabled = false;
                for (int i = 0; i < casillas.Length; i++)
                {
                    casillas[i].Font = gradest;
                }
            }
        }

        public Button[] cargarCasillas()
        {
            casillas = new Button[36];
            casillas[0] = btn1; casillas[1] = btn2; casillas[2] = btn3; casillas[3] = btn4; casillas[4] = btn5; casillas[5] = btn6;
            casillas[6] = btn7; casillas[7] = btn8; casillas[8] = btn9; casillas[9] = btn10; casillas[10] = btn11; casillas[11] = btn12;
            casillas[12] = btn13; casillas[13] = btn14; casillas[14] = btn15; casillas[15] = btn16; casillas[16] = btn17; casillas[17] = btn18;
            casillas[18] = btn19; casillas[19] = btn20; casillas[20] = btn21; casillas[21] = btn22; casillas[22] = btn23; casillas[23] = btn24;
            casillas[24] = btn25; casillas[25] = btn26; casillas[26] = btn27; casillas[27] = btn28; casillas[28] = btn29; casillas[29] = btn30;
            casillas[30] = btn31; casillas[31] = btn32; casillas[32] = btn33; casillas[33] = btn34; casillas[34] = btn35; casillas[35] = btn36;
            return casillas;
        }

        public void juegoNuevo()
        {
            puntaje = 100;

            cargarCasillas();
            for (int i = 0; i < casillas.Length; i++)
            {
                casillas[i].Enabled = true;
                casillas[i].Text = " ";
                casillas[i].Image = agua;
            }
            lblPuntaje.Text = $"Puntuación: {puntaje}";

            for (int i = 0; i < 6; i++)
            {
                ram[i] = r.Next(0, 35);
            }

            int barcoA1 = ram[0] - 1;
            int barcoA2 = ram[1] - 1;
            int barcoA3 = ram[5] - 1;

            int j=0;
            while (j != 2)
            {
                if (ram[2] == barcoA1 || ram[2] == barcoA2 || ram[2] == barcoA3 || ram[2] == ram[0] || ram[2] == ram[1] || ram[2] == ram[5])
                {
                    ram[2] += 2;
                }
                if (ram[3] == barcoA1 || ram[3] == barcoA2 || ram[3] == barcoA3 || ram[3] == ram[0] || ram[3] == ram[1] || ram[3] == ram[5])
                {
                    ram[3] += 2;
                }
                if (ram[4] == barcoA1 || ram[4] == barcoA2 || ram[4] == barcoA3 || ram[4] == ram[0] || ram[4] == ram[1] || ram[4] == ram[5])
                {
                    ram[4] += 2;
                }
                j++;
            }
            casillas[ram[0]].Text = "BarcoDelantero";
            casillas[barcoA1].Text = "BarcoAtrás";
            casillas[ram[1]].Text = "BarcoAtrás";
            casillas[barcoA2].Text = "BarcoDelantero";
            casillas[ram[2]].Text = "Fosa";
            casillas[ram[3]].Text = "Isla";
            casillas[ram[4]].Text = "Isla";
            casillas[ram[5]].Text = "BarcoDelantero";
            casillas[barcoA3].Text = "BarcoAtrás";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            switch (a.Text)
            {
                case "BarcoDelantero":
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    a.BackgroundImage = barcoD;
                    a.Image = null;
                    puntaje += 30;
                    lblPuntaje.Text = $"Puntuación: {puntaje}";
                    a.Enabled = false;
                    cont++;

                    break;

                case "BarcoAtrás":
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    a.BackgroundImage = barcoA;
                    a.Image = null;
                    puntaje += 30;
                    lblPuntaje.Text = $"Puntuación: {puntaje}";
                    a.Enabled = false;
                    cont++;
                    break;
                case "Isla":
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    a.BackgroundImage = isla;
                    a.Image = null;
                    puntaje += 50;
                    lblPuntaje.Text = $"Puntuación: {puntaje}";
                    a.Enabled = false;
                    break;
                case "Fosa":
                    a.BackgroundImageLayout = ImageLayout.Stretch;
                    a.BackgroundImage = fosa;
                    a.Image = null;
                    puntaje = 0;
                    lblPuntaje.Text = $"Puntuación: {puntaje}";
                    a.Enabled = false;
                    cont = 0;
                    MessageBox.Show("Juego terminado.");
                    for (int i = 0; i < casillas.Length; i++)
                    {
                        casillas[i].Font = gradest;
                    }
                    tableLayoutPanel1.Enabled = false;
                    break;
                default:
                    a.Enabled = false;
                    puntaje -= 20;
                    lblPuntaje.Text = $"Puntuación {puntaje}";
                    finJuego();
                    break;
            }
            ganaste();
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            cont = 0;
            juegoNuevo();
            for (int i = 0; i < casillas.Length; i++)
            {
                casillas[i].Font = smalles;
            }
            tableLayoutPanel1.Enabled = true;
        }


        private void tspCE(object sender, EventArgs e)
        {
            Form Estándar = new CE();
            Estándar.Show();
            this.Hide();
        }

        private void tspCPB(object sender, EventArgs e)
        {
            Form ProgramadorBin = new CPB();
            ProgramadorBin.Show();
            this.Hide();
        }

        private void tspCPD(object sender, EventArgs e)
        {
            Form ProgramadorDec = new CPD();
            ProgramadorDec.Show();
            this.Hide();
        }

        private void tspRegresar(object sender, EventArgs e)
        {
            Form Bienvenida = new Bienvenida();
            Bienvenida.Show();
            this.Hide();
        }

        private void tspSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
