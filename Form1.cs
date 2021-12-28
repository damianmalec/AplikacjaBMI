using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = imageList1.Images[5];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            txtWzrost.Text = "";
            txtWaga.Text = "";
            txtWynik.Text = "";
            kolorWyniku.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = imageList1.Images[5];

            radKg.Checked = false;
            radLb.Checked = false;

        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWaga_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
                double weight = Convert.ToDouble(txtWaga.Text);
                double height = Convert.ToDouble(txtWzrost.Text);
                double result = 0.0;
                string result2 = "";
                height = height / 100;

                if (radKg.Checked)
                {
                    result = weight / (height * height);
                }
                else
                if (radLb.Checked)
                {
                    weight = weight / 2.205;
                    result = weight / (height * height);
                }

            if (result < 18.5)
            {
                result2 = "Niestety, ale masz niedowagę! Jedz więcej i zdrowo.";
                kolorWyniku.BackColor = Color.Teal;
                pictureBox1.BackgroundImage = imageList1.Images[0];
            }
            else
            if (result < 25)
            {
                result2 = "Twoja waga jest w normie - tak trzymaj!";
                kolorWyniku.BackColor = Color.Green;
                pictureBox1.BackgroundImage = imageList1.Images[1];
            }
            else
            if (result < 30)
            {
                result2 = "Niestety, ale masz nadwagę! - zadbaj o dietę!";
                kolorWyniku.BackColor = Color.Red;
                pictureBox1.BackgroundImage = imageList1.Images[2];
            }
            else
            if (result < 35)
            {
                result2 = "Kwalifikujesz się jako osoba otyła! - zadbaj o dietę jak najszybciej!";
                kolorWyniku.BackColor = Color.DarkGray;
                pictureBox1.BackgroundImage = imageList1.Images[3];
            }
            else
            if (result >= 35.1)
            {
                result2 = "Kwalifikujesz się jako osoba BARZDO OTYŁA! - zadbaj o DOBRĄ dietę jak najszybciej!";
                kolorWyniku.BackColor = Color.Red;
                pictureBox1.BackgroundImage = imageList1.Images[4];
            }


            txtWynik.Text = "Twoje BMI to " + result.ToString("#.#") + "\r\n" + result2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtWzrost_TextChanged(object sender, EventArgs e)
        {

        }

        private void kolorWyniku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
