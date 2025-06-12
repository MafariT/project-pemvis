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
            buttonPinjam = new Button();
            textBoxTanggalPengembalian = new TextBox();
            lblTanggalPengembalian = new Label();
            btnCari = new Button();
            lblTanggalPeminjaman = new Label();
            FormPeminjaman = new GroupBox();
            textBoxTanggalPeminjaman = new TextBox();
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
            // buttonPinjam
            // 
            buttonPinjam.BackColor = SystemColors.ActiveCaption;
            buttonPinjam.FlatStyle = FlatStyle.Popup;
            buttonPinjam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPinjam.ForeColor = Color.White;
            buttonPinjam.Location = new Point(188, 260);
            buttonPinjam.Name = "buttonPinjam";
            buttonPinjam.Size = new Size(276, 29);
            buttonPinjam.TabIndex = 13;
            buttonPinjam.Text = "Pinjam";
            buttonPinjam.UseVisualStyleBackColor = false;
            // 
            // textBoxTanggalPengembalian
            // 
            textBoxTanggalPengembalian.Location = new Point(188, 217);
            textBoxTanggalPengembalian.Name = "textBoxTanggalPengembalian";
            textBoxTanggalPengembalian.Size = new Size(278, 27);
            textBoxTanggalPengembalian.TabIndex = 12;
            // 
            // lblTanggalPengembalian
            // 
            lblTanggalPengembalian.AutoSize = true;
            lblTanggalPengembalian.Location = new Point(17, 217);
            lblTanggalPengembalian.Name = "lblTanggalPengembalian";
            lblTanggalPengembalian.Size = new Size(159, 20);
            lblTanggalPengembalian.TabIndex = 11;
            lblTanggalPengembalian.Text = "Tanggal Pengembalian";
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.ActiveCaption;
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(188, 121);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(276, 29);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // lblTanggalPeminjaman
            // 
            lblTanggalPeminjaman.AutoSize = true;
            lblTanggalPeminjaman.Location = new Point(17, 173);
            lblTanggalPeminjaman.Name = "lblTanggalPeminjaman";
            lblTanggalPeminjaman.Size = new Size(146, 20);
            lblTanggalPeminjaman.TabIndex = 8;
            lblTanggalPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // FormPeminjaman
            // 
            FormPeminjaman.Controls.Add(buttonPinjam);
            FormPeminjaman.Controls.Add(textBoxTanggalPengembalian);
            FormPeminjaman.Controls.Add(lblTanggalPengembalian);
            FormPeminjaman.Controls.Add(btnCari);
            FormPeminjaman.Controls.Add(textBoxTanggalPeminjaman);
            FormPeminjaman.Controls.Add(textBoxJudul);
            FormPeminjaman.Controls.Add(lblTanggalPeminjaman);
            FormPeminjaman.Controls.Add(lblJudul);
            FormPeminjaman.Controls.Add(comboBoxKategori);
            FormPeminjaman.Controls.Add(lblKategori);
            FormPeminjaman.Location = new Point(563, 159);
            FormPeminjaman.Name = "FormPeminjaman";
            FormPeminjaman.Size = new Size(484, 304);
            FormPeminjaman.TabIndex = 14;
            FormPeminjaman.TabStop = false;
            FormPeminjaman.Text = "Form Peminjaman";
            // 
            // textBoxTanggalPeminjaman
            // 
            textBoxTanggalPeminjaman.Location = new Point(188, 173);
            textBoxTanggalPeminjaman.Name = "textBoxTanggalPeminjaman";
            textBoxTanggalPeminjaman.Size = new Size(278, 27);
            textBoxTanggalPeminjaman.TabIndex = 9;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(188, 75);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(278, 27);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(17, 78);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(43, 20);
            lblJudul.TabIndex = 8;
            lblJudul.Text = "Judul";
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(188, 27);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(278, 28);
            comboBoxKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(17, 27);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelamatDatang.ForeColor = Color.Black;
            lblSelamatDatang.Location = new Point(3, 95);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(283, 46);
            lblSelamatDatang.TabIndex = 12;
            lblSelamatDatang.Text = "Selamat Datang!";
            // 
            // dgvDaftarBuku
            // 
            dgvDaftarBuku.BackgroundColor = Color.White;
            dgvDaftarBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarBuku.Location = new Point(6, 26);
            dgvDaftarBuku.Name = "dgvDaftarBuku";
            dgvDaftarBuku.RowHeadersWidth = 51;
            dgvDaftarBuku.Size = new Size(533, 521);
            dgvDaftarBuku.TabIndex = 1;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(959, 20);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(84, 50);
            btnProfil.TabIndex = 25;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnDaftarBuku
            // 
            btnDaftarBuku.BackColor = Color.Transparent;
            btnDaftarBuku.FlatAppearance.BorderSize = 0;
            btnDaftarBuku.FlatStyle = FlatStyle.Flat;
            btnDaftarBuku.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftarBuku.ForeColor = Color.White;
            btnDaftarBuku.Location = new Point(814, 20);
            btnDaftarBuku.Name = "btnDaftarBuku";
            btnDaftarBuku.Size = new Size(139, 50);
            btnDaftarBuku.TabIndex = 24;
            btnDaftarBuku.Text = "Daftar Buku";
            btnDaftarBuku.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // DaftarBuku
            // 
            DaftarBuku.Controls.Add(dgvDaftarBuku);
            DaftarBuku.Location = new Point(12, 159);
            DaftarBuku.Name = "DaftarBuku";
            DaftarBuku.Size = new Size(545, 556);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 92);
            panel1.TabIndex = 11;
            // 
            // PinjamBukuMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 723);
            Controls.Add(FormPeminjaman);
            Controls.Add(lblSelamatDatang);
            Controls.Add(DaftarBuku);
            Controls.Add(panel1);
            Name = "PinjamBukuMember";
            Text = "PinjamBukuMember";
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

        private Button buttonPinjam;
        private TextBox textBoxTanggalPengembalian;
        private Label lblTanggalPengembalian;
        private Button btnCari;
        private Label lblTanggalPeminjaman;
        private GroupBox FormPeminjaman;
        private TextBox textBoxTanggalPeminjaman;
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
    }
}