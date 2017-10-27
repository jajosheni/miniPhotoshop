using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPhotoshop
{
    public partial class Form2 : Form
    {
        int linkED = 0;

        public Form2()
        {
            InitializeComponent();
                
                int ind = Form1.undoZ;
                Bitmap dimensions = new Bitmap(Path.GetTempPath()+ "jscreen\\" + ind + ".jpeg");
                label5.Text = " " + dimensions.Width;
                label6.Text = " " + dimensions.Height;
            dimensions.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]"))
            {
                textBox1.Text = "";
            }
            textBox1.MaxLength = 4;
            if (textBox1.Focused == true)
            {
                if (linkED == 1 && textBox1.Text.Length != 0)
                {
                    float x = 0;
                    float y = 0;
                    float.TryParse(label5.Text, out x);
                    float.TryParse(label6.Text, out y);
                    float imgRatio = x / y;
                    textBox2.Text = ((int)(float.Parse(textBox1.Text) / imgRatio)).ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[0-9]"))
            {
                textBox2.Text = "";
            }

            textBox2.MaxLength = 4;
            if (textBox2.Focused == true)
            {
                if (linkED == 1 && textBox2.Text.Length != 0)
                {
                    float x = 0;
                    float y = 0;
                    float.TryParse(label5.Text, out x);
                    float.TryParse(label6.Text, out y);
                    float imgRatio = x / y;
                    textBox1.Text = ((int)(float.Parse(textBox2.Text) * imgRatio)).ToString();
                }
            }
        }
        



        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (linkED == 0)
                linkED = 1;
            else if (linkED == 1)
                linkED = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int newWidth = 0,
                newHeight = 0;

            try
            {
                newWidth = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered for the width is not valid");
            }

            try
            {
                newHeight = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered for the height is not valid");
            }

            

            Bitmap original = (Bitmap)Image.FromFile(Path.Combine(Path.GetTempPath(), "jscreen\\" + Form1.undoZ + ".jpeg"));
            Bitmap resized = new Bitmap(original, new Size(newWidth, newHeight));
            original.Dispose();

            Form1.undoZ++;
            resized.Save(Path.Combine(Path.GetTempPath(), "jscreen\\" + Form1.undoZ + ".jpeg"));

            this.Close();
        }
    }
}
