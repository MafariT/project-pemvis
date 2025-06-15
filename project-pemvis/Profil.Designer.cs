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
            dateTimeTglLahir = new DateTimePicker();
            label1 = new Label();
            lblNoHp = new Label();
            DaftarBuku = new GroupBox();
            labelHalaman = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            dgvHistori = new DataGridView();
            Form = new GroupBox();
            btnCari = new Button();
            textBoxJudul = new TextBox();
            lblJudul = new Label();
            panel1 = new Panel();
            btnProfil = new Button();
            btnDaftarBuku = new Button();
            pictureBox3 = new PictureBox();
            btnKeluar = new Button();
            button2 = new Button();
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
            btnUpdateProfil.Location = new Point(76, 150);
            btnUpdateProfil.Margin = new Padding(3, 2, 3, 2);
            btnUpdateProfil.Name = "btnUpdateProfil";
            btnUpdateProfil.Size = new Size(241, 22);
            btnUpdateProfil.TabIndex = 16;
            btnUpdateProfil.Text = "Update Profil";
            btnUpdateProfil.UseVisualStyleBackColor = false;
            btnUpdateProfil.Click += btnUpdateProfil_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(117, 83);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.ScrollBars = ScrollBars.Vertical;
            txtAlamat.Size = new Size(244, 30);
            txtAlamat.TabIndex = 18;
            // 
            // txtNohp
            // 
            txtNohp.Location = new Point(117, 52);
            txtNohp.Margin = new Padding(3, 2, 3, 2);
            txtNohp.Name = "txtNohp";
            txtNohp.Size = new Size(244, 23);
            txtNohp.TabIndex = 17;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(117, 26);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(244, 23);
            txtNama.TabIndex = 16;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(5, 84);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(45, 15);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(5, 26);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(39, 15);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // grpProfil
            // 
            grpProfil.Controls.Add(dateTimeTglLahir);
            grpProfil.Controls.Add(label1);
            grpProfil.Controls.Add(btnUpdateProfil);
            grpProfil.Controls.Add(txtAlamat);
            grpProfil.Controls.Add(txtNohp);
            grpProfil.Controls.Add(txtNama);
            grpProfil.Controls.Add(lblAlamat);
            grpProfil.Controls.Add(lblNoHp);
            grpProfil.Controls.Add(lblNama);
            grpProfil.Location = new Point(12, 74);
            grpProfil.Margin = new Padding(3, 2, 3, 2);
            grpProfil.Name = "grpProfil";
            grpProfil.Padding = new Padding(3, 2, 3, 2);
            grpProfil.Size = new Size(424, 177);
            grpProfil.TabIndex = 18;
            grpProfil.TabStop = false;
            grpProfil.Text = "Profil";
            // 
            // dateTimeTglLahir
            // 
            dateTimeTglLahir.Location = new Point(117, 119);
            dateTimeTglLahir.Margin = new Padding(2, 1, 2, 1);
            dateTimeTglLahir.Name = "dateTimeTglLahir";
            dateTimeTglLahir.Size = new Size(244, 23);
            dateTimeTglLahir.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 119);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 20;
            label1.Text = "Tanggal Lahir";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(5, 57);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(45, 15);
            lblNoHp.TabIndex = 1;
            lblNoHp.Text = "No. HP";
            // 
            // DaftarBuku
            // 
            DaftarBuku.Controls.Add(labelHalaman);
            DaftarBuku.Controls.Add(btnNext);
            DaftarBuku.Controls.Add(btnPrev);
            DaftarBuku.Controls.Add(dgvHistori);
            DaftarBuku.Location = new Point(456, 165);
            DaftarBuku.Margin = new Padding(3, 2, 3, 2);
            DaftarBuku.Name = "DaftarBuku";
            DaftarBuku.Padding = new Padding(3, 2, 3, 2);
            DaftarBuku.Size = new Size(429, 245);
            DaftarBuku.TabIndex = 17;
            DaftarBuku.TabStop = false;
            DaftarBuku.Text = "Histori Peminjaman";
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.Location = new Point(319, 222);
            labelHalaman.Margin = new Padding(2, 0, 2, 0);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(96, 15);
            labelHalaman.TabIndex = 36;
            labelHalaman.Text = "Halaman 1 dari 2";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(114, 219);
            btnNext.Margin = new Padding(2, 2, 2, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(98, 21);
            btnNext.TabIndex = 35;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(11, 219);
            btnPrev.Margin = new Padding(2, 2, 2, 2);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(98, 21);
            btnPrev.TabIndex = 34;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // dgvHistori
            // 
            dgvHistori.BackgroundColor = Color.White;
            dgvHistori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistori.Location = new Point(11, 20);
            dgvHistori.Margin = new Padding(3, 2, 3, 2);
            dgvHistori.Name = "dgvHistori";
            dgvHistori.RowHeadersWidth = 51;
            dgvHistori.Size = new Size(414, 195);
            dgvHistori.TabIndex = 1;
            // 
            // Form
            // 
            Form.Controls.Add(btnCari);
            Form.Controls.Add(textBoxJudul);
            Form.Controls.Add(lblJudul);
            Form.Location = new Point(456, 74);
            Form.Margin = new Padding(3, 2, 3, 2);
            Form.Name = "Form";
            Form.Padding = new Padding(3, 2, 3, 2);
            Form.Size = new Size(429, 82);
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
            btnCari.Location = new Point(15, 50);
            btnCari.Margin = new Padding(3, 2, 3, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(299, 22);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(73, 18);
            textBoxJudul.Margin = new Padding(3, 2, 3, 2);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(244, 23);
            textBoxJudul.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(15, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(35, 15);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 70);
            panel1.TabIndex = 16;
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
            btnDaftarBuku.Click += btnDaftarBuku_Click;
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
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(192, 0, 0);
            btnKeluar.FlatStyle = FlatStyle.Popup;
            btnKeluar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(18, 267);
            btnKeluar.Margin = new Padding(3, 2, 3, 2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(193, 22);
            btnKeluar.TabIndex = 22;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(216, 267);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(221, 22);
            button2.TabIndex = 23;
            button2.Text = "Cetak Riwayat";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 427);
            Controls.Add(button2);
            Controls.Add(btnKeluar);
            Controls.Add(grpProfil);
            Controls.Add(Form);
            Controls.Add(DaftarBuku);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            grpProfil.ResumeLayout(false);
            grpProfil.PerformLayout();
            DaftarBuku.ResumeLayout(false);
            DaftarBuku.PerformLayout();
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
        private DateTimePicker dateTimeTglLahir;
        private Button btnKeluar;
        private Button button2;
        private Label labelHalaman;
        private Button btnNext;
        private Button btnPrev;
    }
}