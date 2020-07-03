namespace Projekat
{
    partial class PravljenjeKorisnickogNaloga
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.btnNapraviNalog = new System.Windows.Forms.Button();
            this.cbxDan = new System.Windows.Forms.ComboBox();
            this.cbxMesec = new System.Windows.Forms.ComboBox();
            this.cbxGodine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(171, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(171, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(171, 90);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(171, 64);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(200, 20);
            this.txtJmbg.TabIndex = 2;
            this.txtJmbg.TextChanged += new System.EventHandler(this.txtJmbg_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(171, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(13, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(37, 16);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            this.lblIme.Click += new System.EventHandler(this.lblIme_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(12, 38);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 16);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime:";
            this.lblPrezime.Click += new System.EventHandler(this.lblPrezime_Click);
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbg.Location = new System.Drawing.Point(12, 64);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(53, 16);
            this.lblJmbg.TabIndex = 9;
            this.lblJmbg.Text = "JMBG:";
            this.lblJmbg.Click += new System.EventHandler(this.lblJmbg_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 142);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 16);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(13, 90);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 16);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Click += new System.EventHandler(this.lblTelefon_Click);
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(12, 116);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(117, 16);
            this.lblDatumRodjenja.TabIndex = 13;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            this.lblDatumRodjenja.Click += new System.EventHandler(this.lblDatumRodjenja_Click);
            // 
            // btnNapraviNalog
            // 
            this.btnNapraviNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviNalog.Location = new System.Drawing.Point(16, 194);
            this.btnNapraviNalog.Name = "btnNapraviNalog";
            this.btnNapraviNalog.Size = new System.Drawing.Size(355, 38);
            this.btnNapraviNalog.TabIndex = 14;
            this.btnNapraviNalog.Text = "Napravi nalog";
            this.btnNapraviNalog.UseVisualStyleBackColor = true;
            this.btnNapraviNalog.Click += new System.EventHandler(this.btnNapraviNalog_Click);
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
            this.cbxDan.Location = new System.Drawing.Point(171, 117);
            this.cbxDan.Name = "cbxDan";
            this.cbxDan.Size = new System.Drawing.Size(46, 21);
            this.cbxDan.TabIndex = 15;
            this.cbxDan.SelectedIndexChanged += new System.EventHandler(this.cbxDan_SelectedIndexChanged);
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
            this.cbxMesec.Location = new System.Drawing.Point(223, 117);
            this.cbxMesec.Name = "cbxMesec";
            this.cbxMesec.Size = new System.Drawing.Size(69, 21);
            this.cbxMesec.TabIndex = 16;
            this.cbxMesec.SelectedIndexChanged += new System.EventHandler(this.cbxMesec_SelectedIndexChanged);
            this.cbxMesec.SelectedValueChanged += new System.EventHandler(this.cbxMesec_SelectedValueChanged);
            // 
            // cbxGodine
            // 
            this.cbxGodine.DropDownHeight = 60;
            this.cbxGodine.FormattingEnabled = true;
            this.cbxGodine.IntegralHeight = false;
            this.cbxGodine.Location = new System.Drawing.Point(299, 117);
            this.cbxGodine.Name = "cbxGodine";
            this.cbxGodine.Size = new System.Drawing.Size(72, 21);
            this.cbxGodine.TabIndex = 17;
            this.cbxGodine.SelectedIndexChanged += new System.EventHandler(this.cbxGodine_SelectedIndexChanged);
            this.cbxGodine.SelectedValueChanged += new System.EventHandler(this.cbxGodine_SelectedValueChanged);
            // 
            // PravljenjeKorisnickogNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 241);
            this.Controls.Add(this.cbxGodine);
            this.Controls.Add(this.cbxMesec);
            this.Controls.Add(this.cbxDan);
            this.Controls.Add(this.btnNapraviNalog);
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
            this.Name = "PravljenjeKorisnickogNaloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PravljenjeKorisnickogNaloga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PravljenjeKorisnickogNaloga_FormClosing);
            this.Load += new System.EventHandler(this.PravljenjeKorisnickogNaloga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Button btnNapraviNalog;
        private System.Windows.Forms.ComboBox cbxDan;
        private System.Windows.Forms.ComboBox cbxMesec;
        private System.Windows.Forms.ComboBox cbxGodine;
    }
}