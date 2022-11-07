namespace AppPME
{
    partial class FrmPME
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbC1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TbC2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBHistoria = new System.Windows.Forms.GroupBox();
            this.RbR1H = new System.Windows.Forms.RadioButton();
            this.RbR2H = new System.Windows.Forms.RadioButton();
            this.RbR3H = new System.Windows.Forms.RadioButton();
            this.GBGeografia = new System.Windows.Forms.GroupBox();
            this.RbR3G = new System.Windows.Forms.RadioButton();
            this.RbR2G = new System.Windows.Forms.RadioButton();
            this.RbR1G = new System.Windows.Forms.RadioButton();
            this.evaluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TbC1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TbC2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GBHistoria.SuspendLayout();
            this.GBGeografia.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbC1
            // 
            this.TbC1.Controls.Add(this.tabPage1);
            this.TbC1.Controls.Add(this.TbC2);
            this.TbC1.Location = new System.Drawing.Point(12, 27);
            this.TbC1.Name = "TbC1";
            this.TbC1.SelectedIndex = 0;
            this.TbC1.Size = new System.Drawing.Size(685, 236);
            this.TbC1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RbR1H);
            this.tabPage1.Controls.Add(this.GBHistoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TbC2
            // 
            this.TbC2.Controls.Add(this.GBGeografia);
            this.TbC2.Location = new System.Drawing.Point(4, 22);
            this.TbC2.Name = "TbC2";
            this.TbC2.Padding = new System.Windows.Forms.Padding(3);
            this.TbC2.Size = new System.Drawing.Size(677, 210);
            this.TbC2.TabIndex = 1;
            this.TbC2.Text = "Geografia";
            this.TbC2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.evaluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // GBHistoria
            // 
            this.GBHistoria.Controls.Add(this.RbR3H);
            this.GBHistoria.Controls.Add(this.RbR2H);
            this.GBHistoria.Location = new System.Drawing.Point(6, 6);
            this.GBHistoria.Name = "GBHistoria";
            this.GBHistoria.Size = new System.Drawing.Size(665, 187);
            this.GBHistoria.TabIndex = 0;
            this.GBHistoria.TabStop = false;
            this.GBHistoria.Text = "¿Quien es actualmente el presidente de México?";
            // 
            // RbR1H
            // 
            this.RbR1H.AutoSize = true;
            this.RbR1H.Location = new System.Drawing.Point(20, 35);
            this.RbR1H.Name = "RbR1H";
            this.RbR1H.Size = new System.Drawing.Size(47, 17);
            this.RbR1H.TabIndex = 1;
            this.RbR1H.TabStop = true;
            this.RbR1H.Text = "EPN";
            this.RbR1H.UseVisualStyleBackColor = true;
            // 
            // RbR2H
            // 
            this.RbR2H.AutoSize = true;
            this.RbR2H.Location = new System.Drawing.Point(14, 71);
            this.RbR2H.Name = "RbR2H";
            this.RbR2H.Size = new System.Drawing.Size(112, 17);
            this.RbR2H.TabIndex = 2;
            this.RbR2H.TabStop = true;
            this.RbR2H.Text = "Felipe Calderón H.";
            this.RbR2H.UseVisualStyleBackColor = true;
            // 
            // RbR3H
            // 
            this.RbR3H.AutoSize = true;
            this.RbR3H.Location = new System.Drawing.Point(14, 112);
            this.RbR3H.Name = "RbR3H";
            this.RbR3H.Size = new System.Drawing.Size(55, 17);
            this.RbR3H.TabIndex = 3;
            this.RbR3H.TabStop = true;
            this.RbR3H.Text = "AMLO";
            this.RbR3H.UseVisualStyleBackColor = true;
            // 
            // GBGeografia
            // 
            this.GBGeografia.Controls.Add(this.RbR1G);
            this.GBGeografia.Controls.Add(this.RbR3G);
            this.GBGeografia.Controls.Add(this.RbR2G);
            this.GBGeografia.Location = new System.Drawing.Point(6, 6);
            this.GBGeografia.Name = "GBGeografia";
            this.GBGeografia.Size = new System.Drawing.Size(665, 187);
            this.GBGeografia.TabIndex = 1;
            this.GBGeografia.TabStop = false;
            this.GBGeografia.Text = "¿Cual es el río mas frande del Mundo?";
            // 
            // RbR3G
            // 
            this.RbR3G.AutoSize = true;
            this.RbR3G.Location = new System.Drawing.Point(14, 112);
            this.RbR3G.Name = "RbR3G";
            this.RbR3G.Size = new System.Drawing.Size(74, 17);
            this.RbR3G.TabIndex = 3;
            this.RbR3G.TabStop = true;
            this.RbR3G.Text = "Río Bravo";
            this.RbR3G.UseVisualStyleBackColor = true;
            // 
            // RbR2G
            // 
            this.RbR2G.AutoSize = true;
            this.RbR2G.Location = new System.Drawing.Point(14, 71);
            this.RbR2G.Name = "RbR2G";
            this.RbR2G.Size = new System.Drawing.Size(95, 17);
            this.RbR2G.TabIndex = 2;
            this.RbR2G.TabStop = true;
            this.RbR2G.Text = "Río Amazonas";
            this.RbR2G.UseVisualStyleBackColor = true;
            // 
            // RbR1G
            // 
            this.RbR1G.AutoSize = true;
            this.RbR1G.Location = new System.Drawing.Point(14, 30);
            this.RbR1G.Name = "RbR1G";
            this.RbR1G.Size = new System.Drawing.Size(62, 17);
            this.RbR1G.TabIndex = 4;
            this.RbR1G.TabStop = true;
            this.RbR1G.Text = "Rio Nilo";
            this.RbR1G.UseVisualStyleBackColor = true;
            // 
            // evaluarToolStripMenuItem
            // 
            this.evaluarToolStripMenuItem.Name = "evaluarToolStripMenuItem";
            this.evaluarToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.evaluarToolStripMenuItem.Text = "Evaluar";
            this.evaluarToolStripMenuItem.Click += new System.EventHandler(this.evaluarToolStripMenuItem_Click);
            // 
            // FrmPME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(725, 306);
            this.Controls.Add(this.TbC1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPME";
            this.Text = "Preguntas";
            this.TbC1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TbC2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBHistoria.ResumeLayout(false);
            this.GBHistoria.PerformLayout();
            this.GBGeografia.ResumeLayout(false);
            this.GBGeografia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbC1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TbC2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.RadioButton RbR1H;
        private System.Windows.Forms.GroupBox GBHistoria;
        private System.Windows.Forms.RadioButton RbR3H;
        private System.Windows.Forms.RadioButton RbR2H;
        private System.Windows.Forms.GroupBox GBGeografia;
        private System.Windows.Forms.RadioButton RbR1G;
        private System.Windows.Forms.RadioButton RbR3G;
        private System.Windows.Forms.RadioButton RbR2G;
        private System.Windows.Forms.ToolStripMenuItem evaluarToolStripMenuItem;
    }
}

