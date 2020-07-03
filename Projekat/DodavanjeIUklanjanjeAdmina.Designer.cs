namespace Projekat
{
    partial class DodavanjeIUklanjanjeAdmina
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
            this.cbxGodine = new System.Windows.Forms.ComboBox();
            this.cbxMesec = new System.Windows.Forms.ComboBox();
            this.cbxDan = new System.Windows.Forms.ComboBox();
            this.btnNapraviNalog = new System.Windows.Forms.Button();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lbxAdmini = new System.Windows.Forms.ListBox();
            this.btnIzlistajNaloge = new System.Windows.Forms.Button();
            this.rbtnJesteGlavniAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnNijeGlavniAdmin = new System.Windows.Forms.RadioButton();
            this.btnObrisiNalog = new System.Windows.Forms.Button();
            this.btnIzmeniNalog = new System.Windows.Forms.Button();
            this.lblPlata = new System.Windows.Forms.Label();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxGodine
            // 
            this.cbxGodine.DropDownHeight = 60;
            this.cbxGodine.FormattingEnabled = true;
            this.cbxGodine.IntegralHeight = false;
            this.cbxGodine.Location = new System.Drawing.Point(298, 60);
            this.cbxGodine.Name = "cbxGodine";
            this.cbxGodine.Size = new System.Drawing.Size(72, 21);
            this.cbxGodine.TabIndex = 34;
            this.cbxGodine.SelectedValueChanged += new System.EventHandler(this.cbxGodine_SelectedValueChanged);
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
            this.cbxMesec.Location = new System.Drawing.Point(222, 60);
            this.cbxMesec.Name = "cbxMesec";
            this.cbxMesec.Size = new System.Drawing.Size(69, 21);
            this.cbxMesec.TabIndex = 33;
            this.cbxMesec.SelectedValueChanged += new System.EventHandler(this.cbxMesec_SelectedValueChanged);
            // 
            // cbxDan
            // 
            this.cbxDan.DisplayMember = "01";
            this.cbxDan.DropDownHeight = 60;
            this.cbxDan.FormattingEnabled = true;
            this.cbxDan.IntegralHeight = false;
            this.cbxDan.ItemHeight = 13;
            this.cbxDan.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDan.Location = new System.Drawing.Point(170, 60);
            this.cbxDan.Name = "cbxDan";
            this.cbxDan.Size = new System.Drawing.Size(46, 21);
            this.cbxDan.TabIndex = 32;
            // 
            // btnNapraviNalog
            // 
            this.btnNapraviNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviNalog.Location = new System.Drawing.Point(15, 241);
            this.btnNapraviNalog.Name = "btnNapraviNalog";
            this.btnNapraviNalog.Size = new System.Drawing.Size(355, 38);
            this.btnNapraviNalog.TabIndex = 31;
            this.btnNapraviNalog.Text = "Napravi nalog";
            this.btnNapraviNalog.UseVisualStyleBackColor = true;
            this.btnNapraviNalog.Click += new System.EventHandler(this.btnNapraviNalog_Click);
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(12, 61);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(117, 16);
            this.lblDatumRodjenja.TabIndex = 30;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 86);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 16);
            this.lblUsername.TabIndex = 27;
            this.lblUsername.Text = "Username:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(11, 34);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 16);
            this.lblPrezime.TabIndex = 25;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(37, 16);
            this.lblIme.TabIndex = 24;
            this.lblIme.Text = "Ime:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 23;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 22;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(170, 34);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 19;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(170, 8);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 18;
            // 
            // lbxAdmini
            // 
            this.lbxAdmini.FormattingEnabled = true;
            this.lbxAdmini.Location = new System.Drawing.Point(14, 329);
            this.lbxAdmini.Name = "lbxAdmini";
            this.lbxAdmini.Size = new System.Drawing.Size(355, 121);
            this.lbxAdmini.TabIndex = 35;
            this.lbxAdmini.SelectedValueChanged += new System.EventHandler(this.lbxAdmini_SelectedValueChanged);
            // 
            // btnIzlistajNaloge
            // 
            this.btnIzlistajNaloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajNaloge.Location = new System.Drawing.Point(14, 285);
            this.btnIzlistajNaloge.Name = "btnIzlistajNaloge";
            this.btnIzlistajNaloge.Size = new System.Drawing.Size(355, 38);
            this.btnIzlistajNaloge.TabIndex = 36;
            this.btnIzlistajNaloge.Text = "Izlistaj naloge";
            this.btnIzlistajNaloge.UseVisualStyleBackColor = true;
            this.btnIzlistajNaloge.Click += new System.EventHandler(this.btnIzlistajNaloge_Click);
            // 
            // rbtnJesteGlavniAdmin
            // 
            this.rbtnJesteGlavniAdmin.AutoSize = true;
            this.rbtnJesteGlavniAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJesteGlavniAdmin.Location = new System.Drawing.Point(14, 189);
            this.rbtnJesteGlavniAdmin.Name = "rbtnJesteGlavniAdmin";
            this.rbtnJesteGlavniAdmin.Size = new System.Drawing.Size(156, 20);
            this.rbtnJesteGlavniAdmin.TabIndex = 37;
            this.rbtnJesteGlavniAdmin.TabStop = true;
            this.rbtnJesteGlavniAdmin.Text = "Jeste glavni admin";
            this.rbtnJesteGlavniAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnNijeGlavniAdmin
            // 
            this.rbtnNijeGlavniAdmin.AutoSize = true;
            this.rbtnNijeGlavniAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNijeGlavniAdmin.Location = new System.Drawing.Point(15, 215);
            this.rbtnNijeGlavniAdmin.Name = "rbtnNijeGlavniAdmin";
            this.rbtnNijeGlavniAdmin.Size = new System.Drawing.Size(146, 20);
            this.rbtnNijeGlavniAdmin.TabIndex = 38;
            this.rbtnNijeGlavniAdmin.TabStop = true;
            this.rbtnNijeGlavniAdmin.Text = "Nije glavni admin";
            this.rbtnNijeGlavniAdmin.UseVisualStyleBackColor = true;
            // 
            // btnObrisiNalog
            // 
            this.btnObrisiNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNalog.Location = new System.Drawing.Point(14, 456);
            this.btnObrisiNalog.Name = "btnObrisiNalog";
            this.btnObrisiNalog.Size = new System.Drawing.Size(175, 38);
            this.btnObrisiNalog.TabIndex = 39;
            this.btnObrisiNalog.Text = "Obriši nalog";
            this.btnObrisiNalog.UseVisualStyleBackColor = true;
            this.btnObrisiNalog.Click += new System.EventHandler(this.btnObrisiNalog_Click);
            // 
            // btnIzmeniNalog
            // 
            this.btnIzmeniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniNalog.Location = new System.Drawing.Point(194, 456);
            this.btnIzmeniNalog.Name = "btnIzmeniNalog";
            this.btnIzmeniNalog.Size = new System.Drawing.Size(175, 38);
            this.btnIzmeniNalog.TabIndex = 40;
            this.btnIzmeniNalog.Text = "Izmeni nalog";
            this.btnIzmeniNalog.UseVisualStyleBackColor = true;
            this.btnIzmeniNalog.Click += new System.EventHandler(this.btnIzmeniNalog_Click);
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlata.Location = new System.Drawing.Point(12, 138);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(48, 16);
            this.lblPlata.TabIndex = 42;
            this.lblPlata.Text = "Plata:";
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(170, 137);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(200, 20);
            this.txtPlata.TabIndex = 41;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(11, 164);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 16);
            this.lblTelefon.TabIndex = 44;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(170, 163);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 43;
            // 
            // DodavanjeIUklanjanjeAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 505);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.btnIzmeniNalog);
            this.Controls.Add(this.btnObrisiNalog);
            this.Controls.Add(this.rbtnNijeGlavniAdmin);
            this.Controls.Add(this.rbtnJesteGlavniAdmin);
            this.Controls.Add(this.btnIzlistajNaloge);
            this.Controls.Add(this.lbxAdmini);
            this.Controls.Add(this.cbxGodine);
            this.Controls.Add(this.cbxMesec);
            this.Controls.Add(this.cbxDan);
            this.Controls.Add(this.btnNapraviNalog);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "DodavanjeIUklanjanjeAdmina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodavanjeIUklanjanjeAdmina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodavanjeIUklanjanjeAdmina_FormClosing);
            this.Load += new System.EventHandler(this.DodavanjeIUklanjanjeAdmina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGodine;
        private System.Windows.Forms.ComboBox cbxMesec;
        private System.Windows.Forms.ComboBox cbxDan;
        private System.Windows.Forms.Button btnNapraviNalog;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ListBox lbxAdmini;
        private System.Windows.Forms.Button btnIzlistajNaloge;
        private System.Windows.Forms.RadioButton rbtnJesteGlavniAdmin;
        private System.Windows.Forms.RadioButton rbtnNijeGlavniAdmin;
        private System.Windows.Forms.Button btnObrisiNalog;
        private System.Windows.Forms.Button btnIzmeniNalog;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}