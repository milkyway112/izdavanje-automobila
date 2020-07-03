namespace Projekat
{
    partial class AplikacijaZaAdmina
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
            this.btnAutomobili = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnAdmini = new System.Windows.Forms.Button();
            this.btnPonude = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutomobili
            // 
            this.btnAutomobili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomobili.Location = new System.Drawing.Point(13, 13);
            this.btnAutomobili.Name = "btnAutomobili";
            this.btnAutomobili.Size = new System.Drawing.Size(429, 43);
            this.btnAutomobili.TabIndex = 0;
            this.btnAutomobili.Text = "Automobili";
            this.btnAutomobili.UseVisualStyleBackColor = true;
            this.btnAutomobili.Click += new System.EventHandler(this.btnAutomobili_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(13, 209);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(429, 43);
            this.btnStatistika.TabIndex = 1;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Location = new System.Drawing.Point(13, 160);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(429, 43);
            this.btnRezervacije.TabIndex = 2;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnKupci
            // 
            this.btnKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupci.Location = new System.Drawing.Point(13, 111);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(429, 43);
            this.btnKupci.TabIndex = 3;
            this.btnKupci.Text = "Kupci";
            this.btnKupci.UseVisualStyleBackColor = true;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // btnAdmini
            // 
            this.btnAdmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmini.Location = new System.Drawing.Point(13, 258);
            this.btnAdmini.Name = "btnAdmini";
            this.btnAdmini.Size = new System.Drawing.Size(429, 43);
            this.btnAdmini.TabIndex = 4;
            this.btnAdmini.Text = "Administratori";
            this.btnAdmini.UseVisualStyleBackColor = true;
            this.btnAdmini.Click += new System.EventHandler(this.btnAdmini_Click);
            // 
            // btnPonude
            // 
            this.btnPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonude.Location = new System.Drawing.Point(13, 62);
            this.btnPonude.Name = "btnPonude";
            this.btnPonude.Size = new System.Drawing.Size(429, 43);
            this.btnPonude.TabIndex = 5;
            this.btnPonude.Text = "Ponude";
            this.btnPonude.UseVisualStyleBackColor = true;
            this.btnPonude.Click += new System.EventHandler(this.btnPonude_Click);
            // 
            // AplikacijaZaAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 312);
            this.Controls.Add(this.btnPonude);
            this.Controls.Add(this.btnAdmini);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnAutomobili);
            this.Name = "AplikacijaZaAdmina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplikacijaZaAdmina";
            this.Load += new System.EventHandler(this.AplikacijaZaAdmina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutomobili;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnAdmini;
        private System.Windows.Forms.Button btnPonude;
    }
}