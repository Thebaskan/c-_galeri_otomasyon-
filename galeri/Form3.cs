using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galeri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text == "1234")
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            if (textBox1.Text != "admin" & textBox2.Text != "1234")
            {
                MessageBox.Show("Böyle bir hesap bulunamadı!");
            }
            if (textBox1.Text != "admin" & textBox2.Text == "1234")
            {
                MessageBox.Show("Hatalı kullanıcı");
            }
            if (textBox1.Text == "admin" & textBox2.Text != "1234")
            {
                MessageBox.Show("Hatalı parola");
            }
        }
    }
    }

