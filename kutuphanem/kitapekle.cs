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

namespace kutuphanem
{
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kutuphanem.accdb");
        void yazinturudoldur()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select yazinturu from yazinturu", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Yeni Tür Ekle");
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["yazinturu"].ToString());
            }
            baglanti.Close();
        }
        void kitapturudoldur()
        {
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select kitapturu from kitapturu", baglanti);
            OleDbDataReader okuyucu2 = komut2.ExecuteReader();
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Yeni Tür Ekle");
            while (okuyucu2.Read())
            { 
                comboBox2.Items.Add(okuyucu2["kitapturu"].ToString());
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("insert into kitaplar(ad,yazar,yayinevi,yazintur,tur,basim,okmyil,durum) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "')", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox1.Text + " adlı kitap başarıyla kaydedildi");
        }

        private void kitapekle_Load(object sender, EventArgs e)
        {
            yazinturudoldur();

            kitapturudoldur();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yeni Tür Ekle")
            {
                this.Hide();
                Form yazin_turu = new yazin_turu();
                yazin_turu.Show();
                yazinturudoldur();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form kitap_turu = new kitap_turu();
            kitap_turu.Show();
            kitapturudoldur();
        }
    }
}
