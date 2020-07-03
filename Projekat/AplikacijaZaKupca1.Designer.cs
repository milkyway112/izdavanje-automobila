namespace Projekat
{
    partial class AplikacijaZaKupca1
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
            this.lbxRezervacije = new System.Windows.Forms.ListBox();
            this.btnPrikaziRezervacije = new System.Windows.Forms.Button();
            this.btnObrisiRezevraciju = new System.Windows.Forms.Button();
            this.btnNapraviNovuRezervaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxRezervacije
            // 
            this.lbxRezervacije.FormattingEnabled = true;
            this.lbxRezervacije.Location = new System.Drawing.Point(12, 55);
            this.lbxRezervacije.Name = "lbxRezervacije";
            this.lbxRezervacije.Size = new System.Drawing.Size(496, 147);
            this.lbxRezervacije.TabIndex = 0;
            // 
            // btnPrikaziRezervacije
            // 
            this.btnPrikaziRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziRezervacije.Location = new System.Drawing.Point(13, 5);
            this.btnPrikaziRezervacije.Name = "btnPrikaziRezervacije";
            this.btnPrikaziRezervacije.Size = new System.Drawing.Size(495, 44);
            this.btnPrikaziRezervacije.TabIndex = 1;
            this.btnPrikaziRezervacije.Text = "Prikaži rezervacije";
            this.btnPrikaziRezervacije.UseVisualStyleBackColor = true;
            this.btnPrikaziRezervacije.Click += new System.EventHandler(this.btnPrikaziRezervacije_Click);
            // 
            // btnObrisiRezevraciju
            // 
            this.btnObrisiRezevraciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezevraciju.Location = new System.Drawing.Point(13, 205);
            this.btnObrisiRezevraciju.Name = "btnObrisiRezevraciju";
            this.btnObrisiRezevraciju.Size = new System.Drawing.Size(495, 44);
            this.btnObrisiRezevraciju.TabIndex = 2;
            this.btnObrisiRezevraciju.Text = "Obriši rezervaciju";
            this.btnObrisiRezevraciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezevraciju.Click += new System.EventHandler(this.btnObrisiRezevraciju_Click);
            // 
            // btnNapraviNovuRezervaciju
            // 
            this.btnNapraviNovuRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviNovuRezervaciju.Location = new System.Drawing.Point(13, 255);
            this.btnNapraviNovuRezervaciju.Name = "btnNapraviNovuRezervaciju";
            this.btnNapraviNovuRezervaciju.Size = new System.Drawing.Size(495, 44);
            this.btnNapraviNovuRezervaciju.TabIndex = 3;
            this.btnNapraviNovuRezervaciju.Text = "Napravi novu rezervaciju";
            this.btnNapraviNovuRezervaciju.UseVisualStyleBackColor = true;
            this.btnNapraviNovuRezervaciju.Click += new System.EventHandler(this.btnNapraviNovuRezervaciju_Click);
            // 
            // AplikacijaZaKupca1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 311);
            this.Controls.Add(this.btnNapraviNovuRezervaciju);
            this.Controls.Add(this.btnObrisiRezevraciju);
            this.Controls.Add(this.btnPrikaziRezervacije);
            this.Controls.Add(this.lbxRezervacije);
            this.Name = "AplikacijaZaKupca1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplikacijaZaKupca1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRezervacije;
        private System.Windows.Forms.Button btnPrikaziRezervacije;
        private System.Windows.Forms.Button btnObrisiRezevraciju;
        private System.Windows.Forms.Button btnNapraviNovuRezervaciju;
    }
}