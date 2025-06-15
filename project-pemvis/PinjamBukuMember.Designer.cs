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
            btnProfil = new Button();
            btnDaftarBuku = new Button();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvDaftarBuku = new DataGridView();
            labelHalaman = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            FormPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBuku).BeginInit();
            SuspendLayout();
            // 
            // btnPinjam
            // 
            btnPinjam.BackColor = SystemColors.ActiveCaption;
            btnPinjam.FlatStyle = FlatStyle.Popup;
            btnPinjam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPinjam.ForeColor = Color.White;
            btnPinjam.Location = new Point(306, 416);
            btnPinjam.Margin = new Padding(6, 4, 6, 4);
            btnPinjam.Name = "btnPinjam";
            btnPinjam.Size = new Size(448, 47);
            btnPinjam.TabIndex = 13;
            btnPinjam.Text = "Pinjam";
            btnPinjam.UseVisualStyleBackColor = false;
            btnPinjam.Click += btnPinjam_Click;
            // 
            // lblTanggalPengembalian
            // 
            lblTanggalPengembalian.AutoSize = true;
            lblTanggalPengembalian.Location = new Point(28, 348);
            lblTanggalPengembalian.Margin = new Padding(6, 0, 6, 0);
            lblTanggalPengembalian.Name = "lblTanggalPengembalian";
            lblTanggalPengembalian.Size = new Size(254, 32);
            lblTanggalPengembalian.TabIndex = 11;
            lblTanggalPengembalian.Text = "Tanggal Pengembalian";
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.ActiveCaption;
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(306, 194);
            btnCari.Margin = new Padding(6, 4, 6, 4);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(448, 47);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // lblTanggalPeminjaman
            // 
            lblTanggalPeminjaman.AutoSize = true;
            lblTanggalPeminjaman.Location = new Point(28, 277);
            lblTanggalPeminjaman.Margin = new Padding(6, 0, 6, 0);
            lblTanggalPeminjaman.Name = "lblTanggalPeminjaman";
            lblTanggalPeminjaman.Size = new Size(234, 32);
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
            FormPeminjaman.Location = new Point(916, 254);
            FormPeminjaman.Margin = new Padding(6, 4, 6, 4);
            FormPeminjaman.Name = "FormPeminjaman";
            FormPeminjaman.Padding = new Padding(6, 4, 6, 4);
            FormPeminjaman.Size = new Size(786, 486);
            FormPeminjaman.TabIndex = 14;
            FormPeminjaman.TabStop = false;
            FormPeminjaman.Text = "Form Peminjaman";
            // 
            // dtpTanggalKembali
            // 
            dtpTanggalKembali.Location = new Point(306, 339);
            dtpTanggalKembali.Margin = new Padding(4, 2, 4, 2);
            dtpTanggalKembali.Name = "dtpTanggalKembali";
            dtpTanggalKembali.Size = new Size(450, 39);
            dtpTanggalKembali.TabIndex = 15;
            // 
            // dtpTanggalPinjam
            // 
            dtpTanggalPinjam.Location = new Point(306, 277);
            dtpTanggalPinjam.Margin = new Padding(4, 2, 4, 2);
            dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            dtpTanggalPinjam.Size = new Size(450, 39);
            dtpTanggalPinjam.TabIndex = 14;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(306, 119);
            textBoxJudul.Margin = new Padding(6, 4, 6, 4);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(450, 39);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(28, 126);
            lblJudul.Margin = new Padding(6, 0, 6, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(71, 32);
            lblJudul.TabIndex = 8;
            lblJudul.Text = "Judul";
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(306, 43);
            comboBoxKategori.Margin = new Padding(6, 4, 6, 4);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(450, 40);
            comboBoxKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(28, 43);
            lblKategori.Margin = new Padding(6, 0, 6, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(103, 32);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatang.ForeColor = Color.Black;
            lblSelamatDatang.Location = new Point(6, 151);
            lblSelamatDatang.Margin = new Padding(6, 0, 6, 0);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(447, 71);
            lblSelamatDatang.TabIndex = 12;
            lblSelamatDatang.Text = "Selamat Datang!";
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1558, 32);
            btnProfil.Margin = new Padding(6, 4, 6, 4);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(136, 81);
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
            btnDaftarBuku.Location = new Point(1322, 32);
            btnDaftarBuku.Margin = new Padding(6, 4, 6, 4);
            btnDaftarBuku.Name = "btnDaftarBuku";
            btnDaftarBuku.Size = new Size(227, 81);
            btnDaftarBuku.TabIndex = 24;
            btnDaftarBuku.Text = "Daftar Buku";
            btnDaftarBuku.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 2);
            pictureBox3.Margin = new Padding(4, 2, 4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(btnDaftarBuku);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(6, 0);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1714, 147);
            panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDaftarBuku);
            groupBox1.Location = new Point(30, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 810);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar Buku";
            // 
            // dgvDaftarBuku
            // 
            dgvDaftarBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarBuku.Dock = DockStyle.Fill;
            dgvDaftarBuku.Location = new Point(3, 35);
            dgvDaftarBuku.Name = "dgvDaftarBuku";
            dgvDaftarBuku.RowHeadersWidth = 82;
            dgvDaftarBuku.Size = new Size(871, 772);
            dgvDaftarBuku.TabIndex = 0;
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.Location = new Point(709, 1076);
            labelHalaman.Margin = new Padding(4, 0, 4, 0);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(195, 32);
            labelHalaman.TabIndex = 33;
            labelHalaman.Text = "Halaman 1 dari 2";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(223, 1071);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(182, 45);
            btnNext.TabIndex = 32;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(33, 1071);
            btnPrev.Margin = new Padding(4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(182, 45);
            btnPrev.TabIndex = 31;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // PinjamBukuMember
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 1150);
            Controls.Add(labelHalaman);
            Controls.Add(groupBox1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(FormPeminjaman);
            Controls.Add(lblSelamatDatang);
            Controls.Add(panel1);
            Margin = new Padding(6, 4, 6, 4);
            Name = "PinjamBukuMember";
            Text = "PinjamBukuMember";
            Load += PinjamBukuMember_Load;
            FormPeminjaman.ResumeLayout(false);
            FormPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDaftarBuku).EndInit();
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
        private Button btnProfil;
        private Button btnDaftarBuku;
        private PictureBox pictureBox3;
        private Panel panel1;
        private DateTimePicker dtpTanggalKembali;
        private DateTimePicker dtpTanggalPinjam;
        private GroupBox groupBox1;
        private DataGridView dgvDaftarBuku;
        private Label labelHalaman;
        private Button btnNext;
        private Button btnPrev;
    }
}