using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tambahDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputDataPegawai frmInputDataPegawai = new FormInputDataPegawai();
            frmInputDataPegawai.MdiParent = this;
            frmInputDataPegawai.Show();
        }

        private void tambahDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDataBarang frmInputDataBarang= new FormDataBarang();
            frmInputDataBarang.MdiParent = this;
            frmInputDataBarang.Show();
        }
    }
}
