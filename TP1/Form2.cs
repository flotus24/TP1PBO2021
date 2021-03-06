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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Membuat objek
            List<Barang> BarangList = new List<Barang>();
            BarangList.Add(new Barang("Esia Hidayah", 400000, "Elektronik"));
            BarangList.Add(new Barang("Sony Erickson", 550000, "Elektronik"));
            BarangList.Add(new Barang("Baju Zara", 150000, "Baju"));
            BarangList.Add(new Barang("Yupi 100pcs", 100000, "Makanan"));
            BarangList.Add(new Barang("Indomie 40pcs", 120000, "Makanan"));
            
            //Memasukan value objek
            lblBarang1.Text = Convert.ToString(BarangList[0].namaBarang);
            lblBarang2.Text = Convert.ToString(BarangList[1].namaBarang);
            lblBarang3.Text = Convert.ToString(BarangList[2].namaBarang);
            lblBarang4.Text = Convert.ToString(BarangList[3].namaBarang);
            lblBarang5.Text = Convert.ToString(BarangList[4].namaBarang);
            lblHarga1.Text = "Rp. " + Convert.ToString(BarangList[0].hargaBarang);
            lblHarga2.Text = "Rp. " + Convert.ToString(BarangList[1].hargaBarang);
            lblHarga3.Text = "Rp. " + Convert.ToString(BarangList[2].hargaBarang);
            lblHarga4.Text = "Rp. " + Convert.ToString(BarangList[3].hargaBarang);
            lblHarga5.Text = "Rp. " + Convert.ToString(BarangList[4].hargaBarang);

            //Menyembunyikan panel yang tidak perlu
  
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
        }

        private void pnlBarang2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlHome.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlHome.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
