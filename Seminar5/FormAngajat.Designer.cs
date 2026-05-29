namespace Seminar5
{
    partial class FormAngajat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartament = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.chkEstePermanent = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(16, 33);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(203, 22);
            this.txtNume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume:";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(16, 82);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(203, 22);
            this.txtPrenume.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departament:";
            // 
            // cmbDepartament
            // 
            this.cmbDepartament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartament.FormattingEnabled = true;
            this.cmbDepartament.Location = new System.Drawing.Point(16, 130);
            this.cmbDepartament.Name = "cmbDepartament";
            this.cmbDepartament.Size = new System.Drawing.Size(203, 24);
            this.cmbDepartament.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salariu:";
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(16, 182);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(203, 22);
            this.txtSalariu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data angajarii:";
            // 
            // dtpDataAngajarii
            // 
            this.dtpDataAngajarii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAngajarii.Location = new System.Drawing.Point(19, 231);
            this.dtpDataAngajarii.Name = "dtpDataAngajarii";
            this.dtpDataAngajarii.Size = new System.Drawing.Size(200, 22);
            this.dtpDataAngajarii.TabIndex = 9;
            // 
            // chkEstePermanent
            // 
            this.chkEstePermanent.AutoSize = true;
            this.chkEstePermanent.Location = new System.Drawing.Point(19, 260);
            this.chkEstePermanent.Name = "chkEstePermanent";
            this.chkEstePermanent.Size = new System.Drawing.Size(142, 20);
            this.chkEstePermanent.TabIndex = 10;
            this.chkEstePermanent.Text = "Angajat permanent";
            this.chkEstePermanent.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(83, 286);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(175, 286);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 12;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // FormAngajat
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(382, 333);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkEstePermanent);
            this.Controls.Add(this.dtpDataAngajarii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepartament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Angajat";
            this.Load += new System.EventHandler(this.FormAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataAngajarii;
        private System.Windows.Forms.CheckBox chkEstePermanent;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}