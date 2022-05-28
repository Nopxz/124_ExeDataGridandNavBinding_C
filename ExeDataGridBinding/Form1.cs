using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat Code Login dan Pindah Ke halaman Dashboard atau Halaman Selanjutnya 
            // Code Perulangan Username dan Password dan pembuatan message Box

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox1.Text.Equals("Naufal") && textBox2.Text.Equals("1234"))

            {
                Form2 naufall = new Form2();
                naufall.Show();
            }

            else
            {
                MessageBox.Show("Username atau password salah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 naufal = new Form1();
            naufal.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
