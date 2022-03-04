using System;
using System.Collections;
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
    public partial class FormInputDataPegawai : Form
    {
        ArrayList _daftarPegawai = new System.Collections.ArrayList();
        private void buttonTambahData_Click(object sender, EventArgs e)
        {
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama = textBoxNama.Text;
            dataPegawai.nik = textBoxNIK.Text;
            dataPegawai.tmpt_lahir = textBoxTmptLahir.Text;
            dataPegawai.tgl_lahir = dateTimePickerTglLahir.Value.ToString("dd-MM-yyyy");
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;

            //tampilkan data menggunakan message box -> sbg pengganti penyimpanan data ke DB
            MessageBox.Show("Nama : " + dataPegawai.nama);

            //Menampilkan data di datagridview
            _daftarPegawai.Add(dataPegawai);
            DataTable dt = new DataTable();
            dataGridViewDataPegawai.DataSource = null;
            dataGridViewDataPegawai.DataSource = _daftarPegawai;


            //ArrayList daftarPegawai = new System.Collections.ArrayList();
            //DaftarPegawai.Add(new Pegawai("abcd","efgh","jikl" ));

            // DaftarPegawai.Add(dataPegawai);
            //DaftarPegawai.Add(new MyObject(3, "Object C"));
            //dataGridViewDataPegawai.DataSource = DaftarPegawai;
            //dataGridViewDataPegawai.Refresh();
        }

        public FormInputDataPegawai()
        {
            InitializeComponent();
        }

        private void FormInputDataPegawai_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            dataGridViewDataPegawai.DataSource = null;
            dataGridViewDataPegawai.DataSource = _daftarPegawai;
        }
    }
}
