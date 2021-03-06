using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.nama = Convert.ToString(tb_username.Text);
            user.password = Convert.ToString(tb_password.Text);

            if(user.nama != "")
            {
                if(user.password == "pbo123")
                {
                    //Melihat form 2 dan menyembunyikan form 1
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    MessageBox.Show("Password salah!", "Warning box");
                }
            }
            else
            {
                MessageBox.Show("Username Kosong!", "Warning box");
            }

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
