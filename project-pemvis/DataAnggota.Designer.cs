namespace project_pemvis
{
    partial class DataAnggota
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
            form = new GroupBox();
            labelTelepon = new Label();
            labelAlamat = new Label();
            labelNim = new Label();
            labelNama = new Label();
            textBoxTelepon = new TextBox();
            textBoxAlamat = new TextBox();
            textBoxNim = new TextBox();
            textBoxNama = new TextBox();
            filter = new GroupBox();
            textBoxFilter = new TextBox();
            buttonFilter = new Button();
            comboBoxFilter = new ComboBox();
            groupBox3 = new GroupBox();
            buttonClear = new Button();
            buttonHapus = new Button();
            buttonEdit = new Button();
            buttonSimpan = new Button();
            dataGridView1 = new DataGridView();
            form.SuspendLayout();
            filter.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // form
            // 
            form.Controls.Add(labelTelepon);
            form.Controls.Add(labelAlamat);
            form.Controls.Add(labelNim);
            form.Controls.Add(labelNama);
            form.Controls.Add(textBoxTelepon);
            form.Controls.Add(textBoxAlamat);
            form.Controls.Add(textBoxNim);
            form.Controls.Add(textBoxNama);
            form.Location = new Point(12, 12);
            form.Name = "form";
            form.Size = new Size(375, 171);
            form.TabIndex = 0;
            form.TabStop = false;
            form.Text = "Form";
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.Location = new Point(21, 112);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(48, 15);
            labelTelepon.TabIndex = 7;
            labelTelepon.Text = "Telepon";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(21, 85);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(45, 15);
            labelAlamat.TabIndex = 6;
            labelAlamat.Text = "Alamat";
            // 
            // labelNim
            // 
            labelNim.AutoSize = true;
            labelNim.Location = new Point(21, 54);
            labelNim.Name = "labelNim";
            labelNim.Size = new Size(30, 15);
            labelNim.TabIndex = 5;
            labelNim.Text = "NIM";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(21, 25);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 4;
            labelNama.Text = "Nama";
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.Location = new Point(108, 109);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.Size = new Size(261, 23);
            textBoxTelepon.TabIndex = 3;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(108, 80);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(261, 23);
            textBoxAlamat.TabIndex = 2;
            // 
            // textBoxNim
            // 
            textBoxNim.Location = new Point(108, 51);
            textBoxNim.Name = "textBoxNim";
            textBoxNim.Size = new Size(261, 23);
            textBoxNim.TabIndex = 1;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(108, 22);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(261, 23);
            textBoxNama.TabIndex = 0;
            // 
            // filter
            // 
            filter.Controls.Add(textBoxFilter);
            filter.Controls.Add(buttonFilter);
            filter.Controls.Add(comboBoxFilter);
            filter.Location = new Point(393, 12);
            filter.Name = "filter";
            filter.Size = new Size(395, 84);
            filter.TabIndex = 1;
            filter.TabStop = false;
            filter.Text = "Filter";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(6, 51);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(383, 23);
            textBoxFilter.TabIndex = 8;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(229, 21);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(160, 23);
            buttonFilter.TabIndex = 1;
            buttonFilter.Text = "Cari";
            buttonFilter.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(6, 22);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(205, 23);
            comboBoxFilter.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonClear);
            groupBox3.Controls.Add(buttonHapus);
            groupBox3.Controls.Add(buttonEdit);
            groupBox3.Controls.Add(buttonSimpan);
            groupBox3.Location = new Point(393, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 81);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aksi";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(6, 52);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(383, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(269, 22);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(120, 23);
            buttonHapus.TabIndex = 4;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(137, 22);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(120, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(6, 22);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(120, 23);
            buttonSimpan.TabIndex = 2;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 249);
            dataGridView1.TabIndex = 3;
            // 
            // DataAnggota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(filter);
            Controls.Add(form);
            Name = "DataAnggota";
            Text = "DataAnggota";
            form.ResumeLayout(false);
            form.PerformLayout();
            filter.ResumeLayout(false);
            filter.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox form;
        private GroupBox filter;
        private TextBox textBoxTelepon;
        private TextBox textBoxAlamat;
        private TextBox textBoxNim;
        private TextBox textBoxNama;
        private GroupBox groupBox3;
        private Label labelTelepon;
        private Label labelAlamat;
        private Label labelNim;
        private Label labelNama;
        private Button buttonFilter;
        private ComboBox comboBoxFilter;
        private Button buttonClear;
        private Button buttonHapus;
        private Button buttonEdit;
        private Button buttonSimpan;
        private DataGridView dataGridView1;
        private TextBox textBoxFilter;
    }
}