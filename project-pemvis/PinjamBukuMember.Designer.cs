namespace project_pemvis
{
    partial class PinjamBukuMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinjamBukuMember));
            btnPinjam = new Button();
            lblTanggalPengembalian = new Label();
            btnCari = new Button();
            lblTanggalPeminjaman = new Label();
            FormPeminjaman = new GroupBox();
            dtpTanggalKembali = new DateTimePicker();
            dtpTanggalPinjam = new DateTimePicker();
            textBoxJudul = new TextBox();
            lblJudul = new Label();
            comboBoxKategori = new ComboBox();
            lblKategori = new Label();
            lblSelamatDatang = new Label();
            dgvDaftarBuku = new DataGridView();
            btnProfil = new Button();
            btnDaftarBuku = new Button();
            pictureBox3 = new PictureBox();
            DaftarBuku = new GroupBox();
            panel1 = new Panel();
            FormPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            DaftarBuku.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPinjam
            // 
            btnPinjam.BackColor = SystemColors.ActiveCaption;
            btnPinjam.FlatStyle = FlatStyle.Popup;
            btnPinjam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPinjam.ForeColor = Color.White;
            btnPinjam.Location = new Point(165, 195);
            btnPinjam.Margin = new Padding(3, 2, 3, 2);
            btnPinjam.Name = "btnPinjam";
            btnPinjam.Size = new Size(241, 22);
            btnPinjam.TabIndex = 13;
            btnPinjam.Text = "Pinjam";
            btnPinjam.UseVisualStyleBackColor = false;
            btnPinjam.Click += btnPinjam_Click;
            // 
            // lblTanggalPengembalian
            // 
            lblTanggalPengembalian.AutoSize = true;
            lblTanggalPengembalian.Location = new Point(15, 163);
            lblTanggalPengembalian.Name = "lblTanggalPengembalian";
            lblTanggalPengembalian.Size = new Size(127, 15);
            lblTanggalPengembalian.TabIndex = 11;
            lblTanggalPengembalian.Text = "Tanggal Pengembalian";
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.ActiveCaption;
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(165, 91);
            btnCari.Margin = new Padding(3, 2, 3, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(241, 22);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // lblTanggalPeminjaman
            // 
            lblTanggalPeminjaman.AutoSize = true;
            lblTanggalPeminjaman.Location = new Point(15, 130);
            lblTanggalPeminjaman.Name = "lblTanggalPeminjaman";
            lblTanggalPeminjaman.Size = new Size(118, 15);
            lblTanggalPeminjaman.TabIndex = 8;
            lblTanggalPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // FormPeminjaman
            // 
            FormPeminjaman.Controls.Add(dtpTanggalKembali);
            FormPeminjaman.Controls.Add(dtpTanggalPinjam);
            FormPeminjaman.Controls.Add(btnPinjam);
            FormPeminjaman.Controls.Add(lblTanggalPengembalian);
            FormPeminjaman.Controls.Add(btnCari);
            FormPeminjaman.Controls.Add(textBoxJudul);
            FormPeminjaman.Controls.Add(lblTanggalPeminjaman);
            FormPeminjaman.Controls.Add(lblJudul);
            FormPeminjaman.Controls.Add(comboBoxKategori);
            FormPeminjaman.Controls.Add(lblKategori);
            FormPeminjaman.Location = new Point(493, 119);
            FormPeminjaman.Margin = new Padding(3, 2, 3, 2);
            FormPeminjaman.Name = "FormPeminjaman";
            FormPeminjaman.Padding = new Padding(3, 2, 3, 2);
            FormPeminjaman.Size = new Size(423, 228);
            FormPeminjaman.TabIndex = 14;
            FormPeminjaman.TabStop = false;
            FormPeminjaman.Text = "Form Peminjaman";
            // 
            // dtpTanggalKembali
            // 
            dtpTanggalKembali.Location = new Point(165, 159);
            dtpTanggalKembali.Margin = new Padding(2, 1, 2, 1);
            dtpTanggalKembali.Name = "dtpTanggalKembali";
            dtpTanggalKembali.Size = new Size(244, 23);
            dtpTanggalKembali.TabIndex = 15;
            // 
            // dtpTanggalPinjam
            // 
            dtpTanggalPinjam.Location = new Point(165, 130);
            dtpTanggalPinjam.Margin = new Padding(2, 1, 2, 1);
            dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            dtpTanggalPinjam.Size = new Size(244, 23);
            dtpTanggalPinjam.TabIndex = 14;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(165, 56);
            textBoxJudul.Margin = new Padding(3, 2, 3, 2);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(244, 23);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(15, 59);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(35, 15);
            lblJudul.TabIndex = 8;
            lblJudul.Text = "Judul";
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(165, 20);
            comboBoxKategori.Margin = new Padding(3, 2, 3, 2);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(244, 23);
            comboBoxKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(15, 20);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatang.ForeColor = Color.Black;
            lblSelamatDatang.Location = new Point(3, 71);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(231, 37);
            lblSelamatDatang.TabIndex = 12;
            lblSelamatDatang.Text = "Selamat Datang!";
            // 
            // dgvDaftarBuku
            // 
            dgvDaftarBuku.AllowUserToAddRows = false;
            dgvDaftarBuku.AllowUserToDeleteRows = false;
            dgvDaftarBuku.BackgroundColor = Color.White;
            dgvDaftarBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarBuku.Location = new Point(5, 20);
            dgvDaftarBuku.Margin = new Padding(3, 2, 3, 2);
            dgvDaftarBuku.Name = "dgvDaftarBuku";
            dgvDaftarBuku.ReadOnly = true;
            dgvDaftarBuku.RowHeadersVisible = false;
            dgvDaftarBuku.RowHeadersWidth = 51;
            dgvDaftarBuku.Size = new Size(466, 391);
            dgvDaftarBuku.TabIndex = 1;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(839, 15);
            btnProfil.Margin = new Padding(3, 2, 3, 2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(73, 38);
            btnProfil.TabIndex = 25;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnDaftarBuku
            // 
            btnDaftarBuku.BackColor = Color.Transparent;
            btnDaftarBuku.FlatAppearance.BorderSize = 0;
            btnDaftarBuku.FlatStyle = FlatStyle.Flat;
            btnDaftarBuku.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftarBuku.ForeColor = Color.White;
            btnDaftarBuku.Location = new Point(712, 15);
            btnDaftarBuku.Margin = new Padding(3, 2, 3, 2);
            btnDaftarBuku.Name = "btnDaftarBuku";
            btnDaftarBuku.Size = new Size(122, 38);
            btnDaftarBuku.TabIndex = 24;
            btnDaftarBuku.Text = "Daftar Buku";
            btnDaftarBuku.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 1);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // DaftarBuku
            // 
            DaftarBuku.Controls.Add(dgvDaftarBuku);
            DaftarBuku.Location = new Point(11, 119);
            DaftarBuku.Margin = new Padding(3, 2, 3, 2);
            DaftarBuku.Name = "DaftarBuku";
            DaftarBuku.Padding = new Padding(3, 2, 3, 2);
            DaftarBuku.Size = new Size(477, 417);
            DaftarBuku.TabIndex = 13;
            DaftarBuku.TabStop = false;
            DaftarBuku.Text = "Daftar Buku";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(btnDaftarBuku);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 70);
            panel1.TabIndex = 11;
            // 
            // PinjamBukuMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 539);
            Controls.Add(FormPeminjaman);
            Controls.Add(lblSelamatDatang);
            Controls.Add(DaftarBuku);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PinjamBukuMember";
            Text = "PinjamBukuMember";
            Load += PinjamBukuMember_Load;
            FormPeminjaman.ResumeLayout(false);
            FormPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            DaftarBuku.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPinjam;
        private Label lblTanggalPengembalian;
        private Button btnCari;
        private Label lblTanggalPeminjaman;
        private GroupBox FormPeminjaman;
        private TextBox textBoxJudul;
        private Label lblJudul;
        private ComboBox comboBoxKategori;
        private Label lblKategori;
        private Label lblSelamatDatang;
        private DataGridView dgvDaftarBuku;
        private Button btnProfil;
        private Button btnDaftarBuku;
        private PictureBox pictureBox3;
        private GroupBox DaftarBuku;
        private Panel panel1;
        private DateTimePicker dtpTanggalKembali;
        private DateTimePicker dtpTanggalPinjam;
    }
}