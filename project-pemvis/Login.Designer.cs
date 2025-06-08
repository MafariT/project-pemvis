namespace project_pemvis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pnlLogo = new Panel();
            pictureBox3 = new PictureBox();
            pnlLogin = new Panel();
            toRegister = new Label();
            pnlInvalid = new Panel();
            label4 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            textBox2 = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlLogin.SuspendLayout();
            pnlInvalid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 53, 71);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1613, 84);
            panel1.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 53, 71);
            pnlLogo.Controls.Add(pictureBox3);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(5, 5);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(400, 815);
            pnlLogo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 180);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(372, 383);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(toRegister);
            pnlLogin.Controls.Add(pnlInvalid);
            pnlLogin.Controls.Add(button1);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(panel6);
            pnlLogin.Controls.Add(panel4);
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.ForeColor = Color.White;
            pnlLogin.Location = new Point(405, 5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1213, 815);
            pnlLogin.TabIndex = 2;
            // 
            // toRegister
            // 
            toRegister.AutoSize = true;
            toRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            toRegister.Location = new Point(591, 638);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(280, 32);
            toRegister.TabIndex = 20;
            toRegister.Text = "Belum punya akun? Buat";
            toRegister.Click += toRegister_Click;
            // 
            // pnlInvalid
            // 
            pnlInvalid.Controls.Add(label4);
            pnlInvalid.Location = new Point(445, 471);
            pnlInvalid.Name = "pnlInvalid";
            pnlInvalid.Size = new Size(568, 55);
            pnlInvalid.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(184, 9);
            label4.Name = "label4";
            label4.Size = new Size(178, 37);
            label4.TabIndex = 5;
            label4.Text = "Login Invalid!";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(514, 547);
            button1.Name = "button1";
            button1.Size = new Size(430, 59);
            button1.TabIndex = 19;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = true;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 359);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(429, 345);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 105);
            panel6.TabIndex = 17;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(textBox2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(600, 93);
            panel8.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(16, 74);
            panel9.Name = "panel9";
            panel9.Size = new Size(575, 5);
            panel9.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(16, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(568, 43);
            textBox2.TabIndex = 2;
            textBox2.Text = "Msukkan Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(429, 166);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 101);
            panel4.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 93);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(16, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 5);
            panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(16, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 43);
            textBox1.TabIndex = 2;
            textBox1.Text = "Masukkan Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(265, 376);
            label5.Name = "label5";
            label5.Size = new Size(128, 37);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(559, 45);
            label1.Name = "label1";
            label1.Size = new Size(139, 54);
            label1.TabIndex = 11;
            label1.Text = "Masuk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(265, 197);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1623, 825);
            Controls.Add(pnlLogin);
            Controls.Add(pnlLogo);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Padding = new Padding(5);
            Text = "Login";
            Load += Login_Load;
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlInvalid.ResumeLayout(false);
            pnlInvalid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLogo;
        private Panel pnlLogin;
        private Panel panel5;
        private Label label3;
        private Label toRegister;
        private Panel pnlInvalid;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox2;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}