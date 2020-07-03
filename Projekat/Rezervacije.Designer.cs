namespace Projekat
{
    partial class Rezervacije
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
            this.gbxAzuriranjeRezervacija = new System.Windows.Forms.GroupBox();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.btnIzbrisiRezervaciju = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lbxRezervacije = new System.Windows.Forms.ListBox();
            this.btnIzlistajKupce = new System.Windows.Forms.Button();
            this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.lbxKupci = new System.Windows.Forms.ListBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lbxAutomobili = new System.Windows.Forms.ListBox();
            this.btnIzlistajAutomobile = new System.Windows.Forms.Button();
            this.lblRezervacije = new System.Windows.Forms.Label();
            this.lblKupci = new System.Windows.Forms.Label();
            this.lblAutomobili = new System.Windows.Forms.Label();
            this.gbxAzuriranjeRezervacija.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAzuriranjeRezervacija
            // 
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblAutomobili);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblKupci);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblRezervacije);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.btnIzlistajAutomobile);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lbxAutomobili);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.btnDodajRezervaciju);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.btnIzbrisiRezervaciju);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblCena);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.txtCena);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lbxRezervacije);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.btnIzlistajKupce);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.btnIzmeniRezervaciju);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblDatumDo);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lbxKupci);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.dtpDatumOd);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.lblDatumOd);
            this.gbxAzuriranjeRezervacija.Controls.Add(this.dtpDatumDo);
            this.gbxAzuriranjeRezervacija.Location = new System.Drawing.Point(12, 12);
            this.gbxAzuriranjeRezervacija.Name = "gbxAzuriranjeRezervacija";
            this.gbxAzuriranjeRezervacija.Size = new System.Drawing.Size(474, 419);
            this.gbxAzuriranjeRezervacija.TabIndex = 1;
            this.gbxAzuriranjeRezervacija.TabStop = false;
            this.gbxAzuriranjeRezervacija.Text = "Ažuriranje rezervacija";
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(9, 365);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(461, 43);
            this.btnDodajRezervaciju.TabIndex = 50;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = true;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // btnIzbrisiRezervaciju
            // 
            this.btnIzbrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiRezervaciju.Location = new System.Drawing.Point(242, 315);
            this.btnIzbrisiRezervaciju.Name = "btnIzbrisiRezervaciju";
            this.btnIzbrisiRezervaciju.Size = new System.Drawing.Size(228, 43);
            this.btnIzbrisiRezervaciju.TabIndex = 49;
            this.btnIzbrisiRezervaciju.Text = "Obriši rezervaciju";
            this.btnIzbrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnIzbrisiRezervaciju.Click += new System.EventHandler(this.btnIzbrisiRezervaciju_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(291, 204);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(40, 13);
            this.lblCena.TabIndex = 48;
            this.lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(370, 201);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 47;
            // 
            // lbxRezervacije
            // 
            this.lbxRezervacije.FormattingEnabled = true;
            this.lbxRezervacije.Location = new System.Drawing.Point(194, 86);
            this.lbxRezervacije.Name = "lbxRezervacije";
            this.lbxRezervacije.Size = new System.Drawing.Size(276, 108);
            this.lbxRezervacije.TabIndex = 45;
            this.lbxRezervacije.SelectedValueChanged += new System.EventHandler(this.lbxRezervacije_SelectedValueChanged);
            // 
            // btnIzlistajKupce
            // 
            this.btnIzlistajKupce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajKupce.Location = new System.Drawing.Point(9, 19);
            this.btnIzlistajKupce.Name = "btnIzlistajKupce";
            this.btnIzlistajKupce.Size = new System.Drawing.Size(461, 48);
            this.btnIzlistajKupce.TabIndex = 38;
            this.btnIzlistajKupce.Text = "Izlistaj kupce";
            this.btnIzlistajKupce.UseVisualStyleBackColor = true;
            this.btnIzlistajKupce.Click += new System.EventHandler(this.btnIzlistajKupce_Click);
            // 
            // btnIzmeniRezervaciju
            // 
            this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(9, 315);
            this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
            this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(228, 43);
            this.btnIzmeniRezervaciju.TabIndex = 44;
            this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
            this.btnIzmeniRezervaciju.UseVisualStyleBackColor = true;
            this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumDo.Location = new System.Drawing.Point(291, 271);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(163, 15);
            this.lblDatumDo.TabIndex = 43;
            this.lblDatumDo.Text = "Datum kraja rezervacije:";
            // 
            // lbxKupci
            // 
            this.lbxKupci.FormattingEnabled = true;
            this.lbxKupci.Location = new System.Drawing.Point(9, 86);
            this.lbxKupci.Name = "lbxKupci";
            this.lbxKupci.Size = new System.Drawing.Size(182, 108);
            this.lbxKupci.TabIndex = 0;
            this.lbxKupci.SelectedValueChanged += new System.EventHandler(this.lbxKupci_SelectedValueChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(294, 248);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(176, 20);
            this.dtpDatumOd.TabIndex = 39;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOd.Location = new System.Drawing.Point(291, 230);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(181, 15);
            this.lblDatumOd.TabIndex = 41;
            this.lblDatumOd.Text = "Datum početka rezervacije:";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(294, 289);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(176, 20);
            this.dtpDatumDo.TabIndex = 40;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // lbxAutomobili
            // 
            this.lbxAutomobili.FormattingEnabled = true;
            this.lbxAutomobili.Location = new System.Drawing.Point(9, 214);
            this.lbxAutomobili.Name = "lbxAutomobili";
            this.lbxAutomobili.Size = new System.Drawing.Size(182, 95);
            this.lbxAutomobili.TabIndex = 51;
            // 
            // btnIzlistajAutomobile
            // 
            this.btnIzlistajAutomobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajAutomobile.Location = new System.Drawing.Point(197, 214);
            this.btnIzlistajAutomobile.Name = "btnIzlistajAutomobile";
            this.btnIzlistajAutomobile.Size = new System.Drawing.Size(91, 95);
            this.btnIzlistajAutomobile.TabIndex = 52;
            this.btnIzlistajAutomobile.Text = "Izlistaj automobile";
            this.btnIzlistajAutomobile.UseVisualStyleBackColor = true;
            this.btnIzlistajAutomobile.Click += new System.EventHandler(this.btnIzlistajAutomobile_Click);
            // 
            // lblRezervacije
            // 
            this.lblRezervacije.AutoSize = true;
            this.lblRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacije.Location = new System.Drawing.Point(194, 70);
            this.lblRezervacije.Name = "lblRezervacije";
            this.lblRezervacije.Size = new System.Drawing.Size(201, 15);
            this.lblRezervacije.TabIndex = 53;
            this.lblRezervacije.Text = "Rezervacije odabranog kupca:";
            // 
            // lblKupci
            // 
            this.lblKupci.AutoSize = true;
            this.lblKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKupci.Location = new System.Drawing.Point(6, 70);
            this.lblKupci.Name = "lblKupci";
            this.lblKupci.Size = new System.Drawing.Size(47, 15);
            this.lblKupci.TabIndex = 54;
            this.lblKupci.Text = "Kupci:";
            // 
            // lblAutomobili
            // 
            this.lblAutomobili.AutoSize = true;
            this.lblAutomobili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomobili.Location = new System.Drawing.Point(6, 197);
            this.lblAutomobili.Name = "lblAutomobili";
            this.lblAutomobili.Size = new System.Drawing.Size(79, 15);
            this.lblAutomobili.TabIndex = 55;
            this.lblAutomobili.Text = "Automobili:";
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 440);
            this.Controls.Add(this.gbxAzuriranjeRezervacija);
            this.Name = "Rezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rezervacije_FormClosing);
            this.Load += new System.EventHandler(this.Rezervacije_Load);
            this.gbxAzuriranjeRezervacija.ResumeLayout(false);
            this.gbxAzuriranjeRezervacija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAzuriranjeRezervacija;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnIzbrisiRezervaciju;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ListBox lbxRezervacije;
        private System.Windows.Forms.Button btnIzlistajKupce;
        private System.Windows.Forms.Button btnIzmeniRezervaciju;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.ListBox lbxKupci;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnIzlistajAutomobile;
        private System.Windows.Forms.ListBox lbxAutomobili;
        private System.Windows.Forms.Label lblAutomobili;
        private System.Windows.Forms.Label lblKupci;
        private System.Windows.Forms.Label lblRezervacije;
    }
}