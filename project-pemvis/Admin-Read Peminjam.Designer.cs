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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonHeader = new Button();
            pictureBox3 = new PictureBox();
            labelJudulNavbar = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelTanggalPinjam = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxFilter = new TextBox();
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
            buttonHeader.Location = new Point(-1, -2);
            buttonHeader.Margin = new Padding(2);
            buttonHeader.Name = "buttonHeader";
            buttonHeader.Size = new Size(678, 55);
            buttonHeader.TabIndex = 2;
            buttonHeader.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 7);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 38);
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
            labelJudulNavbar.Location = new Point(66, 17);
            labelJudulNavbar.Margin = new Padding(2, 0, 2, 0);
            labelJudulNavbar.Name = "labelJudulNavbar";
            labelJudulNavbar.Size = new Size(268, 18);
            labelJudulNavbar.TabIndex = 33;
            labelJudulNavbar.Text = "Pengelolaan Buku Perpustakaan";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(440, 85);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelTanggalPinjam
            // 
            labelTanggalPinjam.AutoSize = true;
            labelTanggalPinjam.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTanggalPinjam.Location = new Point(547, 70);
            labelTanggalPinjam.Margin = new Padding(2, 0, 2, 0);
            labelTanggalPinjam.Name = "labelTanggalPinjam";
            labelTanggalPinjam.Size = new Size(97, 14);
            labelTanggalPinjam.TabIndex = 36;
            labelTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(8, 154);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(641, 190);
            dataGridView1.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFilter);
            groupBox1.Controls.Add(buttonCari);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Location = new Point(8, 64);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(366, 74);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(184, 18);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(171, 23);
            textBoxFilter.TabIndex = 41;
            // 
            // buttonCari
            // 
            buttonCari.BackColor = Color.FromArgb(12, 53, 71);
            buttonCari.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCari.ForeColor = SystemColors.ButtonHighlight;
            buttonCari.Location = new Point(4, 41);
            buttonCari.Margin = new Padding(2);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(351, 20);
            buttonCari.TabIndex = 11;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = false;
            buttonCari.Click += buttonCari_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Nama Peminjam", "Judul Buku" });
            comboBoxFilter.Location = new Point(4, 18);
            comboBoxFilter.Margin = new Padding(2);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(175, 23);
            comboBoxFilter.TabIndex = 0;
            // 
            // Admin_Read_Peminjam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 352);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelTanggalPinjam);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelJudulNavbar);
            Controls.Add(pictureBox3);
            Controls.Add(buttonHeader);
            Margin = new Padding(2);
            Name = "Admin_Read_Peminjam";
            Text = "Admin_Read_Peminjam";
            Load += Admin_Read_Peminjam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHeader;
        private PictureBox pictureBox3;
        private Label labelJudulNavbar;
        private DateTimePicker dateTimePicker1;
        private Label labelTanggalPinjam;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button buttonCari;
        private ComboBox comboBoxFilter;
        private TextBox textBoxFilter;
    }
}