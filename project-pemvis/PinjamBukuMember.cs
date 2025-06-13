using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_pemvis
{
    public partial class PinjamBukuMember : Form
    {
        private int userId;
        public PinjamBukuMember(int userIdFromLogin)
        {
            InitializeComponent();
            this.userId = userIdFromLogin;
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil(userId); // Pastikan "Profil" adalah nama form yang benar
            profilForm.Show();
            this.Hide(); // Menyembunyikan form saat ini
        }

        private void PinjamBukuMember_Load(object sender, EventArgs e)
        {

        }
    }
}
