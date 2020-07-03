namespace Projekat
{
    partial class DodajPonudu
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
            this.gbxDodajPonudu = new System.Windows.Forms.GroupBox();
            this.btnDodajPonudu = new System.Windows.Forms.Button();
            this.btnIzbrisiPonudu = new System.Windows.Forms.Button();
            this.lblCenaPoDanu = new System.Windows.Forms.Label();
            this.txtCenaPoDanu = new System.Windows.Forms.TextBox();
            this.lblPonude = new System.Windows.Forms.Label();
            this.lbxPonude = new System.Windows.Forms.ListBox();
            this.btnIzlistajAutomobile = new System.Windows.Forms.Button();
            this.btnIzmeniPonudu = new System.Windows.Forms.Button();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.lbxAutomobili = new System.Windows.Forms.ListBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.gbxDodajPonudu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDodajPonudu
            // 
            this.gbxDodajPonudu.Controls.Add(this.btnDodajPonudu);
            this.gbxDodajPonudu.Controls.Add(this.btnIzbrisiPonudu);
            this.gbxDodajPonudu.Controls.Add(this.lblCenaPoDanu);
            this.gbxDodajPonudu.Controls.Add(this.txtCenaPoDanu);
            this.gbxDodajPonudu.Controls.Add(this.lblPonude);
            this.gbxDodajPonudu.Controls.Add(this.lbxPonude);
            this.gbxDodajPonudu.Controls.Add(this.btnIzlistajAutomobile);
            this.gbxDodajPonudu.Controls.Add(this.btnIzmeniPonudu);
            this.gbxDodajPonudu.Controls.Add(this.lblDatumDo);
            this.gbxDodajPonudu.Controls.Add(this.lbxAutomobili);
            this.gbxDodajPonudu.Controls.Add(this.dtpDatumOd);
            this.gbxDodajPonudu.Controls.Add(this.lblDatumOd);
            this.gbxDodajPonudu.Controls.Add(this.dtpDatumDo);
            this.gbxDodajPonudu.Location = new System.Drawing.Point(13, 13);
            this.gbxDodajPonudu.Name = "gbxDodajPonudu";
            this.gbxDodajPonudu.Size = new System.Drawing.Size(474, 471);
            this.gbxDodajPonudu.TabIndex = 0;
            this.gbxDodajPonudu.TabStop = false;
            this.gbxDodajPonudu.Text = "Dodavanje Ponuda";
            // 
            // btnDodajPonudu
            // 
            this.btnDodajPonudu.Location = new System.Drawing.Point(6, 421);
            this.btnDodajPonudu.Name = "btnDodajPonudu";
            this.btnDodajPonudu.Size = new System.Drawing.Size(461, 43);
            this.btnDodajPonudu.TabIndex = 50;
            this.btnDodajPonudu.Text = "Dodaj ponudu";
            this.btnDodajPonudu.UseVisualStyleBackColor = true;
            this.btnDodajPonudu.Click += new System.EventHandler(this.btnDodajPonudu_Click_1);
            // 
            // btnIzbrisiPonudu
            // 
            this.btnIzbrisiPonudu.Location = new System.Drawing.Point(239, 371);
            this.btnIzbrisiPonudu.Name = "btnIzbrisiPonudu";
            this.btnIzbrisiPonudu.Size = new System.Drawing.Size(228, 43);
            this.btnIzbrisiPonudu.TabIndex = 49;
            this.btnIzbrisiPonudu.Text = "Obriši ponudu";
            this.btnIzbrisiPonudu.UseVisualStyleBackColor = true;
            this.btnIzbrisiPonudu.Click += new System.EventHandler(this.btnIzbrisiPonudu_Click);
            // 
            // lblCenaPoDanu
            // 
            this.lblCenaPoDanu.AutoSize = true;
            this.lblCenaPoDanu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenaPoDanu.Location = new System.Drawing.Point(256, 260);
            this.lblCenaPoDanu.Name = "lblCenaPoDanu";
            this.lblCenaPoDanu.Size = new System.Drawing.Size(90, 13);
            this.lblCenaPoDanu.TabIndex = 48;
            this.lblCenaPoDanu.Text = "Cena po danu:";
            // 
            // txtCenaPoDanu
            // 
            this.txtCenaPoDanu.Location = new System.Drawing.Point(352, 257);
            this.txtCenaPoDanu.Name = "txtCenaPoDanu";
            this.txtCenaPoDanu.Size = new System.Drawing.Size(115, 20);
            this.txtCenaPoDanu.TabIndex = 47;
            // 
            // lblPonude
            // 
            this.lblPonude.AutoSize = true;
            this.lblPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonude.Location = new System.Drawing.Point(7, 238);
            this.lblPonude.Name = "lblPonude";
            this.lblPonude.Size = new System.Drawing.Size(236, 13);
            this.lblPonude.TabIndex = 46;
            this.lblPonude.Text = "Postojeće ponude za izabrani automobil:";
            // 
            // lbxPonude
            // 
            this.lbxPonude.FormattingEnabled = true;
            this.lbxPonude.Location = new System.Drawing.Point(6, 257);
            this.lbxPonude.Name = "lbxPonude";
            this.lbxPonude.Size = new System.Drawing.Size(237, 108);
            this.lbxPonude.TabIndex = 45;
            // 
            // btnIzlistajAutomobile
            // 
            this.btnIzlistajAutomobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajAutomobile.Location = new System.Drawing.Point(6, 19);
            this.btnIzlistajAutomobile.Name = "btnIzlistajAutomobile";
            this.btnIzlistajAutomobile.Size = new System.Drawing.Size(461, 48);
            this.btnIzlistajAutomobile.TabIndex = 38;
            this.btnIzlistajAutomobile.Text = "Izlistaj automobile";
            this.btnIzlistajAutomobile.UseVisualStyleBackColor = true;
            this.btnIzlistajAutomobile.Click += new System.EventHandler(this.btnIzlistajAutomobile_Click);
            // 
            // btnIzmeniPonudu
            // 
            this.btnIzmeniPonudu.Location = new System.Drawing.Point(6, 371);
            this.btnIzmeniPonudu.Name = "btnIzmeniPonudu";
            this.btnIzmeniPonudu.Size = new System.Drawing.Size(228, 43);
            this.btnIzmeniPonudu.TabIndex = 44;
            this.btnIzmeniPonudu.Text = "Izmeni ponudu";
            this.btnIzmeniPonudu.UseVisualStyleBackColor = true;
            this.btnIzmeniPonudu.Click += new System.EventHandler(this.btnIzmeniPonudu_Click);
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumDo.Location = new System.Drawing.Point(252, 327);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(193, 15);
            this.lblDatumDo.TabIndex = 43;
            this.lblDatumDo.Text = "Datum do kojeg traje ponuda";
            // 
            // lbxAutomobili
            // 
            this.lbxAutomobili.FormattingEnabled = true;
            this.lbxAutomobili.Location = new System.Drawing.Point(6, 72);
            this.lbxAutomobili.Name = "lbxAutomobili";
            this.lbxAutomobili.Size = new System.Drawing.Size(461, 160);
            this.lbxAutomobili.TabIndex = 0;
            this.lbxAutomobili.SelectedValueChanged += new System.EventHandler(this.lbxAutomobili_SelectedValueChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(255, 304);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(212, 20);
            this.dtpDatumOd.TabIndex = 39;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOd.Location = new System.Drawing.Point(256, 286);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(211, 15);
            this.lblDatumOd.TabIndex = 41;
            this.lblDatumOd.Text = "Datum od kojeg počinje ponuda";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(255, 345);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(212, 20);
            this.dtpDatumDo.TabIndex = 40;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // DodajPonudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 495);
            this.Controls.Add(this.gbxDodajPonudu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DodajPonudu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajPonudu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajPonudu_FormClosing);
            this.gbxDodajPonudu.ResumeLayout(false);
            this.gbxDodajPonudu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDodajPonudu;
        private System.Windows.Forms.ListBox lbxAutomobili;
        private System.Windows.Forms.Button btnIzlistajAutomobile;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Button btnIzbrisiPonudu;
        private System.Windows.Forms.Label lblCenaPoDanu;
        private System.Windows.Forms.TextBox txtCenaPoDanu;
        private System.Windows.Forms.Label lblPonude;
        private System.Windows.Forms.ListBox lbxPonude;
        private System.Windows.Forms.Button btnIzmeniPonudu;
        private System.Windows.Forms.Button btnDodajPonudu;
    }
}