namespace NHBA_PBMC_T3_MétNúm
{
    partial class BS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BS));
            this.lstXm = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblFunción = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mínimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomiosLagrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstXm
            // 
            this.lstXm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstXm.FormattingEnabled = true;
            this.lstXm.ItemHeight = 16;
            this.lstXm.Location = new System.Drawing.Point(270, 190);
            this.lstXm.Name = "lstXm";
            this.lstXm.Size = new System.Drawing.Size(213, 244);
            this.lstXm.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReiniciar);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtD);
            this.groupBox2.Controls.Add(this.btnInsertar);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(489, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 237);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complete los espacios para la función";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(379, 205);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(103, 31);
            this.btnReiniciar.TabIndex = 18;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "f(xm)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(293, 175);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "x";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(440, 25);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(42, 22);
            this.txtD.TabIndex = 14;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(379, 135);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(102, 28);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(379, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 28);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(378, 25);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(35, 22);
            this.txtC.TabIndex = 8;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(306, 25);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(35, 22);
            this.txtB.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(232, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(45, 22);
            this.txtA.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIteraciones);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtXd);
            this.groupBox1.Controls.Add(this.txtXi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escriba Xi y Xd";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(26, 179);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(19, 16);
            this.lblIteraciones.TabIndex = 9;
            this.lblIteraciones.Text = "...";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xi";
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(80, 101);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 22);
            this.txtXd.TabIndex = 1;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(80, 48);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 22);
            this.txtXi.TabIndex = 0;
            // 
            // lblFunción
            // 
            this.lblFunción.AutoSize = true;
            this.lblFunción.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunción.Location = new System.Drawing.Point(356, 125);
            this.lblFunción.Name = "lblFunción";
            this.lblFunción.Size = new System.Drawing.Size(167, 16);
            this.lblFunción.TabIndex = 19;
            this.lblFunción.Text = "ax^3 + bx^2 + cx + d = 0";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(273, 59);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(357, 37);
            this.Titulo.TabIndex = 18;
            this.Titulo.Text = "MÉTODO DE BISECCIÓN\r\n";
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
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson";
            this.newtonRaphsonToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newtonRaphsonToolStripMenuItem.Click += new System.EventHandler(this.newtonRaphsonToolStripMenuItem_Click);
            // 
            // mínimosCuadradosToolStripMenuItem
            // 
            this.mínimosCuadradosToolStripMenuItem.Name = "mínimosCuadradosToolStripMenuItem";
            this.mínimosCuadradosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.mínimosCuadradosToolStripMenuItem.Text = "Mínimos Cuadrados";
            this.mínimosCuadradosToolStripMenuItem.Click += new System.EventHandler(this.mínimosCuadradosToolStripMenuItem_Click);
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
            this.bisecciónToolStripMenuItem.Enabled = false;
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // BS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 460);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstXm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFunción);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bisección";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstXm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblFunción;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mínimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomiosLagrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}