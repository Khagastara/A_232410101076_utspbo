using System;
using A_232410101076_utspbo.App.Context;
using A_232410101076_utspbo.App.Models;
using A_232410101076_utspbo.App.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_232410101076_utspbo
{
    public partial class HalamanRegister : Form
    {
        public HalamanRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Tidak Valid");
                return;
            }
            
            string username = textBox1.Text;
            string password = textBox2.Text;

            M_AkunAdmin akunAdmin = new M_AkunAdmin(username, password);
            AdminContext.TambahAdmin(akunAdmin);
            MessageBox.Show("Akun baru berhasil ditambahkan");

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
