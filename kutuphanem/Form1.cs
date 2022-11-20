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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kutuphanem.accdb");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz!!!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Kısmını Boş Bırakmayınız!!!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Şifre Kısmını Boş Bırakmayınız!!!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from kullanicigiris where kul_adi='"+textBox1.Text+"'",baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read()==true)
	            {
		            if(textBox1.Text==okuyucu["kul_adi"].ToString()&&textBox2.Text==okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldin "+okuyucu["adsoyad"].ToString());
                        Form frm1 = new anamenu();
                        frm1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol Ediniz!!!");
                    }
	            }
                else
                {
                    MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol Ediniz!!!");
                }
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
