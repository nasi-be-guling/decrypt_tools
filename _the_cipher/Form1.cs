using System;
using System.Windows.Forms;
using _encryption;


namespace _the_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
                MessageBox.Show(@"MASUKKAN PASSWORD!");
            else
                textBox1.Text = CStringCipher.Encrypt(textBox2.Text, textBox3.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
                MessageBox.Show(@"MASUKKAN PASSWORD!");
            else
            {
                try
                {
                    textBox1.Text = CStringCipher.Decrypt(textBox2.Text, textBox3.Text.Trim());
                }
                catch
                {
                    MessageBox.Show(@"PASSWORD ANDA SALAH ATAU DATA TIDAK DITEMUKAN!");
                }
            }
        }
    }
}
