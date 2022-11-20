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
    public partial class kitapbilgun : Form
    {
        public kitapbilgun()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kutuphanem.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitaplar set yazar='" + textBox2.Text + "',yayinevi='" + textBox3.Text + "',yazintur='" + comboBox1.Text + "',tur='" + comboBox2.Text + "',basim='" + textBox4.Text + "',okmyil='" + dateTimePicker2.Text + "',durum='" + textBox5.Text + "' where ad='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox1.Text + " adlı kitap başarıyla güncellendi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitaplar where ad='" + textBox1.Text + "' and yazar='" + textBox2.Text + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox3.Text = okuyucu["yayinevi"].ToString();
                comboBox1.Text = okuyucu["yazintur"].ToString();
                comboBox2.Text = okuyucu["tur"].ToString();
                textBox4.Text = okuyucu["basim"].ToString();
                dateTimePicker2.Text = okuyucu["okmyil"].ToString();
                textBox5.Text = okuyucu["durum"].ToString();
            } baglanti.Close();
        }
    }
}
