namespace project_pemvis
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            btnUpdateProfil = new Button();
            textBoxAlamat = new TextBox();
            textBoxNoHp = new TextBox();
            textBoxNama = new TextBox();
            lblAlamat = new Label();
            lblNama = new Label();
            grpProfil = new GroupBox();
            lblNoHp = new Label();
            DaftarBuku = new GroupBox();
            dgvHistori = new DataGridView();
            Form = new GroupBox();
            Aksi = new GroupBox();
            btnReload = new Button();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnCari = new Button();
            btnHapus = new Button();
            textBoxJudul = new TextBox();
            lblJudul = new Label();
            panel1 = new Panel();
            btnProfil = new Button();
            btnDaftarBuku = new Button();
            pictureBox3 = new PictureBox();
            grpProfil.SuspendLayout();
            DaftarBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).BeginInit();
            Form.SuspendLayout();
            Aksi.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateProfil
            // 
            btnUpdateProfil.BackColor = SystemColors.ActiveCaption;
            btnUpdateProfil.FlatStyle = FlatStyle.Popup;
            btnUpdateProfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfil.ForeColor = Color.White;
            btnUpdateProfil.Location = new Point(88, 147);
            btnUpdateProfil.Name = "btnUpdateProfil";
            btnUpdateProfil.Size = new Size(276, 29);
            btnUpdateProfil.TabIndex = 16;
            btnUpdateProfil.Text = "Update Profil";
            btnUpdateProfil.UseVisualStyleBackColor = false;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(88, 105);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(278, 27);
            textBoxAlamat.TabIndex = 18;
            // 
            // textBoxNoHp
            // 
            textBoxNoHp.Location = new Point(88, 69);
            textBoxNoHp.Name = "textBoxNoHp";
            textBoxNoHp.Size = new Size(278, 27);
            textBoxNoHp.TabIndex = 17;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(88, 32);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(278, 27);
            textBoxNama.TabIndex = 16;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(6, 112);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(57, 20);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(6, 39);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(49, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // grpProfil
            // 
            grpProfil.Controls.Add(btnUpdateProfil);
            grpProfil.Controls.Add(textBoxAlamat);
            grpProfil.Controls.Add(textBoxNoHp);
            grpProfil.Controls.Add(textBoxNama);
            grpProfil.Controls.Add(lblAlamat);
            grpProfil.Controls.Add(lblNoHp);
            grpProfil.Controls.Add(lblNama);
            grpProfil.Location = new Point(14, 99);
            grpProfil.Name = "grpProfil";
            grpProfil.Size = new Size(382, 202);
            grpProfil.TabIndex = 18;
            grpProfil.TabStop = false;
            grpProfil.Text = "Profil";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(6, 76);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(55, 20);
            lblNoHp.TabIndex = 1;
            lblNoHp.Text = "No. HP";
            // 
            // DaftarBuku
            // 
            DaftarBuku.Controls.Add(dgvHistori);
            DaftarBuku.Controls.Add(Form);
            DaftarBuku.Location = new Point(14, 307);
            DaftarBuku.Name = "DaftarBuku";
            DaftarBuku.Size = new Size(1030, 354);
            DaftarBuku.TabIndex = 17;
            DaftarBuku.TabStop = false;
            DaftarBuku.Text = "Histori Peminjaman";
            // 
            // dgvHistori
            // 
            dgvHistori.BackgroundColor = Color.White;
            dgvHistori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistori.Location = new Point(12, 26);
            dgvHistori.Name = "dgvHistori";
            dgvHistori.RowHeadersWidth = 51;
            dgvHistori.Size = new Size(520, 319);
            dgvHistori.TabIndex = 1;
            // 
            // Form
            // 
            Form.Controls.Add(Aksi);
            Form.Controls.Add(btnCari);
            Form.Controls.Add(btnHapus);
            Form.Controls.Add(textBoxJudul);
            Form.Controls.Add(lblJudul);
            Form.Location = new Point(552, 26);
            Form.Name = "Form";
            Form.Size = new Size(472, 319);
            Form.TabIndex = 14;
            Form.TabStop = false;
            Form.Text = "Aksi";
            // 
            // Aksi
            // 
            Aksi.Controls.Add(btnReload);
            Aksi.Controls.Add(btnSimpan);
            Aksi.Controls.Add(btnEdit);
            Aksi.Location = new Point(6, 107);
            Aksi.Name = "Aksi";
            Aksi.Size = new Size(456, 146);
            Aksi.TabIndex = 15;
            Aksi.TabStop = false;
            Aksi.Text = "Edit Tanggal";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ActiveCaption;
            btnReload.FlatStyle = FlatStyle.Popup;
            btnReload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(6, 105);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(444, 29);
            btnReload.TabIndex = 17;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ActiveCaption;
            btnSimpan.FlatStyle = FlatStyle.Popup;
            btnSimpan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(6, 70);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(444, 29);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(6, 35);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(444, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.ActiveCaption;
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(186, 72);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(276, 29);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.LightCoral;
            btnHapus.FlatStyle = FlatStyle.Popup;
            btnHapus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(6, 268);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(460, 29);
            btnHapus.TabIndex = 14;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(186, 26);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(278, 27);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(17, 26);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(43, 20);
            lblJudul.TabIndex = 8;
            lblJudul.Text = "Judul";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(btnDaftarBuku);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 92);
            panel1.TabIndex = 16;
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
            // Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 671);
            Controls.Add(grpProfil);
            Controls.Add(DaftarBuku);
            Controls.Add(panel1);
            Name = "Profil";
            Text = "Profil";
            grpProfil.ResumeLayout(false);
            grpProfil.PerformLayout();
            DaftarBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistori).EndInit();
            Form.ResumeLayout(false);
            Form.PerformLayout();
            Aksi.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateProfil;
        private TextBox textBoxAlamat;
        private TextBox textBoxNoHp;
        private TextBox textBoxNama;
        private Label lblAlamat;
        private Label lblNama;
        private GroupBox grpProfil;
        private Label lblNoHp;
        private GroupBox DaftarBuku;
        private DataGridView dgvHistori;
        private GroupBox Form;
        private GroupBox Aksi;
        private Button btnReload;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnCari;
        private Button btnHapus;
        private TextBox textBoxJudul;
        private Label lblJudul;
        private Panel panel1;
        private Button btnProfil;
        private Button btnDaftarBuku;
        private PictureBox pictureBox3;
    }
}