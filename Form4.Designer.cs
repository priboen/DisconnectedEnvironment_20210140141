namespace Activity_6
{
    partial class FormDataStatusMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.txtNim = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(552, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nomor Induk Mahasiswa (NIM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tahun Masuk";
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(253, 275);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(192, 21);
            this.cbxNama.TabIndex = 6;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(474, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(474, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(474, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif",
            "DropOut"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(253, 327);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(192, 21);
            this.cbxStatusMahasiswa.TabIndex = 11;
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(253, 354);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(192, 21);
            this.cbxTahunMasuk.TabIndex = 12;
            // 
            // txtNim
            // 
            this.txtNim.AutoSize = true;
            this.txtNim.Location = new System.Drawing.Point(253, 308);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(38, 13);
            this.txtNim.TabIndex = 13;
            this.txtNim.Text = "txtNIM";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(293, 234);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(64, 13);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "ID STATUS";
            // 
            // FormDataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 443);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataStatusMahasiswa";
            this.Text = "Data Status Mahasiswa";
            this.Load += new System.EventHandler(this.FormDataStatusMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Label txtNim;
        private System.Windows.Forms.Label labelStatus;
    }
}