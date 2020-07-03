namespace Projekat
{
    partial class Kupci
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
            this.btnIzmeniNalog = new System.Windows.Forms.Button();
            this.btnObrisiNalog = new System.Windows.Forms.Button();
            this.btnIzlistajNaloge = new System.Windows.Forms.Button();
            this.lbxKupci = new System.Windows.Forms.ListBox();
            this.cbxGodine = new System.Windows.Forms.ComboBox();
            this.cbxMesec = new System.Windows.Forms.ComboBox();
            this.cbxDan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzmeniNalog
            // 
            this.btnIzmeniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniNalog.Location = new System.Drawing.Point(194, 409);
            this.btnIzmeniNalog.Name = "btnIzmeniNalog";
            this.btnIzmeniNalog.Size = new System.Drawing.Size(175, 38);
            this.btnIzmeniNalog.TabIndex = 63;
            this.btnIzmeniNalog.Text = "Izmeni nalog";
            this.btnIzmeniNalog.UseVisualStyleBackColor = true;
            this.btnIzmeniNalog.Click += new System.EventHandler(this.btnIzmeniNalog_Click);
            // 
            // btnObrisiNalog
            // 
            this.btnObrisiNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNalog.Location = new System.Drawing.Point(14, 409);
            this.btnObrisiNalog.Name = "btnObrisiNalog";
            this.btnObrisiNalog.Size = new System.Drawing.Size(175, 38);
            this.btnObrisiNalog.TabIndex = 62;
            this.btnObrisiNalog.Text = "Obriši nalog";
            this.btnObrisiNalog.UseVisualStyleBackColor = true;
            this.btnObrisiNalog.Click += new System.EventHandler(this.btnObrisiNalog_Click);
            // 
            // btnIzlistajNaloge
            // 
            this.btnIzlistajNaloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajNaloge.Location = new System.Drawing.Point(14, 238);
            this.btnIzlistajNaloge.Name = "btnIzlistajNaloge";
            this.btnIzlistajNaloge.Size = new System.Drawing.Size(355, 38);
            this.btnIzlistajNaloge.TabIndex = 59;
            this.btnIzlistajNaloge.Text = "Izlistaj naloge";
            this.btnIzlistajNaloge.UseVisualStyleBackColor = true;
            this.btnIzlistajNaloge.Click += new System.EventHandler(this.btnIzlistajNaloge_Click);
            // 
            // lbxKupci
            // 
            this.lbxKupci.FormattingEnabled = true;
            this.lbxKupci.Location = new System.Drawing.Point(14, 282);
            this.lbxKupci.Name = "lbxKupci";
            this.lbxKupci.Size = new System.Drawing.Size(355, 121);
            this.lbxKupci.TabIndex = 58;
            this.lbxKupci.SelectedValueChanged += new System.EventHandler(this.lbxKupci_SelectedValueChanged);
            // 
            // cbxGodine
            // 
            this.cbxGodine.DropDownHeight = 60;
            this.cbxGodine.FormattingEnabled = true;
            this.cbxGodine.IntegralHeight = false;
            this.cbxGodine.Location = new System.Drawing.Point(297, 117);
            this.cbxGodine.Name = "cbxGodine";
            this.cbxGodine.Size = new System.Drawing.Size(72, 21);
            this.cbxGodine.TabIndex = 80;
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
            this.cbxMesec.Location = new System.Drawing.Point(221, 117);
            this.cbxMesec.Name = "cbxMesec";
            this.cbxMesec.Size = new System.Drawing.Size(69, 21);
            this.cbxMesec.TabIndex = 79;
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
            this.cbxDan.Location = new System.Drawing.Point(169, 117);
            this.cbxDan.Name = "cbxDan";
            this.cbxDan.Size = new System.Drawing.Size(46, 21);
            this.cbxDan.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 38);
            this.button1.TabIndex = 77;
            this.button1.Text = "Napravi nalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(10, 116);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(117, 16);
            this.lblDatumRodjenja.TabIndex = 76;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(11, 90);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 16);
            this.lblTelefon.TabIndex = 75;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(11, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 74;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 142);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 16);
            this.lblUsername.TabIndex = 73;
            this.lblUsername.Text = "Username:";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbg.Location = new System.Drawing.Point(10, 64);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(53, 16);
            this.lblJmbg.TabIndex = 72;
            this.lblJmbg.Text = "JMBG:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(10, 38);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 16);
            this.lblPrezime.TabIndex = 71;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(11, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(37, 16);
            this.lblIme.TabIndex = 70;
            this.lblIme.Text = "Ime:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(169, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 69;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(169, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 68;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(169, 90);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 67;
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(169, 64);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(200, 20);
            this.txtJmbg.TabIndex = 66;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(169, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 65;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(169, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 64;
            // 
            // Kupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 458);
            this.Controls.Add(this.cbxGodine);
            this.Controls.Add(this.cbxMesec);
            this.Controls.Add(this.cbxDan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtJmbg);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnIzmeniNalog);
            this.Controls.Add(this.btnObrisiNalog);
            this.Controls.Add(this.btnIzlistajNaloge);
            this.Controls.Add(this.lbxKupci);
            this.Name = "Kupci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kupci_FormClosing);
            this.Load += new System.EventHandler(this.Kupci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeniNalog;
        private System.Windows.Forms.Button btnObrisiNalog;
        private System.Windows.Forms.Button btnIzlistajNaloge;
        private System.Windows.Forms.ListBox lbxKupci;
        private System.Windows.Forms.ComboBox cbxGodine;
        private System.Windows.Forms.ComboBox cbxMesec;
        private System.Windows.Forms.ComboBox cbxDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
    }
}