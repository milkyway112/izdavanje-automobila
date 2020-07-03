namespace Projekat
{
    partial class Statistika
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
            this.btnPrikaziStatistiku = new System.Windows.Forms.Button();
            this.cbxMesec = new System.Windows.Forms.ComboBox();
            this.cbxGodine = new System.Windows.Forms.ComboBox();
            this.btnIzlistajAutomobile = new System.Windows.Forms.Button();
            this.lbxAutomobili = new System.Windows.Forms.ListBox();
            this.lblMesecIGodina = new System.Windows.Forms.Label();
            this.lblStatistika = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrikaziStatistiku
            // 
            this.btnPrikaziStatistiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziStatistiku.Location = new System.Drawing.Point(175, 146);
            this.btnPrikaziStatistiku.Name = "btnPrikaziStatistiku";
            this.btnPrikaziStatistiku.Size = new System.Drawing.Size(233, 45);
            this.btnPrikaziStatistiku.TabIndex = 0;
            this.btnPrikaziStatistiku.Text = "Prikaži statistiku";
            this.btnPrikaziStatistiku.UseVisualStyleBackColor = true;
            this.btnPrikaziStatistiku.Click += new System.EventHandler(this.btnPrikaziStatistiku_Click);
            // 
            // cbxMesec
            // 
            this.cbxMesec.DropDownHeight = 60;
            this.cbxMesec.FormattingEnabled = true;
            this.cbxMesec.IntegralHeight = false;
            this.cbxMesec.Items.AddRange(new object[] {
            "januar",
            "februar",
            "mart",
            "april",
            "maj",
            "jun",
            "jul",
            "avgust",
            "septembar",
            "oktobar",
            "novembar",
            "decembar"});
            this.cbxMesec.Location = new System.Drawing.Point(12, 170);
            this.cbxMesec.Name = "cbxMesec";
            this.cbxMesec.Size = new System.Drawing.Size(69, 21);
            this.cbxMesec.TabIndex = 17;
            this.cbxMesec.SelectedValueChanged += new System.EventHandler(this.cbxMesec_SelectedValueChanged);
            // 
            // cbxGodine
            // 
            this.cbxGodine.DropDownHeight = 60;
            this.cbxGodine.FormattingEnabled = true;
            this.cbxGodine.IntegralHeight = false;
            this.cbxGodine.Location = new System.Drawing.Point(97, 170);
            this.cbxGodine.Name = "cbxGodine";
            this.cbxGodine.Size = new System.Drawing.Size(72, 21);
            this.cbxGodine.TabIndex = 18;
            this.cbxGodine.SelectedValueChanged += new System.EventHandler(this.cbxGodine_SelectedValueChanged);
            // 
            // btnIzlistajAutomobile
            // 
            this.btnIzlistajAutomobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajAutomobile.Location = new System.Drawing.Point(13, 12);
            this.btnIzlistajAutomobile.Name = "btnIzlistajAutomobile";
            this.btnIzlistajAutomobile.Size = new System.Drawing.Size(156, 122);
            this.btnIzlistajAutomobile.TabIndex = 19;
            this.btnIzlistajAutomobile.Text = "Izlistaj Automobile";
            this.btnIzlistajAutomobile.UseVisualStyleBackColor = true;
            this.btnIzlistajAutomobile.Click += new System.EventHandler(this.btnIzlistajAutomobile_Click);
            // 
            // lbxAutomobili
            // 
            this.lbxAutomobili.FormattingEnabled = true;
            this.lbxAutomobili.Location = new System.Drawing.Point(175, 13);
            this.lbxAutomobili.Name = "lbxAutomobili";
            this.lbxAutomobili.Size = new System.Drawing.Size(233, 121);
            this.lbxAutomobili.TabIndex = 20;
            // 
            // lblMesecIGodina
            // 
            this.lblMesecIGodina.AutoSize = true;
            this.lblMesecIGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesecIGodina.Location = new System.Drawing.Point(10, 154);
            this.lblMesecIGodina.Name = "lblMesecIGodina";
            this.lblMesecIGodina.Size = new System.Drawing.Size(159, 13);
            this.lblMesecIGodina.TabIndex = 21;
            this.lblMesecIGodina.Text = "Odaberite mesec i  godinu:";
            // 
            // lblStatistika
            // 
            this.lblStatistika.AutoSize = true;
            this.lblStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistika.Location = new System.Drawing.Point(132, 215);
            this.lblStatistika.Name = "lblStatistika";
            this.lblStatistika.Size = new System.Drawing.Size(149, 13);
            this.lblStatistika.TabIndex = 22;
            this.lblStatistika.Text = "Rezervisanost u mesecu:";
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 452);
            this.Controls.Add(this.lblStatistika);
            this.Controls.Add(this.lblMesecIGodina);
            this.Controls.Add(this.lbxAutomobili);
            this.Controls.Add(this.btnIzlistajAutomobile);
            this.Controls.Add(this.cbxGodine);
            this.Controls.Add(this.cbxMesec);
            this.Controls.Add(this.btnPrikaziStatistiku);
            this.Name = "Statistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistika_FormClosing);
            this.Load += new System.EventHandler(this.Statistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziStatistiku;
        private System.Windows.Forms.ComboBox cbxMesec;
        private System.Windows.Forms.ComboBox cbxGodine;
        private System.Windows.Forms.Button btnIzlistajAutomobile;
        private System.Windows.Forms.ListBox lbxAutomobili;
        private System.Windows.Forms.Label lblMesecIGodina;
        private System.Windows.Forms.Label lblStatistika;
    }
}