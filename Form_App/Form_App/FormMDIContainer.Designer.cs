
namespace Form_App
{
    partial class FormMDIContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPegawaiToolStripMenuItem,
            this.dataBarangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem});
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataBarangToolStripMenuItem});
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.dataBarangToolStripMenuItem.Text = "Data Barang";
            // 
            // inputDataPegawaiToolStripMenuItem
            // 
            this.inputDataPegawaiToolStripMenuItem.Name = "inputDataPegawaiToolStripMenuItem";
            this.inputDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inputDataPegawaiToolStripMenuItem.Text = "Input Data Pegawai";
            this.inputDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.inputDataPegawaiToolStripMenuItem_Click);
            // 
            // inputDataBarangToolStripMenuItem
            // 
            this.inputDataBarangToolStripMenuItem.Name = "inputDataBarangToolStripMenuItem";
            this.inputDataBarangToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inputDataBarangToolStripMenuItem.Text = "Input Data Barang";
            this.inputDataBarangToolStripMenuItem.Click += new System.EventHandler(this.inputDataBarangToolStripMenuItem_Click);
            // 
            // FormMDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormMDIContainer";
            this.Text = "Point of Sales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataBarangToolStripMenuItem;
    }
}