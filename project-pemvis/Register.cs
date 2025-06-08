using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pemvis
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form Login
            Login loginForm = new Login();

            // Menampilkan Form Register
            loginForm.Show();

            // Opsional: Menyembunyikan Form saat ini jika tidak diperlukan lagi
            this.Hide();
        }
    }
}
