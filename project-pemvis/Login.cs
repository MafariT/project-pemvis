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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Email
            txtEmailLogin.Text = "Masukkan Email";
            txtEmailLogin.ForeColor = Color.Gray;

            // Password
            txtPasswordLogin.Text = "Masukkan Password";
            txtPasswordLogin.ForeColor = Color.Gray;
            txtPasswordLogin.UseSystemPasswordChar = false; // Tampilkan teks biasa saat placeholder

            lblInvalid.Visible = false;
            lblInvalid.ForeColor = Color.Red;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnMasuk.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnMasuk.ForeColor = Color.White;

        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form Register
            Register registerForm = new Register();

            // Menampilkan Form Register
            registerForm.Show();

            // Opsional: Menyembunyikan Form saat ini jika tidak diperlukan lagi
            this.Hide();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Ambil input dan cek placeholder
            string email = txtEmailLogin.Text.Trim();
            string password = txtPasswordLogin.Text;

            // Validasi input kosong
            if (email == "Masukkan Email" || string.IsNullOrWhiteSpace(email) ||
                password == "Masukkan Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // Enkripsi jika digunakan

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["id"]);
                        // Ambil nilai role dari hasil query
                        string role = reader["role"].ToString();

                        lblInvalid.Visible = false;

                        if (role == "member")
                        {
                            // Pindah ke form khusus member
                            PinjamBukuMember formMember = new PinjamBukuMember(userId);
                            formMember.Show();
                        }
                        else
                        {
                            // Pindah ke form utama/admin
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                        }

                        this.Hide(); // Sembunyikan form login
                    }
                    else
                    {
                        // Login gagal → tampilkan label invalid
                        lblInvalid.Visible = true;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEmailLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtEmailLogin.Text == "Masukkan Email")
            {
                txtEmailLogin.Text = "";
                txtEmailLogin.ForeColor = Color.Gray;
            }
        }

        private void txtEmailLogin_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailLogin.Text))
            {
                txtEmailLogin.Text = "Masukkan Email";
                txtEmailLogin.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text == "Masukkan Password")
            {
                txtPasswordLogin.Text = "";
                txtPasswordLogin.ForeColor = Color.Gray;
                txtPasswordLogin.UseSystemPasswordChar = true; // Aktifkan mode *
            }
        }

        private void txtPasswordLogin_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordLogin.Text))
            {
                txtPasswordLogin.UseSystemPasswordChar = false; // Tampilkan teks placeholder
                txtPasswordLogin.Text = "Masukkan Password";
                txtPasswordLogin.ForeColor = Color.Gray;
            }
        }
    }
}
