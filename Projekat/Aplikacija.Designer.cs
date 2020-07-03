namespace Projekat
{
    partial class Aplikacija
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsDodavanjeIUklanjanjeAutomobila = new System.Windows.Forms.ToolStripMenuItem();
            this.ponudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsDodavanjeIUklanjanjeAutomobila,
            this.ponudeToolStripMenuItem,
            this.rezervisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsDodavanjeIUklanjanjeAutomobila
            // 
            this.tlsDodavanjeIUklanjanjeAutomobila.Name = "tlsDodavanjeIUklanjanjeAutomobila";
            this.tlsDodavanjeIUklanjanjeAutomobila.Size = new System.Drawing.Size(79, 20);
            this.tlsDodavanjeIUklanjanjeAutomobila.Text = "Automobili";
            this.tlsDodavanjeIUklanjanjeAutomobila.Click += new System.EventHandler(this.tlsDodavanjeIUklanjanjeAutomobila_Click);
            // 
            // ponudeToolStripMenuItem
            // 
            this.ponudeToolStripMenuItem.Name = "ponudeToolStripMenuItem";
            this.ponudeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ponudeToolStripMenuItem.Text = "Ponude";
            this.ponudeToolStripMenuItem.Click += new System.EventHandler(this.ponudeToolStripMenuItem_Click);
            // 
            // rezervisiToolStripMenuItem
            // 
            this.rezervisiToolStripMenuItem.Name = "rezervisiToolStripMenuItem";
            this.rezervisiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.rezervisiToolStripMenuItem.Text = "Rezervisi";
            // 
            // Aplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 672);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Aplikacija";
            this.Text = "Aplikacija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsDodavanjeIUklanjanjeAutomobila;
        private System.Windows.Forms.ToolStripMenuItem ponudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervisiToolStripMenuItem;
    }
}