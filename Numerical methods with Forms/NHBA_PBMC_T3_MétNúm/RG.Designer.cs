namespace NHBA_PBMC_T3_MétNúm
{
    partial class RG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstIteraciones = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYprima = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mínimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomiosLagrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.lstIteraciones);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtYprima);
            this.groupBox1.Controls.Add(this.txtH);
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.txtY0);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1180, 363);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(777, 25);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "y\'";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 321);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // lstIteraciones
            // 
            this.lstIteraciones.FormattingEnabled = true;
            this.lstIteraciones.ItemHeight = 25;
            this.lstIteraciones.Location = new System.Drawing.Point(444, 21);
            this.lstIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.lstIteraciones.Name = "lstIteraciones";
            this.lstIteraciones.Size = new System.Drawing.Size(308, 304);
            this.lstIteraciones.TabIndex = 32;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 212);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 79);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(263, 86);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 87);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 31);
            this.label9.TabIndex = 25;
            this.label9.Text = "y\' =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "h =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Y(1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Y(0)";
            // 
            // txtYprima
            // 
            this.txtYprima.Location = new System.Drawing.Point(79, 258);
            this.txtYprima.Margin = new System.Windows.Forms.Padding(4);
            this.txtYprima.Name = "txtYprima";
            this.txtYprima.Size = new System.Drawing.Size(152, 30);
            this.txtYprima.TabIndex = 17;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(79, 202);
            this.txtH.Margin = new System.Windows.Forms.Padding(4);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(152, 30);
            this.txtH.TabIndex = 16;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(79, 147);
            this.txtY1.Margin = new System.Windows.Forms.Padding(4);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(152, 30);
            this.txtY1.TabIndex = 15;
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(79, 87);
            this.txtY0.Margin = new System.Windows.Forms.Padding(4);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(152, 30);
            this.txtY0.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "RUNGE-KUTTA";
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
            this.menuStrip1.Size = new System.Drawing.Size(1260, 28);
            this.menuStrip1.TabIndex = 30;
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
            this.rungeKuttaToolStripMenuItem.Enabled = false;
            this.rungeKuttaToolStripMenuItem.Name = "rungeKuttaToolStripMenuItem";
            this.rungeKuttaToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.rungeKuttaToolStripMenuItem.Text = "Runge-Kutta";
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
            // RG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 528);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runge-Kutta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox lstIteraciones;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYprima;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mínimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomiosLagrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}