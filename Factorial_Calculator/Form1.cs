using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox textbox1 = new TextBox();
        Label label1 = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Buton1 özellikleri girildi ve oluşturuldu.
            Button buton = new Button();
            buton.Height = 50;
            buton.Width = 100;
            buton.Location = new Point(25, 60);
            buton.Text = ("Yeni Pencerede Göster");
            this.Controls.Add(buton);
            buton.Click += new EventHandler(buton_click);

            // Buton2 özellikleri girildi ve oluşturuldu.
            Button buton2 = new Button();
            buton2.Height = 50;
            buton2.Width = 100;
            buton2.Location = new Point(125, 60);
            buton2.Text = ("Faktoriyel Hesapla");
            this.Controls.Add(buton2);
            buton2.Click += new EventHandler(buton2_click);

            // Textbox özellikleri girildi ve oluşturuldu.
            textbox1.Height = 30;
            textbox1.Width = 100;
            textbox1.Location = new Point(25, 20);
            this.Controls.Add(textbox1);
            textbox1.KeyPress += textbox1_KeyPress;

            // Label özellikleri girildi ve oluşturuldu.
            label1.Location = new Point(125, 24);
            label1.AutoSize = true;
            label1.Text = "=";
            label1.ForeColor = Color.Black;
            this.Controls.Add(label1);
        }
        private void buton_click(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {
                MessageBox.Show("Deger Giriniz.");

            }
            else
            {
                MessageBox.Show(textbox1.Text);
            }
        }
        private void buton2_click(object sender, EventArgs e)
       {
            int sonuc = 1;
            if (textbox1.Text == "")
            {
                MessageBox.Show("Deger Giriniz.");

            }
            else
            {
                int faktoriyel;
                faktoriyel = Convert.ToInt32(textbox1.Text);
                for (int i = 1; i <= faktoriyel; i++)
                {
                    sonuc = sonuc * i;
                }
                label1.Text = Convert.ToString("Sonuc= " + sonuc);
            }
        }
        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Sadece sayı girişi ayarlandı.
        }
    }
}
