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
    public partial class Admin_Read_Peminjam : Form
    {
        public Admin_Read_Peminjam()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDataBuku_Click(object sender, EventArgs e)
        {
            Admin_Data_Buku adb = new Admin_Data_Buku();
            this.Hide();
            adb.Show();
        }
    }
}
