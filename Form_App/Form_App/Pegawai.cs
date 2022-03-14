using System;
using System.Collections.Generic;
using System.Data;
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
        public int id { set; get; }

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

        public DataTable ReadAll()
        {
            DataTable dt = new DataTable();
                //cara 1
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbpegawai", conn))
                {
                    try
                        {
                        conn.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        dt.Load(rdr);
                        }
                    catch(Exception e)
                        {

                        }
                }

                /*cara2
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM tbpegawai";
                {
                    //sebaiknya pakai blok try catch
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                */
            
            return dt;
        }

        public string Update()
        {
            string result = null;
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE tbpegawai set nama=@nama,NIK=@NIK,tmpt_lahir=@tmpt_lahir," +
                    "tgl_lahir=@tgl_lahir,agama=@agama,alamat=@alamat WHERE id_pegawai=@id";
                cmd.Parameters.AddWithValue("@nama", this.nama);
                cmd.Parameters.AddWithValue("@NIK", this.nik);
                cmd.Parameters.AddWithValue("@tmpt_lahir", this.tmpt_lahir);
                cmd.Parameters.AddWithValue("@tgl_lahir", this.tgl_lahir);
                cmd.Parameters.AddWithValue("@agama", this.agama);
                cmd.Parameters.AddWithValue("@alamat", this.alamat);
                cmd.Parameters.AddWithValue("@id", this.id);
                try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
            return result;
        }
        
        public string Delete()
        {
            string result = null;
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbpegawai WHERE id_pegawai=@id ", conn))
                {
                    cmd.Parameters.AddWithValue("@id",this.id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            return result;
        }
        
    }
}
