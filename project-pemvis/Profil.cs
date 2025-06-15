using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace project_pemvis
{
    public partial class Profil : Form
    {
        private int userId;
        private int currentPage = 1;
        private int pageSize = 6;
        private int totalPages = 1;
        private string currentFilter = "";

        public Profil(int userIdFromCaller)
        {
            InitializeComponent();
            this.userId = userIdFromCaller;
        }

        private int GetTotalHistoriRows(string judulFilter = "")
        {
            int totalRows = 0;
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string countQuery = @"
                    SELECT COUNT(*) 
                    FROM pinjam_buku p 
                    JOIN buku b ON p.buku_id = b.id 
                    WHERE p.user_id = @UserId";

                if (!string.IsNullOrWhiteSpace(judulFilter))
                {
                    countQuery += " AND b.judul LIKE @Judul";
                }

                MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                countCmd.Parameters.AddWithValue("@UserId", userId);
                if (!string.IsNullOrWhiteSpace(judulFilter))
                {
                    countCmd.Parameters.AddWithValue("@Judul", "%" + judulFilter + "%");
                }

                totalRows = Convert.ToInt32(countCmd.ExecuteScalar());
            }

            return totalRows;
        }

        private void LoadHistoriPeminjaman(string judulFilter = "")
        {
            dgvHistori.AllowUserToAddRows = false;

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT b.judul, p.tanggal_pinjam, p.tanggal_pengembalian
                        FROM pinjam_buku p
                        JOIN buku b ON p.buku_id = b.id
                        WHERE p.user_id = @UserId";

                    if (!string.IsNullOrWhiteSpace(judulFilter))
                    {
                        query += " AND b.judul LIKE @Judul";
                    }

                    query += " ORDER BY p.tanggal_pinjam DESC LIMIT @Limit OFFSET @Offset";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Limit", pageSize);
                    cmd.Parameters.AddWithValue("@Offset", (currentPage - 1) * pageSize);

                    if (!string.IsNullOrWhiteSpace(judulFilter))
                    {
                        cmd.Parameters.AddWithValue("@Judul", "%" + judulFilter + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHistori.DataSource = dt;

                    // Update pagination info
                    int totalRows = GetTotalHistoriRows(judulFilter);
                    totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
                    labelHalaman.Text = $"Halaman {currentPage} dari {totalPages}";

                    btnPrev.Enabled = currentPage > 1;
                    btnNext.Enabled = currentPage < totalPages;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat histori peminjaman: " + ex.Message);
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            currentFilter = textBoxJudul.Text.Trim();
            LoadHistoriPeminjaman(currentFilter);
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
                        if (reader["tanggal_lahir"] != DBNull.Value)
                        {
                            dateTimeTglLahir.Value = Convert.ToDateTime(reader["tanggal_lahir"]);
                        }
                        else
                        {
                            dateTimeTglLahir.Value = DateTime.Today;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data profil: " + ex.Message);
                }
            }

            LoadHistoriPeminjaman();
        }

        private void btnUpdateProfil_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string nohp = txtNohp.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            DateTime tanggalLahir = dateTimeTglLahir.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT id FROM profile WHERE user_id = @UserId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@UserId", userId);
                    object result = checkCmd.ExecuteScalar();

                    string query;
                    if (result != null)
                    {
                        query = @"UPDATE profile 
                                  SET nama = @Nama, nohp = @Nohp, alamat = @Alamat, tanggal_lahir = @TanggalLahir 
                                  WHERE user_id = @UserId";
                    }
                    else
                    {
                        query = @"INSERT INTO profile (user_id, nama, nohp, alamat, tanggal_lahir) 
                                  VALUES (@UserId, @Nama, @Nohp, @Alamat, @TanggalLahir)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Nama", nama);
                    cmd.Parameters.AddWithValue("@Nohp", nohp);
                    cmd.Parameters.AddWithValue("@Alamat", alamat);
                    cmd.Parameters.AddWithValue("@TanggalLahir", tanggalLahir.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                }
            }
        }

        private void btnDaftarBuku_Click(object sender, EventArgs e)
        {
            PinjamBukuMember pinjamBukuMember = new PinjamBukuMember(userId);
            pinjamBukuMember.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RiwayatPinjam rwtForm = new RiwayatPinjam();
            rwtForm.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadHistoriPeminjaman(currentFilter);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadHistoriPeminjaman(currentFilter);
            }
        }
    }
}
