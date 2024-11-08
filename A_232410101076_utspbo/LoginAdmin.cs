using A_232410101076_utspbo.App.Context;
using A_232410101076_utspbo.App.Models;
using A_232410101076_utspbo.App.Core;
using System;
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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminContext adminContext = new AdminContext();
            M_AkunAdmin akunAdmin = adminContext.All();

            if (akunAdmin != null)
            {
                MessageBox.Show("Login Berhasil", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void ClearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
