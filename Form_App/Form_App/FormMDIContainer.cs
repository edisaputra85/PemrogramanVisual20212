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
    public partial class FormMDIContainer : Form
    {
        public FormMDIContainer()
        {
            InitializeComponent();
        }

        private void inputDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create objek form
            FormInputDataPegawai frmInputPegawai = new FormInputDataPegawai();
            //set mdiparent objek form yang baru dibuat
            frmInputPegawai.MdiParent = this;
            //tampilkan objek form
            frmInputPegawai.Show();
        }

        private void inputDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create objek form
            FormDataBarang frmDataBarang = new FormDataBarang();
            //set mdiparent objek form yang baru dibuat
            frmDataBarang.MdiParent = this;
            //tampilkan objek form
            frmDataBarang.Show();
        }
    }
}
