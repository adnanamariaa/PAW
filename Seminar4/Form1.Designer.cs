namespace Seminar4
{
    partial class Form1
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.grpDateContact = new System.Windows.Forms.GroupBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNotificari = new System.Windows.Forms.CheckBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.lstContacte = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpDateContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(6, 50);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(199, 22);
            this.txtNume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(6, 75);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(64, 16);
            this.lblPrenume.TabIndex = 4;
            this.lblPrenume.Text = "Prenume:";
            // 
            // grpDateContact
            // 
            this.grpDateContact.Controls.Add(this.btnAdauga);
            this.grpDateContact.Controls.Add(this.chkNotificari);
            this.grpDateContact.Controls.Add(this.label3);
            this.grpDateContact.Controls.Add(this.label1);
            this.grpDateContact.Controls.Add(this.txtEmail);
            this.grpDateContact.Controls.Add(this.txtTelefon);
            this.grpDateContact.Controls.Add(this.txtPrenume);
            this.grpDateContact.Controls.Add(this.lblPrenume);
            this.grpDateContact.Controls.Add(this.txtNume);
            this.grpDateContact.Controls.Add(this.label2);
            this.grpDateContact.Location = new System.Drawing.Point(12, 12);
            this.grpDateContact.Name = "grpDateContact";
            this.grpDateContact.Size = new System.Drawing.Size(260, 380);
            this.grpDateContact.TabIndex = 5;
            this.grpDateContact.TabStop = false;
            this.grpDateContact.Text = "Date contact";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(6, 94);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(199, 22);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(6, 138);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(199, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // chkNotificari
            // 
            this.chkNotificari.AutoSize = true;
            this.chkNotificari.Location = new System.Drawing.Point(6, 226);
            this.chkNotificari.Name = "chkNotificari";
            this.chkNotificari.Size = new System.Drawing.Size(120, 20);
            this.chkNotificari.TabIndex = 10;
            this.chkNotificari.Text = "Notificari active";
            this.chkNotificari.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(0, 277);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(200, 30);
            this.btnAdauga.TabIndex = 11;
            this.btnAdauga.Text = "Adauga contact";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contacte";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(290, 59);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(280, 22);
            this.txtCautare.TabIndex = 7;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // lstContacte
            // 
            this.lstContacte.FormattingEnabled = true;
            this.lstContacte.ItemHeight = 16;
            this.lstContacte.Location = new System.Drawing.Point(290, 87);
            this.lstContacte.Name = "lstContacte";
            this.lstContacte.Size = new System.Drawing.Size(280, 196);
            this.lstContacte.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cauta dupa nume...";
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(290, 289);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(174, 30);
            this.btnSterge.TabIndex = 10;
            this.btnSterge.Text = "Sterge contact";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(300, 376);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstContacte);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpDateContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registru Contacte";
            this.grpDateContact.ResumeLayout(false);
            this.grpDateContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.GroupBox grpDateContact;
        private System.Windows.Forms.CheckBox chkNotificari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.ListBox lstContacte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblStatus;
    }
}

