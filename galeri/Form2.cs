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
    public partial class Form2 : Form
    {
        public Form3 Form3;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        

        }
        int bar = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            bar++;
            progressBar2.Value = bar;
            if(bar==100)
            {
                timer1.Enabled = false;
                bar = 0;
                Form3 = new Form3();
                Form3.Show();
                this.Hide();

            }
        }
    }
}
