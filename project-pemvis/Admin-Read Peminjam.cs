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
    public partial class Admin_Read_Peminjam : Form
    {
        public Admin_Read_Peminjam()
        {
            InitializeComponent();
            LoadData();
        }
        private void Admin_Read_Peminjam_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadData(string tanggalFilter = "", string columnFilter = "", string keyword = "")
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            pb.id AS 'ID',
                            u.username AS 'Nama Peminjam',
                            b.judul AS 'Judul Buku',
                            pb.tanggal_pinjam AS 'Tanggal Pinjam',
                            pb.tanggal_pengembalian AS 'Tanggal Pengembalian'
                        FROM pinjam_buku pb
                        INNER JOIN users u ON pb.user_id = u.id
                        INNER JOIN buku b ON pb.buku_id = b.id
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(tanggalFilter))
                    {
                        query += " AND pb.tanggal_pinjam = @tanggal";
                    }

                    if (!string.IsNullOrEmpty(columnFilter) && !string.IsNullOrEmpty(keyword))
                    {
                        if (columnFilter == "Nama Peminjam")
                            query += " AND u.username LIKE @keyword";
                        else if (columnFilter == "Judul Buku")
                            query += " AND b.judul LIKE @keyword";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(tanggalFilter))
                    {
                        cmd.Parameters.AddWithValue("@tanggal", tanggalFilter);
                    }

                    if (!string.IsNullOrEmpty(columnFilter) && !string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            LoadData(selectedDate);
        }


        private void buttonCari_Click(object sender, EventArgs e)
        {
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedFilter = comboBoxFilter.SelectedItem?.ToString() ?? "";
            string keyword = textBoxFilter.Text.Trim();

            LoadData(selectedDate, selectedFilter, keyword);
        }
    }
}
