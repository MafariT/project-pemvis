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
            buttonHeader.Location = new Point(-1, -3);
            buttonHeader.Name = "buttonHeader";
            buttonHeader.Size = new Size(968, 92);
            buttonHeader.TabIndex = 2;
            buttonHeader.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 11);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 63);
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
            labelJudulNavbar.Location = new Point(94, 28);
            labelJudulNavbar.Name = "labelJudulNavbar";
            labelJudulNavbar.Size = new Size(387, 28);
            labelJudulNavbar.TabIndex = 33;
            labelJudulNavbar.Text = "Pengelolaan Buku Perpustakaan";
            // 
            // buttonDataBuku
            // 
            buttonDataBuku.BackColor = Color.FromArgb(12, 53, 71);
            buttonDataBuku.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDataBuku.ForeColor = SystemColors.ButtonHighlight;
            buttonDataBuku.Location = new Point(755, 40);
            buttonDataBuku.Name = "buttonDataBuku";
            buttonDataBuku.Size = new Size(173, 34);
            buttonDataBuku.TabIndex = 34;
            buttonDataBuku.Text = "Data Buku";
            buttonDataBuku.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(628, 141);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelTanggalPinjam
            // 
            labelTanggalPinjam.AutoSize = true;
            labelTanggalPinjam.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTanggalPinjam.Location = new Point(782, 117);
            labelTanggalPinjam.Name = "labelTanggalPinjam";
            labelTanggalPinjam.Size = new Size(146, 21);
            labelTanggalPinjam.TabIndex = 36;
            labelTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(916, 317);
            dataGridView1.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCari);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 123);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
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
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(6, 30);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(501, 33);
            comboBoxFilter.TabIndex = 0;
            // 
            // Admin_Read_Peminjam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 586);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelTanggalPinjam);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonDataBuku);
            Controls.Add(labelJudulNavbar);
            Controls.Add(pictureBox3);
            Controls.Add(buttonHeader);
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