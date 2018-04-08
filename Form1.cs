using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Emlak_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }


        public void login(string id, string pw)
        {
            if (id == "orhun" & pw == "123456")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("Hatalı veya eskik giriş yaptınız.", "Uyarı Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(textBox1, "Yönetici kullanıcı adınızı giriniz.");
            Aciklama.SetToolTip(textBox2, "Yönetici şifrenizi giriniz.");
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(textBox1.Text, textBox2.Text);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Caps Lock Açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox2.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
                login(textBox1.Text, textBox2.Text);
                {
                    SoundPlayer player = new SoundPlayer();
                    string path = "histicks.wav"; // Çalmasını istediğiniz ses dosyasının yolu
                    player.SoundLocation = path;
                    player.Play();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
