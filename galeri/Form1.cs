using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace galeri
{
    public partial class Form1 : Form
    {

        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veri.accdb");
        OleDbDataAdapter veri_adaptor;
        DataSet veri_seti;
        OleDbCommand veri_komutu;
        OleDbDataReader veri_Oku;



        public Form1()
        {
            InitializeComponent();
        }
        void Veri_listele()
        {
            veri_adaptor = new OleDbDataAdapter("Select * from arac", veritabani_baglanti);
            veri_seti = new DataSet();
            veritabani_baglanti.Open();
            veri_adaptor.Fill(veri_seti, "arac");
            dataGridView1.DataSource = veri_seti.Tables["arac"];
            veritabani_baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Veri_listele();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Veri_listele();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            veri_komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            veri_komutu.Connection = veritabani_baglanti;
            veri_komutu.CommandText = "Insert into arac (ilan_no,marka,model,yil,km,renk,fiyat,plaka) values ('"+ textBox1.Text + "','" +
                comboBox1.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + comboBox3.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";

            veri_komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            Veri_listele();

            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";







        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            veri_komutu = new OleDbCommand();
            veritabani_baglanti.Open();

            veri_komutu.Connection = veritabani_baglanti;

            veri_komutu.CommandText = "Update arac set ilan_no='" + textBox1.Text + "', marka='" + comboBox1.Text + "',model='" + textBox3.Text + "',yil='" + comboBox2.Text + "',km='" + textBox5.Text + "',renk='" + comboBox3.Text + "',plaka='" + textBox8.Text + "',fiyat='" + textBox7.Text + "'where ilan_no='" + textBox1.Text + "'";
    
            veri_komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            Veri_listele();

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void button4_Click_1(object sender, EventArgs e)
        {
            veri_komutu = new OleDbCommand();
            veritabani_baglanti.Open();

            veri_komutu.Connection = veritabani_baglanti;
            veri_komutu.CommandText = "Delete from arac  where ilan_no='" + textBox1.Text + "'";
            veri_komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            Veri_listele();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            veri_adaptor = new OleDbDataAdapter("Select * from arac where plaka  like '"+textBox2.Text+"%'", veritabani_baglanti);
            veri_seti = new DataSet();
            veritabani_baglanti.Open();
            veri_adaptor.Fill(veri_seti, "arac");
            dataGridView1.DataSource = veri_seti.Tables["arac"];
            veritabani_baglanti.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.SeaShell;
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            Button2.BackColor = Color.Red;

        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Button2.BackColor = Color.SeaShell;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
       
            button3.BackColor = Color.Red;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SeaShell;


        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;


        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.SeaShell;


        }
    }
    }


