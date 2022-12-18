namespace E212_P3P
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.lblTítulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraEstándarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programadorBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programadorDecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batallaNavalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(12, 116);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(737, 212);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "  CALCULADORA \r\nY BATALLA NAVAL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 1;
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraEstándarToolStripMenuItem,
            this.programadorBinToolStripMenuItem,
            this.programadorDecToolStripMenuItem,
            this.batallaNavalToolStripMenuItem});
            this.programasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.programasToolStripMenuItem.Text = "Programas";
       
            // 
            // calculadoraEstándarToolStripMenuItem
            // 
            this.calculadoraEstándarToolStripMenuItem.Name = "calculadoraEstándarToolStripMenuItem";
            this.calculadoraEstándarToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.calculadoraEstándarToolStripMenuItem.Text = "Estándar";
            this.calculadoraEstándarToolStripMenuItem.Click += new System.EventHandler(this.tsmCE);
            // 
            // programadorBinToolStripMenuItem
            // 
            this.programadorBinToolStripMenuItem.Name = "programadorBinToolStripMenuItem";
            this.programadorBinToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.programadorBinToolStripMenuItem.Text = "Programador Bin";
            this.programadorBinToolStripMenuItem.Click += new System.EventHandler(this.tsmCPB);
            // 
            // programadorDecToolStripMenuItem
            // 
            this.programadorDecToolStripMenuItem.Name = "programadorDecToolStripMenuItem";
            this.programadorDecToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.programadorDecToolStripMenuItem.Text = "Programador Dec";
            this.programadorDecToolStripMenuItem.Click += new System.EventHandler(this.tsmCPD);
            // 
            // batallaNavalToolStripMenuItem
            // 
            this.batallaNavalToolStripMenuItem.Name = "batallaNavalToolStripMenuItem";
            this.batallaNavalToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.batallaNavalToolStripMenuItem.Text = "Batalla naval";
            this.batallaNavalToolStripMenuItem.Click += new System.EventHandler(this.tsmBN);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.tsmSalir);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraEstándarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programadorBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programadorDecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batallaNavalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}