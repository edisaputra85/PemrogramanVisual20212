
namespace Form_App
{
    partial class FormDataBarang
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKodeBarang = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblHargaBeli = new System.Windows.Forms.Label();
            this.textBoxkodeBarang = new System.Windows.Forms.TextBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaBeli = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.comboBoxSatuan = new System.Windows.Forms.ComboBox();
            this.buttonTambahData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Tambah Data Barang";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05766F));
            this.tableLayoutPanel1.Controls.Add(this.lblKodeBarang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNamaBarang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHarga, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHargaBeli, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxkodeBarang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNamaBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHargaBeli, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 203);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblKodeBarang
            // 
            this.lblKodeBarang.AutoSize = true;
            this.lblKodeBarang.Location = new System.Drawing.Point(3, 0);
            this.lblKodeBarang.Name = "lblKodeBarang";
            this.lblKodeBarang.Size = new System.Drawing.Size(102, 20);
            this.lblKodeBarang.TabIndex = 0;
            this.lblKodeBarang.Text = "Kode Barang";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(3, 54);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(107, 20);
            this.lblNamaBarang.TabIndex = 1;
            this.lblNamaBarang.Text = "Nama Barang";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(3, 110);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(76, 20);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Kuantitas";
            // 
            // lblHargaBeli
            // 
            this.lblHargaBeli.AutoSize = true;
            this.lblHargaBeli.Location = new System.Drawing.Point(3, 161);
            this.lblHargaBeli.Name = "lblHargaBeli";
            this.lblHargaBeli.Size = new System.Drawing.Size(83, 20);
            this.lblHargaBeli.TabIndex = 3;
            this.lblHargaBeli.Text = "Harga Beli";
            // 
            // textBoxkodeBarang
            // 
            this.textBoxkodeBarang.Location = new System.Drawing.Point(218, 3);
            this.textBoxkodeBarang.Name = "textBoxkodeBarang";
            this.textBoxkodeBarang.Size = new System.Drawing.Size(270, 26);
            this.textBoxkodeBarang.TabIndex = 6;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(218, 57);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(270, 26);
            this.textBoxNamaBarang.TabIndex = 7;
            // 
            // textBoxHargaBeli
            // 
            this.textBoxHargaBeli.Location = new System.Drawing.Point(218, 164);
            this.textBoxHargaBeli.Name = "textBoxHargaBeli";
            this.textBoxHargaBeli.Size = new System.Drawing.Size(270, 26);
            this.textBoxHargaBeli.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.18439F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8156F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxQty, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSatuan, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 45);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(3, 3);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(174, 26);
            this.textBoxQty.TabIndex = 0;
            // 
            // comboBoxSatuan
            // 
            this.comboBoxSatuan.FormattingEnabled = true;
            this.comboBoxSatuan.Items.AddRange(new object[] {
            "PCS",
            "KOTAK",
            "LEMBAR",
            "SET"});
            this.comboBoxSatuan.Location = new System.Drawing.Point(183, 3);
            this.comboBoxSatuan.Name = "comboBoxSatuan";
            this.comboBoxSatuan.Size = new System.Drawing.Size(96, 28);
            this.comboBoxSatuan.TabIndex = 1;
            // 
            // buttonTambahData
            // 
            this.buttonTambahData.Location = new System.Drawing.Point(205, 315);
            this.buttonTambahData.Name = "buttonTambahData";
            this.buttonTambahData.Size = new System.Drawing.Size(143, 48);
            this.buttonTambahData.TabIndex = 2;
            this.buttonTambahData.Text = "Tambah Data";
            this.buttonTambahData.UseVisualStyleBackColor = true;
            this.buttonTambahData.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.buttonTambahData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormDataBarang";
            this.Text = "Form Input Data Barang";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblKodeBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblHargaBeli;
        private System.Windows.Forms.TextBox textBoxkodeBarang;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxHargaBeli;
        private System.Windows.Forms.Button buttonTambahData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.ComboBox comboBoxSatuan;
    }
}