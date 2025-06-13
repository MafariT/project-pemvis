namespace project_pemvis
{
    partial class Admin_Data_Buku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Data_Buku));
            groupBoxInputBuku = new GroupBox();
            buttonHeader = new Button();
            pictureBox3 = new PictureBox();
            labelIDBuku = new Label();
            labelJudul = new Label();
            labelPenulis = new Label();
            labelPenerbit = new Label();
            labelTahunTerbit = new Label();
            textBoxIDBuku = new TextBox();
            textBoxJudul = new TextBox();
            textBoxPenulis = new TextBox();
            textBoxPenerbit = new TextBox();
            textBoxTahunTerbit = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxFilter = new ComboBox();
            textBoxFilter = new TextBox();
            buttonCari = new Button();
            groupBoxAksi = new GroupBox();
            buttonSimpan = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonReload = new Button();
            buttonClear = new Button();
            buttonCetak = new Button();
            dataGridView1 = new DataGridView();
            buttonPrev = new Button();
            buttonNext = new Button();
            labelHalaman = new Label();
            labelJudulNavbar = new Label();
            buttonPeminjamBuku = new Button();
            groupBoxInputBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxAksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInputBuku
            // 
            groupBoxInputBuku.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInputBuku.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxInputBuku.Controls.Add(textBoxTahunTerbit);
            groupBoxInputBuku.Controls.Add(textBoxPenerbit);
            groupBoxInputBuku.Controls.Add(textBoxPenulis);
            groupBoxInputBuku.Controls.Add(textBoxJudul);
            groupBoxInputBuku.Controls.Add(textBoxIDBuku);
            groupBoxInputBuku.Controls.Add(labelTahunTerbit);
            groupBoxInputBuku.Controls.Add(labelPenerbit);
            groupBoxInputBuku.Controls.Add(labelPenulis);
            groupBoxInputBuku.Controls.Add(labelJudul);
            groupBoxInputBuku.Controls.Add(labelIDBuku);
            groupBoxInputBuku.Location = new Point(12, 98);
            groupBoxInputBuku.Name = "groupBoxInputBuku";
            groupBoxInputBuku.Size = new Size(523, 271);
            groupBoxInputBuku.TabIndex = 0;
            groupBoxInputBuku.TabStop = false;
            groupBoxInputBuku.Text = "Input Buku";
            // 
            // buttonHeader
            // 
            buttonHeader.BackColor = SystemColors.ActiveCaption;
            buttonHeader.FlatStyle = FlatStyle.Flat;
            buttonHeader.Location = new Point(-9, -9);
            buttonHeader.Name = "buttonHeader";
            buttonHeader.Size = new Size(1260, 92);
            buttonHeader.TabIndex = 1;
            buttonHeader.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 11);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // labelIDBuku
            // 
            labelIDBuku.AutoSize = true;
            labelIDBuku.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDBuku.Location = new Point(20, 38);
            labelIDBuku.Name = "labelIDBuku";
            labelIDBuku.Size = new Size(79, 21);
            labelIDBuku.TabIndex = 0;
            labelIDBuku.Text = "ID Buku";
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJudul.Location = new Point(20, 80);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(58, 21);
            labelJudul.TabIndex = 1;
            labelJudul.Text = "Judul";
            // 
            // labelPenulis
            // 
            labelPenulis.AutoSize = true;
            labelPenulis.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPenulis.Location = new Point(20, 124);
            labelPenulis.Name = "labelPenulis";
            labelPenulis.Size = new Size(75, 21);
            labelPenulis.TabIndex = 2;
            labelPenulis.Text = "Penulis";
            // 
            // labelPenerbit
            // 
            labelPenerbit.AutoSize = true;
            labelPenerbit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPenerbit.Location = new Point(20, 167);
            labelPenerbit.Name = "labelPenerbit";
            labelPenerbit.Size = new Size(85, 21);
            labelPenerbit.TabIndex = 3;
            labelPenerbit.Text = "Penerbit";
            // 
            // labelTahunTerbit
            // 
            labelTahunTerbit.AutoSize = true;
            labelTahunTerbit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTahunTerbit.Location = new Point(20, 211);
            labelTahunTerbit.Name = "labelTahunTerbit";
            labelTahunTerbit.Size = new Size(122, 21);
            labelTahunTerbit.TabIndex = 4;
            labelTahunTerbit.Text = "Tahun Terbit";
            // 
            // textBoxIDBuku
            // 
            textBoxIDBuku.Location = new Point(216, 28);
            textBoxIDBuku.Name = "textBoxIDBuku";
            textBoxIDBuku.Size = new Size(291, 31);
            textBoxIDBuku.TabIndex = 5;
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(216, 70);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(291, 31);
            textBoxJudul.TabIndex = 6;
            // 
            // textBoxPenulis
            // 
            textBoxPenulis.Location = new Point(216, 114);
            textBoxPenulis.Name = "textBoxPenulis";
            textBoxPenulis.Size = new Size(291, 31);
            textBoxPenulis.TabIndex = 7;
            // 
            // textBoxPenerbit
            // 
            textBoxPenerbit.Location = new Point(216, 157);
            textBoxPenerbit.Name = "textBoxPenerbit";
            textBoxPenerbit.Size = new Size(291, 31);
            textBoxPenerbit.TabIndex = 8;
            // 
            // textBoxTahunTerbit
            // 
            textBoxTahunTerbit.Location = new Point(216, 201);
            textBoxTahunTerbit.Name = "textBoxTahunTerbit";
            textBoxTahunTerbit.Size = new Size(291, 31);
            textBoxTahunTerbit.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCari);
            groupBox1.Controls.Add(textBoxFilter);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Location = new Point(12, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 123);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(6, 30);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(182, 33);
            comboBoxFilter.TabIndex = 0;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(216, 32);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(291, 31);
            textBoxFilter.TabIndex = 10;
            // 
            // buttonCari
            // 
            buttonCari.BackColor = Color.FromArgb(12, 53, 71);
            buttonCari.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCari.ForeColor = SystemColors.ButtonHighlight;
            buttonCari.Location = new Point(6, 69);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(501, 34);
            buttonCari.TabIndex = 11;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = false;
            // 
            // groupBoxAksi
            // 
            groupBoxAksi.BackColor = SystemColors.GradientActiveCaption;
            groupBoxAksi.Controls.Add(buttonCetak);
            groupBoxAksi.Controls.Add(buttonClear);
            groupBoxAksi.Controls.Add(buttonReload);
            groupBoxAksi.Controls.Add(buttonHapus);
            groupBoxAksi.Controls.Add(buttonEdit);
            groupBoxAksi.Controls.Add(buttonSimpan);
            groupBoxAksi.Location = new Point(12, 532);
            groupBoxAksi.Name = "groupBoxAksi";
            groupBoxAksi.Size = new Size(523, 136);
            groupBoxAksi.TabIndex = 26;
            groupBoxAksi.TabStop = false;
            groupBoxAksi.Text = "Aksi";
            // 
            // buttonSimpan
            // 
            buttonSimpan.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSimpan.Location = new Point(6, 30);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(127, 35);
            buttonSimpan.TabIndex = 0;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(139, 30);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(117, 35);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Brown;
            buttonHapus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHapus.ForeColor = SystemColors.ButtonHighlight;
            buttonHapus.Location = new Point(385, 30);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(122, 35);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += button2_Click_1;
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReload.Location = new Point(262, 30);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(117, 35);
            buttonReload.TabIndex = 27;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(12, 53, 71);
            buttonClear.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(6, 83);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(250, 35);
            buttonClear.TabIndex = 28;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonCetak
            // 
            buttonCetak.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCetak.Location = new Point(262, 83);
            buttonCetak.Name = "buttonCetak";
            buttonCetak.Size = new Size(245, 35);
            buttonCetak.TabIndex = 29;
            buttonCetak.Text = "Cetak";
            buttonCetak.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(557, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(673, 496);
            dataGridView1.TabIndex = 27;
            // 
            // buttonPrev
            // 
            buttonPrev.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrev.Location = new Point(557, 615);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(82, 35);
            buttonPrev.TabIndex = 28;
            buttonPrev.Text = "Prev";
            buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNext.Location = new Point(655, 615);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(82, 35);
            buttonNext.TabIndex = 29;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.Location = new Point(1083, 619);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(147, 25);
            labelHalaman.TabIndex = 30;
            labelHalaman.Text = "Halaman 1 dari 2";
            // 
            // labelJudulNavbar
            // 
            labelJudulNavbar.AutoSize = true;
            labelJudulNavbar.BackColor = SystemColors.ActiveCaption;
            labelJudulNavbar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJudulNavbar.ForeColor = SystemColors.ActiveCaptionText;
            labelJudulNavbar.Location = new Point(95, 22);
            labelJudulNavbar.Name = "labelJudulNavbar";
            labelJudulNavbar.Size = new Size(387, 28);
            labelJudulNavbar.TabIndex = 32;
            labelJudulNavbar.Text = "Pengelolaan Buku Perpustakaan";
            // 
            // buttonPeminjamBuku
            // 
            buttonPeminjamBuku.BackColor = Color.FromArgb(12, 53, 71);
            buttonPeminjamBuku.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPeminjamBuku.ForeColor = SystemColors.ButtonHighlight;
            buttonPeminjamBuku.Location = new Point(1057, 40);
            buttonPeminjamBuku.Name = "buttonPeminjamBuku";
            buttonPeminjamBuku.Size = new Size(173, 34);
            buttonPeminjamBuku.TabIndex = 33;
            buttonPeminjamBuku.Text = "Peminjam Buku";
            buttonPeminjamBuku.UseVisualStyleBackColor = false;
            // 
            // Admin_Data_Buku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 680);
            Controls.Add(buttonPeminjamBuku);
            Controls.Add(labelJudulNavbar);
            Controls.Add(labelHalaman);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxAksi);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(buttonHeader);
            Controls.Add(groupBoxInputBuku);
            Name = "Admin_Data_Buku";
            Text = "Admin_Data_Buku";
            Load += Admin_Data_Buku_Load;
            groupBoxInputBuku.ResumeLayout(false);
            groupBoxInputBuku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxAksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInputBuku;
        private Button buttonHeader;
        private PictureBox pictureBox3;
        private Label labelTahunTerbit;
        private Label labelPenerbit;
        private Label labelPenulis;
        private Label labelJudul;
        private Label labelIDBuku;
        private TextBox textBoxTahunTerbit;
        private TextBox textBoxPenerbit;
        private TextBox textBoxPenulis;
        private TextBox textBoxJudul;
        private TextBox textBoxIDBuku;
        private GroupBox groupBox1;
        private ComboBox comboBoxFilter;
        private TextBox textBoxFilter;
        private Button buttonCari;
        private GroupBox groupBoxAksi;
        private Button buttonSimpan;
        private Button buttonEdit;
        private Button buttonHapus;
        private Button buttonReload;
        private Button buttonCetak;
        private Button buttonClear;
        private DataGridView dataGridView1;
        private Button buttonPrev;
        private Button buttonNext;
        private Label labelHalaman;
        private Label labelJudulNavbar;
        private Button buttonPeminjamBuku;
    }
}