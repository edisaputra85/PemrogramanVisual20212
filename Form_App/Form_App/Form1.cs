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
using MySql.Data.MySqlClient;

namespace Form_App
{
    public partial class FormInputDataPegawai : Form
    {
        ArrayList _daftarPegawai = new System.Collections.ArrayList();
        int id_pegawai;
        private void buttonTambahData_Click(object sender, EventArgs e)
        {
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama = textBoxNama.Text;
            dataPegawai.nik = textBoxNIK.Text;
            dataPegawai.tmpt_lahir = textBoxTmptLahir.Text;
            dataPegawai.tgl_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");//yyyy-mm-dd
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;

            //tampilkan data menggunakan message box -> sbg pengganti penyimpanan data ke DB
            

            //Menampilkan data di datagridview
           // _daftarPegawai.Add(dataPegawai);
            //DataTable dt = new DataTable();
            //dataGridViewDataPegawai.DataSource = null;
            //dataGridViewDataPegawai.DataSource = _daftarPegawai;

            //insert ke database
            String response;
            response = dataPegawai.Insert();
            if (response == null) MessageBox.Show("Insert data sukses");
            else MessageBox.Show("Insert data gagal " + response);

            reloadData();
        }

        public FormInputDataPegawai()
        {
            InitializeComponent();
        }

        private void FormInputDataPegawai_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama = textBoxNama.Text;
            dataPegawai.nik = textBoxNIK.Text;
            dataPegawai.tmpt_lahir = textBoxTmptLahir.Text;
            dataPegawai.tgl_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");//yyyy-mm-dd
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;
            dataPegawai.id = id_pegawai;
            response = dataPegawai.Update();
            if (response == null) MessageBox.Show("Sukses");
            else MessageBox.Show(response);
            reloadData();  
        }

        private void reloadData()
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = pegawai.ReadAll();
            dataGridViewDataPegawai.DataSource = dt;
            dataGridViewDataPegawai.Show();
        }

        private void dataGridViewDataPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewDataPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDataPegawai.Rows[selectedrowindex];
       
            textBoxNama.Text = Convert.ToString(selectedRow.Cells["nama"].Value);
            textBoxNIK.Text = Convert.ToString(selectedRow.Cells["NIK"].Value);
            textBoxTmptLahir.Text = Convert.ToString(selectedRow.Cells["tmpt_lahir"].Value);
            dateTimePickerTglLahir.Value = Convert.ToDateTime(selectedRow.Cells["tgl_lahir"].Value);
            comboBoxAgama.Text = Convert.ToString(selectedRow.Cells["agama"].Value);
            textBoxAlamat.Text = Convert.ToString(selectedRow.Cells["alamat"].Value);
            id_pegawai = Convert.ToInt32(selectedRow.Cells["id_pegawai"].Value);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.id = id_pegawai;
            response = dataPegawai.Delete();
            if (response == null) MessageBox.Show("Sukses");
            else MessageBox.Show(response);
            reloadData();
        }
    }
}
