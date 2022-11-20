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
    public partial class kulsil : Form
    {
        public kulsil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kutuphanem.accdb");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanicigiris where kul_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox3.Text = okuyucu["adsoyad"].ToString();
                textBox4.Text = okuyucu["unvan"].ToString();
            } baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanicigiris where kul_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox3.Text = okuyucu["adsoyad"].ToString();
                textBox4.Text = okuyucu["unvan"].ToString();
            } baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("delete from kullanicigiris where kul_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox3.Text + " adlı kullanıcı başarıyla silindi");
        }
    }
}
