
namespace Form_App
{
    partial class FormInputDataPegawai
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
            this.labelForm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.textBoxTmptLahir = new System.Windows.Forms.TextBox();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAgama = new System.Windows.Forms.ComboBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.buttonTambahData = new System.Windows.Forms.Button();
            this.dataGridViewDataPegawai = new System.Windows.Forms.DataGridView();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.Location = new System.Drawing.Point(92, 19);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(399, 32);
            this.labelForm.TabIndex = 0;
            this.labelForm.Text = "Form Tambah Data Pegawai";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNIK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTmptLahir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTglLahir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAgama, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlamat, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 229);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pegawai";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(124, 3);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(312, 26);
            this.textBoxNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tempat Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Agama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alamat";
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Location = new System.Drawing.Point(124, 33);
            this.textBoxNIK.MaxLength = 16;
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(312, 26);
            this.textBoxNIK.TabIndex = 9;
            // 
            // textBoxTmptLahir
            // 
            this.textBoxTmptLahir.Location = new System.Drawing.Point(124, 65);
            this.textBoxTmptLahir.Name = "textBoxTmptLahir";
            this.textBoxTmptLahir.Size = new System.Drawing.Size(312, 26);
            this.textBoxTmptLahir.TabIndex = 10;
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(124, 97);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(312, 26);
            this.dateTimePickerTglLahir.TabIndex = 11;
            // 
            // comboBoxAgama
            // 
            this.comboBoxAgama.FormattingEnabled = true;
            this.comboBoxAgama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Protestan",
            "Hindu",
            "Budha",
            "Konghucu"});
            this.comboBoxAgama.Location = new System.Drawing.Point(124, 126);
            this.comboBoxAgama.Name = "comboBoxAgama";
            this.comboBoxAgama.Size = new System.Drawing.Size(200, 28);
            this.comboBoxAgama.TabIndex = 12;
            this.comboBoxAgama.Text = "Islam";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(124, 159);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(312, 56);
            this.textBoxAlamat.TabIndex = 13;
            // 
            // buttonTambahData
            // 
            this.buttonTambahData.Location = new System.Drawing.Point(46, 301);
            this.buttonTambahData.Name = "buttonTambahData";
            this.buttonTambahData.Size = new System.Drawing.Size(134, 43);
            this.buttonTambahData.TabIndex = 2;
            this.buttonTambahData.Text = "Tambah Data";
            this.buttonTambahData.UseVisualStyleBackColor = true;
            this.buttonTambahData.Click += new System.EventHandler(this.buttonTambahData_Click);
            // 
            // dataGridViewDataPegawai
            // 
            this.dataGridViewDataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataPegawai.Location = new System.Drawing.Point(12, 380);
            this.dataGridViewDataPegawai.Name = "dataGridViewDataPegawai";
            this.dataGridViewDataPegawai.RowHeadersWidth = 62;
            this.dataGridViewDataPegawai.RowTemplate.Height = 28;
            this.dataGridViewDataPegawai.Size = new System.Drawing.Size(554, 142);
            this.dataGridViewDataPegawai.TabIndex = 3;
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(187, 301);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(121, 43);
            this.buttonRefreshData.TabIndex = 4;
            this.buttonRefreshData.Text = "Refresh Data";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataSource = typeof(Form_App.Pegawai);
            // 
            // pegawaiBindingSource1
            // 
            this.pegawaiBindingSource1.DataSource = typeof(Form_App.Pegawai);
            // 
            // FormInputDataPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.dataGridViewDataPegawai);
            this.Controls.Add(this.buttonTambahData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormInputDataPegawai";
            this.Text = "Input Data Pegawai";
            this.Load += new System.EventHandler(this.FormInputDataPegawai_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNIK;
        private System.Windows.Forms.TextBox textBoxTmptLahir;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.ComboBox comboBoxAgama;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Button buttonTambahData;
        private System.Windows.Forms.DataGridView dataGridViewDataPegawai;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private System.Windows.Forms.BindingSource pegawaiBindingSource1;
        private System.Windows.Forms.Button buttonRefreshData;
    }
}

