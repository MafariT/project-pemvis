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
            txtAlamat = new TextBox();
            txtNohp = new TextBox();
            txtNama = new TextBox();
            lblAlamat = new Label();
            lblNama = new Label();
            grpProfil = new GroupBox();
            lblNoHp = new Label();
            DaftarBuku = new GroupBox();
            dgvHistori = new DataGridView();
            Form = new GroupBox();
            btnCari = new Button();
            textBoxJudul = new TextBox();
            lblJudul = new Label();
            panel1 = new Panel();
            btnProfil = new Button();
            btnDaftarBuku = new Button();
            pictureBox3 = new PictureBox();
            txtTanggalLahir = new TextBox();
            label1 = new Label();
            grpProfil.SuspendLayout();
            DaftarBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistori).BeginInit();
            Form.SuspendLayout();
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
            btnUpdateProfil.Location = new Point(142, 321);
            btnUpdateProfil.Margin = new Padding(5, 5, 5, 5);
            btnUpdateProfil.Name = "btnUpdateProfil";
            btnUpdateProfil.Size = new Size(448, 46);
            btnUpdateProfil.TabIndex = 16;
            btnUpdateProfil.Text = "Update Profil";
            btnUpdateProfil.UseVisualStyleBackColor = false;
            btnUpdateProfil.Click += btnUpdateProfil_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(217, 177);
            txtAlamat.Margin = new Padding(5, 5, 5, 5);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.ScrollBars = ScrollBars.Vertical;
            txtAlamat.Size = new Size(449, 60);
            txtAlamat.TabIndex = 18;
            // 
            // txtNohp
            // 
            txtNohp.Location = new Point(217, 111);
            txtNohp.Margin = new Padding(5, 5, 5, 5);
            txtNohp.Name = "txtNohp";
            txtNohp.Size = new Size(449, 39);
            txtNohp.TabIndex = 17;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(217, 55);
            txtNama.Margin = new Padding(5, 5, 5, 5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(449, 39);
            txtNama.TabIndex = 16;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(10, 179);
            lblAlamat.Margin = new Padding(5, 0, 5, 0);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(88, 32);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(10, 55);
            lblNama.Margin = new Padding(5, 0, 5, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(77, 32);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // grpProfil
            // 
            grpProfil.Controls.Add(label1);
            grpProfil.Controls.Add(txtTanggalLahir);
            grpProfil.Controls.Add(btnUpdateProfil);
            grpProfil.Controls.Add(txtAlamat);
            grpProfil.Controls.Add(txtNohp);
            grpProfil.Controls.Add(txtNama);
            grpProfil.Controls.Add(lblAlamat);
            grpProfil.Controls.Add(lblNoHp);
            grpProfil.Controls.Add(lblNama);
            grpProfil.Location = new Point(23, 158);
            grpProfil.Margin = new Padding(5, 5, 5, 5);
            grpProfil.Name = "grpProfil";
            grpProfil.Padding = new Padding(5, 5, 5, 5);
            grpProfil.Size = new Size(788, 377);
            grpProfil.TabIndex = 18;
            grpProfil.TabStop = false;
            grpProfil.Text = "Profil";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(10, 122);
            lblNoHp.Margin = new Padding(5, 0, 5, 0);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(88, 32);
            lblNoHp.TabIndex = 1;
            lblNoHp.Text = "No. HP";
            // 
            // DaftarBuku
            // 
            DaftarBuku.Controls.Add(dgvHistori);
            DaftarBuku.Location = new Point(23, 538);
            DaftarBuku.Margin = new Padding(5, 5, 5, 5);
            DaftarBuku.Name = "DaftarBuku";
            DaftarBuku.Padding = new Padding(5, 5, 5, 5);
            DaftarBuku.Size = new Size(1674, 519);
            DaftarBuku.TabIndex = 17;
            DaftarBuku.TabStop = false;
            DaftarBuku.Text = "Histori Peminjaman";
            // 
            // dgvHistori
            // 
            dgvHistori.BackgroundColor = Color.White;
            dgvHistori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistori.Location = new Point(20, 42);
            dgvHistori.Margin = new Padding(5, 5, 5, 5);
            dgvHistori.Name = "dgvHistori";
            dgvHistori.RowHeadersWidth = 51;
            dgvHistori.Size = new Size(1618, 510);
            dgvHistori.TabIndex = 1;
            // 
            // Form
            // 
            Form.Controls.Add(btnCari);
            Form.Controls.Add(textBoxJudul);
            Form.Controls.Add(lblJudul);
            Form.Location = new Point(847, 158);
            Form.Margin = new Padding(5, 5, 5, 5);
            Form.Name = "Form";
            Form.Padding = new Padding(5, 5, 5, 5);
            Form.Size = new Size(609, 174);
            Form.TabIndex = 14;
            Form.TabStop = false;
            Form.Text = "Aksi";
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.ActiveCaption;
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(28, 107);
            btnCari.Margin = new Padding(5, 5, 5, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(556, 46);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(135, 39);
            textBoxJudul.Margin = new Padding(5, 5, 5, 5);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(449, 39);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(28, 42);
            lblJudul.Margin = new Padding(5, 0, 5, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(71, 32);
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
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1715, 146);
            panel1.TabIndex = 16;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1558, 32);
            btnProfil.Margin = new Padding(5, 5, 5, 5);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(136, 80);
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
            btnDaftarBuku.Location = new Point(1323, 32);
            btnDaftarBuku.Margin = new Padding(5, 5, 5, 5);
            btnDaftarBuku.Name = "btnDaftarBuku";
            btnDaftarBuku.Size = new Size(226, 80);
            btnDaftarBuku.TabIndex = 24;
            btnDaftarBuku.Text = "Daftar Buku";
            btnDaftarBuku.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // txtTanggalLahir
            // 
            txtTanggalLahir.Location = new Point(217, 254);
            txtTanggalLahir.Margin = new Padding(5);
            txtTanggalLahir.Name = "txtTanggalLahir";
            txtTanggalLahir.Size = new Size(449, 39);
            txtTanggalLahir.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 254);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 20;
            label1.Text = "Tanggal Lahir";
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1074);
            Controls.Add(grpProfil);
            Controls.Add(Form);
            Controls.Add(DaftarBuku);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            grpProfil.ResumeLayout(false);
            grpProfil.PerformLayout();
            DaftarBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistori).EndInit();
            Form.ResumeLayout(false);
            Form.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateProfil;
        private TextBox txtAlamat;
        private TextBox txtNohp;
        private TextBox txtNama;
        private Label lblAlamat;
        private Label lblNama;
        private GroupBox grpProfil;
        private Label lblNoHp;
        private GroupBox DaftarBuku;
        private DataGridView dgvHistori;
        private GroupBox Form;
        private Button btnCari;
        private TextBox textBoxJudul;
        private Label lblJudul;
        private Panel panel1;
        private Button btnProfil;
        private Button btnDaftarBuku;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtTanggalLahir;
    }
}