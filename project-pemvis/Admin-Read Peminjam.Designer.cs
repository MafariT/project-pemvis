namespace project_pemvis
{
    partial class Admin_Read_Peminjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Read_Peminjam));
            buttonHeader = new Button();
            pictureBox3 = new PictureBox();
            labelJudulNavbar = new Label();
            buttonDataBuku = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelTanggalPinjam = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            buttonCari = new Button();
            comboBoxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHeader
            // 
            buttonHeader.BackColor = SystemColors.ActiveCaption;
            buttonHeader.FlatStyle = FlatStyle.Flat;
            buttonHeader.Location = new Point(-2, -4);
            buttonHeader.Margin = new Padding(4, 4, 4, 4);
            buttonHeader.Name = "buttonHeader";
            buttonHeader.Size = new Size(1259, 117);
            buttonHeader.TabIndex = 2;
            buttonHeader.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 15);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // labelJudulNavbar
            // 
            labelJudulNavbar.AutoSize = true;
            labelJudulNavbar.BackColor = SystemColors.ActiveCaption;
            labelJudulNavbar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJudulNavbar.ForeColor = SystemColors.ActiveCaptionText;
            labelJudulNavbar.Location = new Point(123, 36);
            labelJudulNavbar.Margin = new Padding(4, 0, 4, 0);
            labelJudulNavbar.Name = "labelJudulNavbar";
            labelJudulNavbar.Size = new Size(519, 37);
            labelJudulNavbar.TabIndex = 33;
            labelJudulNavbar.Text = "Pengelolaan Buku Perpustakaan";
            // 
            // buttonDataBuku
            // 
            buttonDataBuku.BackColor = Color.FromArgb(12, 53, 71);
            buttonDataBuku.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDataBuku.ForeColor = SystemColors.ButtonHighlight;
            buttonDataBuku.Location = new Point(981, 51);
            buttonDataBuku.Margin = new Padding(4, 4, 4, 4);
            buttonDataBuku.Name = "buttonDataBuku";
            buttonDataBuku.Size = new Size(225, 43);
            buttonDataBuku.TabIndex = 34;
            buttonDataBuku.Text = "Data Buku";
            buttonDataBuku.UseVisualStyleBackColor = false;
            buttonDataBuku.Click += buttonDataBuku_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(817, 181);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(388, 39);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelTanggalPinjam
            // 
            labelTanggalPinjam.AutoSize = true;
            labelTanggalPinjam.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTanggalPinjam.Location = new Point(1016, 149);
            labelTanggalPinjam.Margin = new Padding(4, 0, 4, 0);
            labelTanggalPinjam.Name = "labelTanggalPinjam";
            labelTanggalPinjam.Size = new Size(191, 28);
            labelTanggalPinjam.TabIndex = 36;
            labelTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 329);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1190, 405);
            dataGridView1.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCari);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Location = new Point(15, 137);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(680, 158);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // buttonCari
            // 
            buttonCari.BackColor = Color.FromArgb(12, 53, 71);
            buttonCari.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCari.ForeColor = SystemColors.ButtonHighlight;
            buttonCari.Location = new Point(7, 87);
            buttonCari.Margin = new Padding(4, 4, 4, 4);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(652, 43);
            buttonCari.TabIndex = 11;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = false;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(7, 38);
            comboBoxFilter.Margin = new Padding(4, 4, 4, 4);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(650, 40);
            comboBoxFilter.TabIndex = 0;
            // 
            // Admin_Read_Peminjam
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 751);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelTanggalPinjam);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonDataBuku);
            Controls.Add(labelJudulNavbar);
            Controls.Add(pictureBox3);
            Controls.Add(buttonHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Admin_Read_Peminjam";
            Text = "Admin_Read_Peminjam";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHeader;
        private PictureBox pictureBox3;
        private Label labelJudulNavbar;
        private Button buttonDataBuku;
        private DateTimePicker dateTimePicker1;
        private Label labelTanggalPinjam;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button buttonCari;
        private ComboBox comboBoxFilter;
    }
}