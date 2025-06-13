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
    public partial class Admin_Data_Buku : Form
    {
        int currentId = 0;
        int currentPage = 1;
        int pageSize = 10;
        int totalPages = 0;

        public Admin_Data_Buku()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
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
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["judul"].HeaderText = "Judul Buku";
                dataGridView1.Columns["penulis"].HeaderText = "Penulis";
                dataGridView1.Columns["penerbit"].HeaderText = "Penerbit";
                dataGridView1.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";
                dataGridView1.Columns["sinopsis"].HeaderText = "Sinopsis";
                dataGridView1.Columns["kategori"].HeaderText = "Kategori";
                dataGridView1.Columns["stok"].HeaderText = "Jumlah Stok";
            }
        }

        private void Admin_Data_Buku_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (IsDuplicateJudul(textBoxJudul.Text.Trim()))
            {
                MessageBox.Show("Judul buku sudah ada. Gunakan judul lain", "Validasi Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku (judul, penulis, penerbit, tahun_terbit, sinopsis, kategori, stok) VALUES (@judul, @penulis, @penerbit, @tahun_terbit, @sinopsis, @kategori, @stok)";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@judul", textBoxJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", textBoxPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", textBoxPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", int.Parse(textBoxTahunTerbit.Text));
                    cmd.Parameters.AddWithValue("@sinopsis", textBoxSinopsis.Text);
                    cmd.Parameters.AddWithValue("@kategori", textBoxKategori.Text);
                    cmd.Parameters.AddWithValue("@stok", int.Parse(textBoxStok.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Buku berhasil ditambahkan!");
                    LoadData();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan buku: " + ex.Message);
                }
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu dari tabel.");
                return;
            }

            if (!ValidateInput()) return;

            if (IsDuplicateJudul(textBoxJudul.Text.Trim(), currentId))
            {
                MessageBox.Show("Judul buku sudah digunakan oleh buku lain", "Validasi Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE buku SET judul=@judul, penulis=@penulis, penerbit=@penerbit, tahun_terbit=@tahun, sinopsis=@sinopsis, kategori=@kategori, stok=@stok WHERE id=@id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", currentId);
                    cmd.Parameters.AddWithValue("@judul", textBoxJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", textBoxPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", textBoxPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun", int.Parse(textBoxTahunTerbit.Text));
                    cmd.Parameters.AddWithValue("@sinopsis", textBoxSinopsis.Text);
                    cmd.Parameters.AddWithValue("@kategori", textBoxKategori.Text);
                    cmd.Parameters.AddWithValue("@stok", int.Parse(textBoxStok.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data buku berhasil diperbarui.");
                    LoadData();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengedit buku: " + ex.Message);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu.");
                return;
            }

            var result = MessageBox.Show("Apakah Anda yakin ingin menghapus buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; 
            }

            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM buku WHERE id=@id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", currentId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Buku berhasil dihapus.");
                    LoadData();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus buku: " + ex.Message);
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string filter = textBoxFilter.Text.Trim();
                string? column = comboBoxFilter.SelectedItem?.ToString();

                string query = "SELECT * FROM buku WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(filter))
                {
                    if (column == "Judul")
                        query += " AND judul LIKE @filter";
                    else if (column == "Penulis")
                        query += " AND penulis LIKE @filter";
                    else if (column == "Penerbit")
                        query += " AND penerbit LIKE @filter";
                    else if (column == "Tahun Terbit")
                        query += " AND tahun_terbit LIKE @filter";
                    else if (column == "Kategori")
                        query += " AND kategori LIKE @filter";
                }

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

                var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void buttonCetak_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV file|*.csv", FileName = "buku.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sb = new StringBuilder();
                        var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                        sb.AppendLine(string.Join(",", headers.Select(c => c.HeaderText)));

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sb.AppendLine(string.Join(",", cells.Select(c => c.Value?.ToString()?.Replace(",", " "))));
                            }
                        }

                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                        MessageBox.Show("Data berhasil diexport ke CSV!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal export: " + ex.Message);
                    }
                }
            }
        }
        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void buttonPeminjamBuku_Click(object sender, EventArgs e)
        {
            Admin_Read_Peminjam arp = new Admin_Read_Peminjam();
            this.Hide();
            arp.Show();
        }

        private void ClearInput()
        {
            currentId = 0;
            textBoxJudul.Clear();
            textBoxPenulis.Clear();
            textBoxPenerbit.Clear();
            textBoxTahunTerbit.Clear();
            textBoxSinopsis.Clear();
            textBoxKategori.Clear();
            textBoxStok.Clear();

            textBoxJudul.Focus();

            buttonEdit.Enabled = false;
            buttonHapus.Enabled = false;
            buttonSimpan.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                currentId = Convert.ToInt32(row.Cells["id"].Value);
                textBoxJudul.Text = row.Cells["judul"].Value.ToString();
                textBoxPenulis.Text = row.Cells["penulis"].Value.ToString();
                textBoxPenerbit.Text = row.Cells["penerbit"].Value.ToString();
                textBoxTahunTerbit.Text = row.Cells["tahun_terbit"].Value.ToString();
                textBoxSinopsis.Text = row.Cells["sinopsis"].Value.ToString();
                textBoxKategori.Text = row.Cells["kategori"].Value.ToString();
                textBoxStok.Text = row.Cells["stok"].Value.ToString();

                buttonEdit.Enabled = true;
                buttonHapus.Enabled = true;
                buttonSimpan.Enabled = false;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxJudul.Text) ||
                string.IsNullOrWhiteSpace(textBoxPenulis.Text) ||
                string.IsNullOrWhiteSpace(textBoxPenerbit.Text) ||
                string.IsNullOrWhiteSpace(textBoxTahunTerbit.Text) ||
                string.IsNullOrWhiteSpace(textBoxStok.Text))
            {
                MessageBox.Show("Semua kolom harus diisi", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBoxTahunTerbit.Text, out int tahun) || tahun > DateTime.Now.Year)
            {
                MessageBox.Show("Tahun terbit tidak valid", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBoxStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka positif", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsDuplicateJudul(string judul, int excludeId = 0)
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM buku WHERE judul = @judul";
                if (excludeId > 0)
                    query += " AND id != @id";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                if (excludeId > 0)
                    cmd.Parameters.AddWithValue("@id", excludeId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
