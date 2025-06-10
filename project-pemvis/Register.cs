using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_pemvis
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Email placeholder
            txtEmail.Text = "Masukkan Email";
            txtEmail.ForeColor = Color.Gray;

            // Password placeholder
            txtPassword.Text = "Masukkan Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;

            txtKonfirPassword.Text = "Konfirmasi Password";
            txtKonfirPassword.ForeColor = Color.Gray;
            txtKonfirPassword.UseSystemPasswordChar = false;
        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form Login
            Login loginForm = new Login();

            // Menampilkan Form Register
            loginForm.Show();

            // Opsional: Menyembunyikan Form saat ini jika tidak diperlukan lagi
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text != "Masukkan Password" ? txtPassword.Text : "";
            string konfirmasi = txtKonfirPassword.Text != "Konfirmasi Password" ? txtKonfirPassword.Text : "";

            if (string.IsNullOrWhiteSpace(username) || username == "Masukkan Username" ||
                string.IsNullOrWhiteSpace(email) || email == "Masukkan Email" ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(konfirmasi))
            {
                MessageBox.Show("Semua kolom harus diisi dengan benar!");
                return;
            }

            if (password != konfirmasi)
            {
                MessageBox.Show("Password dan Konfirmasi tidak cocok!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    // ✅ Cek apakah email sudah terdaftar
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Email sudah terdaftar, silakan gunakan email lain.");
                        return;
                    }

                    // ✅ Simpan user baru
                    string query = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password); // Belum dienkripsi
                    cmd.ExecuteNonQuery();

                    // ✅ Tampilkan pesan dan buka Login form
                    MessageBox.Show("Data berhasil disimpan, silahkan Login!");

                    // Buka Login.cs
                    Login loginForm = new Login();
                    loginForm.Show();

                    // Tutup form registrasi
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan: " + ex.Message);
                }
            }
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Masukkan Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Masukkan Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Masukkan Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = true; // Aktifkan bintang
            }
        }

        private void txtPassword_MouseLeave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Masukkan Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false; // Nonaktifkan bintang saat placeholder
            }
        }

        private void txtKonfirPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtKonfirPassword.Text == "Konfirmasi Password")
            {
                txtKonfirPassword.Text = "";
                txtKonfirPassword.ForeColor = Color.Gray;
                txtKonfirPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtKonfirPassword_MouseLeave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKonfirPassword.Text))
            {
                txtKonfirPassword.Text = "Konfirmasi Password";
                txtKonfirPassword.ForeColor = Color.Gray;
                txtKonfirPassword.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
