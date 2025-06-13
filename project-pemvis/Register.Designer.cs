namespace project_pemvis
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pnlLogo = new Panel();
            pictureBox3 = new PictureBox();
            pnlLogin = new Panel();
            toRegister = new Label();
            btnDaftar = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            txtKonfirPassword = new TextBox();
            panel6 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            txtEmail = new TextBox();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtUsername = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlLogin.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 53, 71);
            pnlLogo.Controls.Add(pictureBox3);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(400, 867);
            pnlLogo.TabIndex = 2;
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
            pnlLogin.BackColor = Color.FromArgb(30, 30, 30);
            pnlLogin.Controls.Add(toRegister);
            pnlLogin.Controls.Add(btnDaftar);
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Controls.Add(panel6);
            pnlLogin.Controls.Add(panel10);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(panel4);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.ForeColor = Color.White;
            pnlLogin.Location = new Point(400, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1100, 867);
            pnlLogin.TabIndex = 3;
            // 
            // toRegister
            // 
            toRegister.AutoSize = true;
            toRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            toRegister.Location = new Point(427, 741);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(269, 32);
            toRegister.TabIndex = 23;
            toRegister.Text = "Sudah punya akun? Klik";
            toRegister.Click += toRegister_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.FlatAppearance.BorderColor = Color.Lime;
            btnDaftar.FlatAppearance.BorderSize = 2;
            btnDaftar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Segoe UI", 12F);
            btnDaftar.ForeColor = Color.Lime;
            btnDaftar.Location = new Point(350, 650);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(430, 59);
            btnDaftar.TabIndex = 22;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(296, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 105);
            panel1.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(txtKonfirPassword);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 93);
            panel5.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(16, 74);
            panel7.Name = "panel7";
            panel7.Size = new Size(575, 5);
            panel7.TabIndex = 4;
            // 
            // txtKonfirPassword
            // 
            txtKonfirPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtKonfirPassword.BorderStyle = BorderStyle.None;
            txtKonfirPassword.Font = new Font("Segoe UI", 12F);
            txtKonfirPassword.ForeColor = Color.Gray;
            txtKonfirPassword.Location = new Point(16, 14);
            txtKonfirPassword.Name = "txtKonfirPassword";
            txtKonfirPassword.Size = new Size(568, 43);
            txtKonfirPassword.TabIndex = 2;
            txtKonfirPassword.Text = "Konfirmasi Password";
            txtKonfirPassword.MouseEnter += txtKonfirPassword_MouseEnter;
            txtKonfirPassword.MouseLeave += txtKonfirPassword_MouseLeave_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(296, 266);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 105);
            panel6.TabIndex = 17;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(txtEmail);
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
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(16, 14);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(568, 43);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Masukkan Email";
            txtEmail.MouseEnter += txtEmail_MouseEnter;
            txtEmail.MouseLeave += txtEmail_MouseLeave;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(296, 377);
            panel10.Name = "panel10";
            panel10.Size = new Size(600, 101);
            panel10.TabIndex = 19;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(txtPassword);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(600, 93);
            panel11.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(16, 74);
            panel12.Name = "panel12";
            panel12.Size = new Size(575, 5);
            panel12.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(16, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(568, 43);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Masukkan Password";
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            txtPassword.MouseLeave += txtPassword_MouseLeave_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(88, 524);
            label3.Name = "label3";
            label3.Size = new Size(205, 37);
            label3.TabIndex = 20;
            label3.Text = "Konfir Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(296, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 101);
            panel4.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtUsername);
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
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(16, 14);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(568, 43);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Masukkan Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(138, 398);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(146, 306);
            label5.Name = "label5";
            label5.Size = new Size(82, 37);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(395, 54);
            label1.Name = "label1";
            label1.Size = new Size(339, 54);
            label1.TabIndex = 11;
            label1.Text = "Daftar Akun Anda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(138, 180);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 12;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 867);
            Controls.Add(pnlLogin);
            Controls.Add(pnlLogo);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogo;
        private PictureBox pictureBox3;
        private Panel pnlLogin;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private TextBox txtEmail;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtUsername;
        private Label label5;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel5;
        private Panel panel7;
        private TextBox txtKonfirPassword;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Label toRegister;
        private Button btnDaftar;
    }
}