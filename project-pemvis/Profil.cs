using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pemvis
{
    public partial class Profil : Form
    {
        private int userId;
        public Profil(int userIdFromCaller)
        {
            InitializeComponent();
            this.userId = userIdFromCaller;
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama, nohp, alamat, tanggal_lahir FROM profile WHERE user_id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNama.Text = reader["nama"].ToString();
                        txtNohp.Text = reader["nohp"].ToString();
                        txtAlamat.Text = reader["alamat"].ToString();
                        txtTanggalLahir.Text = reader["tanggal_lahir"].ToString(); // atau parse ke DatePicker
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data profil: " + ex.Message);
                }
            }
        }

        private void btnUpdateProfil_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string nohp = txtNohp.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string tanggalLahir = txtTanggalLahir.Text; // pastikan pakai DatePicker atau format valid

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    // Cek apakah data profile sudah ada
                    string checkQuery = "SELECT id FROM profile WHERE user_id = @UserId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@UserId", userId);
                    object result = checkCmd.ExecuteScalar();

                    string query;
                    if (result != null)
                    {
                        // Sudah ada → update
                        query = @"UPDATE profile 
                          SET nama = @Nama, nohp = @Nohp, alamat = @Alamat, tanggal_lahir = @TanggalLahir 
                          WHERE user_id = @UserId";
                    }
                    else
                    {
                        // Belum ada → insert
                        query = @"INSERT INTO profile (user_id, nama, nohp, alamat, tanggal_lahir) 
                          VALUES (@UserId, @Nama, @Nohp, @Alamat, @TanggalLahir)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Nama", nama);
                    cmd.Parameters.AddWithValue("@Nohp", nohp);
                    cmd.Parameters.AddWithValue("@Alamat", alamat);
                    cmd.Parameters.AddWithValue("@TanggalLahir", tanggalLahir);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                }
            }
        }
    }
}
