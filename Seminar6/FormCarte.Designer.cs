namespace Seminar6
{
    partial class FormCarte
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.numAn = new System.Windows.Forms.NumericUpDown();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.numPret = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.epCarte = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "An:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pret:";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(73, 13);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(121, 22);
            this.txtTitlu.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(73, 36);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(121, 22);
            this.txtAutor.TabIndex = 6;
            // 
            // numAn
            // 
            this.numAn.Location = new System.Drawing.Point(73, 65);
            this.numAn.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numAn.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAn.Name = "numAn";
            this.numAn.Size = new System.Drawing.Size(120, 22);
            this.numAn.TabIndex = 7;
            this.numAn.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // cmbGen
            // 
            this.cmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Location = new System.Drawing.Point(73, 92);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(121, 24);
            this.cmbGen.TabIndex = 8;
            // 
            // numPret
            // 
            this.numPret.DecimalPlaces = 2;
            this.numPret.Location = new System.Drawing.Point(73, 126);
            this.numPret.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPret.Name = "numPret";
            this.numPret.Size = new System.Drawing.Size(120, 22);
            this.numPret.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(31, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 42);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(128, 181);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(85, 43);
            this.btnAnuleaza.TabIndex = 11;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // epCarte
            // 
            this.epCarte.ContainerControl = this;
            // 
            // FormCarte
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numPret);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.numAn);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            this.Load += new System.EventHandler(this.FormCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.NumericUpDown numAn;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.NumericUpDown numPret;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider epCarte;
    }
}