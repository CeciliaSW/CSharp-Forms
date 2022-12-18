namespace NHBA_PBMC_T3_MétNúm
{
    partial class MC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC));
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.gpGráf = new System.Windows.Forms.GroupBox();
            this.chGráf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpXiYi = new System.Windows.Forms.GroupBox();
            this.btnLlenarYi = new System.Windows.Forms.Button();
            this.btnLlenarXi = new System.Windows.Forms.Button();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.lblYi = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblTítMC = new System.Windows.Forms.Label();
            this.lstTabla = new System.Windows.Forms.ListBox();
            this.gpTabla = new System.Windows.Forms.GroupBox();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.gpGrado = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mínimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomiosLagrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpGráf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGráf)).BeginInit();
            this.gpXiYi.SuspendLayout();
            this.gpTabla.SuspendLayout();
            this.gpGrado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(147, 484);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(91, 31);
            this.btnReiniciar.TabIndex = 32;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // gpGráf
            // 
            this.gpGráf.Controls.Add(this.chGráf);
            this.gpGráf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGráf.Location = new System.Drawing.Point(1136, 242);
            this.gpGráf.Name = "gpGráf";
            this.gpGráf.Size = new System.Drawing.Size(374, 211);
            this.gpGráf.TabIndex = 31;
            this.gpGráf.TabStop = false;
            this.gpGráf.Text = "Gráfica del polinomio";
            // 
            // chGráf
            // 
            chartArea2.Name = "ChartArea1";
            this.chGráf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chGráf.Legends.Add(legend2);
            this.chGráf.Location = new System.Drawing.Point(26, 21);
            this.chGráf.Name = "chGráf";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "P(x)";
            this.chGráf.Series.Add(series2);
            this.chGráf.Size = new System.Drawing.Size(327, 178);
            this.chGráf.TabIndex = 14;
            this.chGráf.Text = "chart1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(81, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 28);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpXiYi
            // 
            this.gpXiYi.Controls.Add(this.btnLlenarYi);
            this.gpXiYi.Controls.Add(this.btnCalcular);
            this.gpXiYi.Controls.Add(this.btnLlenarXi);
            this.gpXiYi.Controls.Add(this.txtIteraciones);
            this.gpXiYi.Controls.Add(this.lblI);
            this.gpXiYi.Controls.Add(this.lblYi);
            this.gpXiYi.Controls.Add(this.lblXi);
            this.gpXiYi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpXiYi.Location = new System.Drawing.Point(41, 251);
            this.gpXiYi.Name = "gpXiYi";
            this.gpXiYi.Size = new System.Drawing.Size(200, 190);
            this.gpXiYi.TabIndex = 30;
            this.gpXiYi.TabStop = false;
            this.gpXiYi.Text = "Escriba Xi y Yi";
            // 
            // btnLlenarYi
            // 
            this.btnLlenarYi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarYi.Location = new System.Drawing.Point(81, 116);
            this.btnLlenarYi.Name = "btnLlenarYi";
            this.btnLlenarYi.Size = new System.Drawing.Size(91, 24);
            this.btnLlenarYi.TabIndex = 44;
            this.btnLlenarYi.Text = "Llenar";
            this.btnLlenarYi.UseVisualStyleBackColor = true;
            this.btnLlenarYi.Click += new System.EventHandler(this.btnLlenarYi_Click);
            // 
            // btnLlenarXi
            // 
            this.btnLlenarXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarXi.Location = new System.Drawing.Point(81, 79);
            this.btnLlenarXi.Name = "btnLlenarXi";
            this.btnLlenarXi.Size = new System.Drawing.Size(91, 24);
            this.btnLlenarXi.TabIndex = 43;
            this.btnLlenarXi.Text = "Llenar";
            this.btnLlenarXi.UseVisualStyleBackColor = true;
            this.btnLlenarXi.Click += new System.EventHandler(this.btnLlenarXi_Click);
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(81, 37);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(91, 22);
            this.txtIteraciones.TabIndex = 13;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(25, 40);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(11, 16);
            this.lblI.TabIndex = 12;
            this.lblI.Text = "i";
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(25, 120);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(21, 16);
            this.lblYi.TabIndex = 11;
            this.lblYi.Text = "Yi";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(25, 83);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(20, 16);
            this.lblXi.TabIndex = 3;
            this.lblXi.Text = "Xi";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.Location = new System.Drawing.Point(705, 98);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(223, 27);
            this.lblPol.TabIndex = 29;
            this.lblPol.Text = "Polinomio resultante";
            // 
            // lblTítMC
            // 
            this.lblTítMC.AutoSize = true;
            this.lblTítMC.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítMC.Location = new System.Drawing.Point(545, 51);
            this.lblTítMC.Name = "lblTítMC";
            this.lblTítMC.Size = new System.Drawing.Size(537, 74);
            this.lblTítMC.TabIndex = 28;
            this.lblTítMC.Text = "MÉTODO DE MÍNIMOS CUADRADOS\r\n\r\n";
            // 
            // lstTabla
            // 
            this.lstTabla.FormattingEnabled = true;
            this.lstTabla.ItemHeight = 16;
            this.lstTabla.Location = new System.Drawing.Point(6, 21);
            this.lstTabla.Name = "lstTabla";
            this.lstTabla.Size = new System.Drawing.Size(828, 180);
            this.lstTabla.TabIndex = 37;
            // 
            // gpTabla
            // 
            this.gpTabla.Controls.Add(this.lstTabla);
            this.gpTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTabla.Location = new System.Drawing.Point(270, 242);
            this.gpTabla.Name = "gpTabla";
            this.gpTabla.Size = new System.Drawing.Size(840, 211);
            this.gpTabla.TabIndex = 38;
            this.gpTabla.TabStop = false;
            this.gpTabla.Text = "Tabla de cálculo";
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(19, 34);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(106, 20);
            this.rd1.TabIndex = 39;
            this.rd1.TabStop = true;
            this.rd1.Text = "Primer grado";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(166, 34);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(122, 20);
            this.rd2.TabIndex = 40;
            this.rd2.Text = "Segundo grado";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(313, 34);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(107, 20);
            this.rd3.TabIndex = 41;
            this.rd3.Text = "Tercer grado";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // gpGrado
            // 
            this.gpGrado.Controls.Add(this.rd1);
            this.gpGrado.Controls.Add(this.rd3);
            this.gpGrado.Controls.Add(this.rd2);
            this.gpGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGrado.Location = new System.Drawing.Point(596, 148);
            this.gpGrado.Name = "gpGrado";
            this.gpGrado.Size = new System.Drawing.Size(430, 70);
            this.gpGrado.TabIndex = 42;
            this.gpGrado.TabStop = false;
            this.gpGrado.Text = "Elija el grado del polinomio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonRaphsonToolStripMenuItem,
            this.mínimosCuadradosToolStripMenuItem,
            this.rungeKuttaToolStripMenuItem,
            this.polinomiosLagrangeToolStripMenuItem,
            this.bisecciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1563, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson";
            this.newtonRaphsonToolStripMenuItem.Click += new System.EventHandler(this.newtonRaphsonToolStripMenuItem_Click);
            // 
            // mínimosCuadradosToolStripMenuItem
            // 
            this.mínimosCuadradosToolStripMenuItem.Enabled = false;
            this.mínimosCuadradosToolStripMenuItem.Name = "mínimosCuadradosToolStripMenuItem";
            this.mínimosCuadradosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.mínimosCuadradosToolStripMenuItem.Text = "Mínimos Cuadrados";
            // 
            // rungeKuttaToolStripMenuItem
            // 
            this.rungeKuttaToolStripMenuItem.Name = "rungeKuttaToolStripMenuItem";
            this.rungeKuttaToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.rungeKuttaToolStripMenuItem.Text = "Runge-Kutta";
            this.rungeKuttaToolStripMenuItem.Click += new System.EventHandler(this.rungeKuttaToolStripMenuItem_Click);
            // 
            // polinomiosLagrangeToolStripMenuItem
            // 
            this.polinomiosLagrangeToolStripMenuItem.Name = "polinomiosLagrangeToolStripMenuItem";
            this.polinomiosLagrangeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.polinomiosLagrangeToolStripMenuItem.Text = "Polinomios Lagrange";
            this.polinomiosLagrangeToolStripMenuItem.Click += new System.EventHandler(this.polinomiosLagrangeToolStripMenuItem_Click);
            // 
            // bisecciónToolStripMenuItem
            // 
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            this.bisecciónToolStripMenuItem.Click += new System.EventHandler(this.bisecciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpGrado);
            this.Controls.Add(this.gpTabla);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.gpGráf);
            this.Controls.Add(this.gpXiYi);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblTítMC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mínimos Cuadrados";
            this.gpGráf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chGráf)).EndInit();
            this.gpXiYi.ResumeLayout(false);
            this.gpXiYi.PerformLayout();
            this.gpTabla.ResumeLayout(false);
            this.gpGrado.ResumeLayout(false);
            this.gpGrado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox gpGráf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGráf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpXiYi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblTítMC;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.GroupBox gpTabla;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.GroupBox gpGrado;
        private System.Windows.Forms.Button btnLlenarYi;
        private System.Windows.Forms.Button btnLlenarXi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mínimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomiosLagrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}