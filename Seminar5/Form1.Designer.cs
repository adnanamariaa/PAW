namespace Seminar5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltruDepartament = new System.Windows.Forms.ComboBox();
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtru departament:";
            // 
            // cmbFiltruDepartament
            // 
            this.cmbFiltruDepartament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltruDepartament.FormattingEnabled = true;
            this.cmbFiltruDepartament.Location = new System.Drawing.Point(148, 13);
            this.cmbFiltruDepartament.Name = "cmbFiltruDepartament";
            this.cmbFiltruDepartament.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltruDepartament.TabIndex = 1;
            this.cmbFiltruDepartament.Click += new System.EventHandler(this.cmbFiltruDepartament_SelectedIndexChanged);
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.AllowUserToAddRows = false;
            this.dgvAngajati.AllowUserToDeleteRows = false;
            this.dgvAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Location = new System.Drawing.Point(27, 56);
            this.dgvAngajati.MultiSelect = false;
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.ReadOnly = true;
            this.dgvAngajati.RowHeadersVisible = false;
            this.dgvAngajati.RowHeadersWidth = 51;
            this.dgvAngajati.RowTemplate.Height = 24;
            this.dgvAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngajati.Size = new System.Drawing.Size(700, 250);
            this.dgvAngajati.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(27, 330);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(114, 43);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(148, 330);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(121, 43);
            this.btnEditeaza.TabIndex = 4;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(275, 330);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(99, 43);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 397);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dgvAngajati);
            this.Controls.Add(this.cmbFiltruDepartament);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune Angajati";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltruDepartament;
        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblStatus;
    }
}

