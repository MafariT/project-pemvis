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
    public partial class PinjamBukuMember : Form
    {
        private int userId;
        int currentId = 0;
        int currentPage = 1;
        int pageSize = 10;
        int totalPages = 0;

        public PinjamBukuMember(int userIdFromLogin)
        {
            InitializeComponent();
            this.userId = userIdFromLogin;
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil(userId); // Pastikan "Profil" adalah nama form yang benar
            profilForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void PinjamBukuMember_Load(object sender, EventArgs e)
        {
            LoadDaftarBuku();
            LoadKategori();
            dgvDaftarBuku.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvDaftarBuku.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvDaftarBuku.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvDaftarBuku.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadKategori()
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT kategori FROM buku WHERE kategori IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    comboBoxKategori.Items.Clear();
                    comboBoxKategori.Items.Add("Semua"); // Opsional: untuk filter semua kategori

                    while (reader.Read())
                    {
                        comboBoxKategori.Items.Add(reader["kategori"].ToString());
                    }

                    comboBoxKategori.SelectedIndex = 0; // default pilih "Semua"
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDaftarBuku()
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    string countQuery = "SELECT COUNT(*) FROM buku";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    int totalRows = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
                    labelHalaman.Text = $"Halaman {currentPage} dari {totalPages}";

                    int offset = (currentPage - 1) * pageSize;

                    string query = "SELECT * FROM buku LIMIT @limit OFFSET @offset";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDaftarBuku.DataSource = dt;

                    dgvDaftarBuku.Columns["id"].HeaderText = "ID";
                    dgvDaftarBuku.Columns["judul"].HeaderText = "Judul Buku";
                    dgvDaftarBuku.Columns["penulis"].HeaderText = "Penulis";
                    dgvDaftarBuku.Columns["penerbit"].HeaderText = "Penerbit";
                    dgvDaftarBuku.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";
                    dgvDaftarBuku.Columns["sinopsis"].HeaderText = "Sinopsis";
                    dgvDaftarBuku.Columns["kategori"].HeaderText = "Kategori";
                    dgvDaftarBuku.Columns["stok"].HeaderText = "Jumlah Stok";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar buku: " + ex.Message);
                }
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (dgvDaftarBuku.CurrentRow == null || dgvDaftarBuku.CurrentRow.Index == -1)
            {
                MessageBox.Show("Silakan pilih buku terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bukuId = Convert.ToInt32(dgvDaftarBuku.CurrentRow.Cells["id"].Value);
            DateTime tanggalPinjam = dtpTanggalPinjam.Value.Date;
            DateTime tanggalKembali = dtpTanggalKembali.Value.Date;
            DateTime today = DateTime.Today;

            // ✅ Validasi tanggal pinjam
            if (tanggalPinjam < today)
            {
                MessageBox.Show("Mohon pilih tanggal pinjam yang benar!", "Validasi Tanggal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validasi tanggal pengembalian
            if (tanggalKembali < today)
            {
                MessageBox.Show("Mohon pilih tanggal pengembalian yang benar!", "Validasi Tanggal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    // ✅ Cek stok buku terlebih dahulu
                    string cekStokQuery = "SELECT stok FROM buku WHERE id = @BukuId";
                    MySqlCommand cekStokCmd = new MySqlCommand(cekStokQuery, conn);
                    cekStokCmd.Parameters.AddWithValue("@BukuId", bukuId);
                    object stokObj = cekStokCmd.ExecuteScalar();

                    if (stokObj == null)
                    {
                        MessageBox.Show("Buku tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int stok = Convert.ToInt32(stokObj);

                    if (stok <= 0)
                    {
                        MessageBox.Show("Stok buku habis. Tidak bisa dipinjam.", "Stok Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // ✅ Mulai transaksi: insert ke pinjam_buku dan kurangi stok
                    string insertQuery = @"INSERT INTO pinjam_buku (user_id, buku_id, tanggal_pinjam, tanggal_pengembalian) 
                                   VALUES (@UserId, @BukuId, @TanggalPinjam, @TanggalKembali)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserId", userId);
                    insertCmd.Parameters.AddWithValue("@BukuId", bukuId);
                    insertCmd.Parameters.AddWithValue("@TanggalPinjam", tanggalPinjam);
                    insertCmd.Parameters.AddWithValue("@TanggalKembali", tanggalKembali);
                    insertCmd.ExecuteNonQuery();

                    // ✅ Update stok buku
                    string updateStokQuery = "UPDATE buku SET stok = stok - 1 WHERE id = @BukuId";
                    MySqlCommand updateStokCmd = new MySqlCommand(updateStokQuery, conn);
                    updateStokCmd.Parameters.AddWithValue("@BukuId", bukuId);
                    updateStokCmd.ExecuteNonQuery();

                    MessageBox.Show("Peminjaman berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDaftarBuku(); // Refresh data grid biar stok langsung update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string judul = textBoxJudul.Text.Trim();
            string kategori = comboBoxKategori.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, judul, penulis, penerbit, tahun_terbit, kategori, stok FROM buku WHERE 1=1";

                    if (!string.IsNullOrEmpty(judul))
                        query += " AND judul LIKE @Judul";

                    if (kategori != "Semua")
                        query += " AND kategori = @Kategori";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(judul))
                        cmd.Parameters.AddWithValue("@Judul", "%" + judul + "%");

                    if (kategori != "Semua")
                        cmd.Parameters.AddWithValue("@Kategori", kategori);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Tambahkan kolom No
                    dt.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dt.Rows[i]["No"] = i + 1;

                    dt.Columns["No"].SetOrdinal(0);
                    dgvDaftarBuku.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal melakukan pencarian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDaftarBuku();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDaftarBuku();
            }
        }
    }
}
