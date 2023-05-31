using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatozllik, ikinciatozellik, ucuncuatozellik;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 Numaralı at yarışı önde götürüyor";
            }
            if(pictureBox2.Left> pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 Numaralı at atak yaptı";   
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 Numaralı at yarışı öne geçti";
            }
            if (birinciatingenisligi + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = "1 numaralı at kazandı";
                
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = "2 numaralı at kazandı ";
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = "3 Numaralı at kazandı";
            }
        }

        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatozllik = pictureBox1.Left;
            ikinciatozellik = pictureBox2.Left;
            ucuncuatozellik = pictureBox3.Left;

        }
    }
}
