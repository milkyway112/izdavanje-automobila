namespace Projekat
{
    partial class Logovanje
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
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnKupac = new System.Windows.Forms.RadioButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUlogujSe = new System.Windows.Forms.Button();
            this.lblNemateNalog = new System.Windows.Forms.Label();
            this.lblNapraviteGa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdmin.Location = new System.Drawing.Point(78, 55);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(69, 20);
            this.rbtnAdmin.TabIndex = 0;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnKupac
            // 
            this.rbtnKupac.AutoSize = true;
            this.rbtnKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnKupac.Location = new System.Drawing.Point(185, 55);
            this.rbtnKupac.Name = "rbtnKupac";
            this.rbtnKupac.Size = new System.Drawing.Size(69, 20);
            this.rbtnKupac.TabIndex = 1;
            this.rbtnKupac.TabStop = true;
            this.rbtnKupac.Text = "Kupac";
            this.rbtnKupac.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(154, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(75, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(75, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnUlogujSe
            // 
            this.btnUlogujSe.Location = new System.Drawing.Point(78, 162);
            this.btnUlogujSe.Name = "btnUlogujSe";
            this.btnUlogujSe.Size = new System.Drawing.Size(176, 37);
            this.btnUlogujSe.TabIndex = 6;
            this.btnUlogujSe.Text = "Uloguj se";
            this.btnUlogujSe.UseVisualStyleBackColor = true;
            this.btnUlogujSe.Click += new System.EventHandler(this.btnUlogujSe_Click);
            // 
            // lblNemateNalog
            // 
            this.lblNemateNalog.AutoSize = true;
            this.lblNemateNalog.Location = new System.Drawing.Point(78, 225);
            this.lblNemateNalog.Name = "lblNemateNalog";
            this.lblNemateNalog.Size = new System.Drawing.Size(79, 13);
            this.lblNemateNalog.TabIndex = 7;
            this.lblNemateNalog.Text = "Nemate nalog?";
            // 
            // lblNapraviteGa
            // 
            this.lblNapraviteGa.AutoSize = true;
            this.lblNapraviteGa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNapraviteGa.Location = new System.Drawing.Point(163, 225);
            this.lblNapraviteGa.Name = "lblNapraviteGa";
            this.lblNapraviteGa.Size = new System.Drawing.Size(71, 13);
            this.lblNapraviteGa.TabIndex = 8;
            this.lblNapraviteGa.Text = "Napravite ga.";
            this.lblNapraviteGa.Click += new System.EventHandler(this.lblNapraviteGa_Click);
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 307);
            this.Controls.Add(this.lblNapraviteGa);
            this.Controls.Add(this.lblNemateNalog);
            this.Controls.Add(this.btnUlogujSe);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.rbtnKupac);
            this.Controls.Add(this.rbtnAdmin);
            this.Name = "Logovanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnKupac;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnUlogujSe;
        private System.Windows.Forms.Label lblNemateNalog;
        private System.Windows.Forms.Label lblNapraviteGa;
    }
}