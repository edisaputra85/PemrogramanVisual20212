using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Form_App
{
    class Pegawai : Connection
    {
        public String nama { set; get; }
        public String nik { set; get; }
        public String tmpt_lahir { set; get; }
        public String tgl_lahir { set; get; }
        public String agama { set; get; }
        public String alamat { set; get; }

        MySqlConnection conn;
        MySqlCommand cmd;


        public Pegawai(){
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();

        }

        public String Insert()
        {
            String error = null;
            //membuka koneksi ke database melalui objek conn
            conn.Open();
            //membuat objek command sql yang dihubungkan dengan koneksi datbase melalui objek conn (neghubungkan objek sql command dengan database)
            cmd = conn.CreateCommand();
            //membuat sql statement
            cmd.CommandText = "INSERT INTO tbpegawai (nama,NIK,tmpt_lahir,tgl_lahir,agama,alamat)" +
                "VALUES (@nama,@NIK,@tmpt_lahir,@tgl_lahir,@agama,@alamat)";
            cmd.Parameters.AddWithValue("@nama", this.nama);
            cmd.Parameters.AddWithValue("@NIK", this.nik);
            cmd.Parameters.AddWithValue("@tmpt_lahir", this.tmpt_lahir);
            cmd.Parameters.AddWithValue("@tgl_lahir", this.tgl_lahir);
            cmd.Parameters.AddWithValue("@agama", this.agama);
            cmd.Parameters.AddWithValue("@alamat", this.alamat);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                error = e.Message;
            }
            return error;
        }

       
    }
}
