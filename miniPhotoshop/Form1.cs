using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPhotoshop
{
    public partial class Form1 : Form
    {
        public static int undoZ = 0;

        public Form1()
        {
            InitializeComponent();
            //Buttons Animation START!
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

            pictureBox2.MouseEnter += new EventHandler(pictureBox2_MouseEnter);
            pictureBox2.MouseLeave += new EventHandler(pictureBox2_MouseLeave);
            pictureBox2.MouseDown += new MouseEventHandler(pictureBox2_MouseDown);
            pictureBox2.MouseUp += new MouseEventHandler(pictureBox2_MouseUp);

            pictureBox3.MouseEnter += new EventHandler(pictureBox3_MouseEnter);
            pictureBox3.MouseLeave += new EventHandler(pictureBox3_MouseLeave);
            pictureBox3.MouseDown += new MouseEventHandler(pictureBox3_MouseDown);
            pictureBox3.MouseUp += new MouseEventHandler(pictureBox3_MouseUp);

            pictureBox4.MouseEnter += new EventHandler(pictureBox4_MouseEnter);
            pictureBox4.MouseLeave += new EventHandler(pictureBox4_MouseLeave);
            pictureBox4.MouseDown += new MouseEventHandler(pictureBox4_MouseDown);
            pictureBox4.MouseUp += new MouseEventHandler(pictureBox4_MouseUp);

            pictureBox5.MouseEnter += new EventHandler(pictureBox5_MouseEnter);
            pictureBox5.MouseLeave += new EventHandler(pictureBox5_MouseLeave);
            pictureBox5.MouseDown += new MouseEventHandler(pictureBox5_MouseDown);
            pictureBox5.MouseUp += new MouseEventHandler(pictureBox5_MouseUp);

            pictureBox6.MouseEnter += new EventHandler(pictureBox6_MouseEnter);
            pictureBox6.MouseLeave += new EventHandler(pictureBox6_MouseLeave);
            pictureBox6.MouseDown += new MouseEventHandler(pictureBox6_MouseDown);
            pictureBox6.MouseUp += new MouseEventHandler(pictureBox6_MouseUp);

            pictureBox7.MouseEnter += new EventHandler(pictureBox7_MouseEnter);
            pictureBox7.MouseLeave += new EventHandler(pictureBox7_MouseLeave);
            pictureBox7.MouseDown += new MouseEventHandler(pictureBox7_MouseDown);
            pictureBox7.MouseUp += new MouseEventHandler(pictureBox7_MouseUp);

            pictureBox8.MouseEnter += new EventHandler(pictureBox8_MouseEnter);
            pictureBox8.MouseLeave += new EventHandler(pictureBox8_MouseLeave);
            pictureBox8.MouseDown += new MouseEventHandler(pictureBox8_MouseDown);
            pictureBox8.MouseUp += new MouseEventHandler(pictureBox8_MouseUp);

            pictureBox9.MouseEnter += new EventHandler(pictureBox9_MouseEnter);
            pictureBox9.MouseLeave += new EventHandler(pictureBox9_MouseLeave);
            pictureBox9.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox9.MouseUp += new MouseEventHandler(pictureBox9_MouseUp);

            pictureBox10.MouseEnter += new EventHandler(pictureBox10_MouseEnter);
            pictureBox10.MouseLeave += new EventHandler(pictureBox10_MouseLeave);
            pictureBox10.MouseDown += new MouseEventHandler(pictureBox10_MouseDown);
            pictureBox10.MouseUp += new MouseEventHandler(pictureBox10_MouseUp);

            pictureBox13.MouseEnter += new EventHandler(pictureBox13_MouseEnter);
            pictureBox13.MouseLeave += new EventHandler(pictureBox13_MouseLeave);
            pictureBox13.MouseDown += new MouseEventHandler(pictureBox13_MouseDown);
            pictureBox13.MouseUp += new MouseEventHandler(pictureBox13_MouseUp);

            pictureBox14.MouseEnter += new EventHandler(pictureBox14_MouseEnter);
            pictureBox14.MouseLeave += new EventHandler(pictureBox14_MouseLeave);
            pictureBox14.MouseDown += new MouseEventHandler(pictureBox14_MouseDown);
            pictureBox14.MouseUp += new MouseEventHandler(pictureBox14_MouseUp);

            pictureBox15.MouseEnter += new EventHandler(pictureBox15_MouseEnter);
            pictureBox15.MouseLeave += new EventHandler(pictureBox15_MouseLeave);
            pictureBox15.MouseDown += new MouseEventHandler(pictureBox15_MouseDown);
            pictureBox15.MouseUp += new MouseEventHandler(pictureBox15_MouseUp);

            pictureBox18.MouseEnter += new EventHandler(pictureBox18_MouseEnter);
            pictureBox18.MouseLeave += new EventHandler(pictureBox18_MouseLeave);
            pictureBox18.MouseDown += new MouseEventHandler(pictureBox18_MouseDown);
            pictureBox18.MouseUp += new MouseEventHandler(pictureBox18_MouseUp);

            pictureBox19.MouseEnter += new EventHandler(pictureBox19_MouseEnter);
            pictureBox19.MouseLeave += new EventHandler(pictureBox19_MouseLeave);
            pictureBox19.MouseDown += new MouseEventHandler(pictureBox19_MouseDown);
            pictureBox19.MouseUp += new MouseEventHandler(pictureBox19_MouseUp);

            pictureBox20.MouseEnter += new EventHandler(pictureBox20_MouseEnter);
            pictureBox20.MouseLeave += new EventHandler(pictureBox20_MouseLeave);
            pictureBox20.MouseDown += new MouseEventHandler(pictureBox20_MouseDown);
            pictureBox20.MouseUp += new MouseEventHandler(pictureBox20_MouseUp);

            

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox13, "Open");

           
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox14, "Close");

            
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox15, "Save");
            
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox1, "Flip Horizontal");
            
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox2, "Flip Vertical");
            
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox3, "Rotate Left");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox4, "Rotate Right");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox5, "Resize");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox6, "Negative");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox7, "Grayscale");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox17, "Reload Image");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox21, "Levels");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox22, "RGB Histogram");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox18, "Red Channel");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox19, "Green Channel");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox20, "Blue Channel");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox8, "Minimize");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox9, "Maximize");

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox10, "Exit");

            //Button Animation FINISH


        }

        public void Save()
        {
            undoZ++;
            pictureBox12.Image.Save(Path.Combine(Path.GetTempPath(), "jscreen\\" + undoZ + ".jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void a_resize()
        {
            if (pictureBox12.Image.Width < pictureBox12.Width && pictureBox12.Image.Height < pictureBox12.Height)
                pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnKeyPress(KeyPressEventArgs ex)
        {

            string unDo = ex.KeyChar.ToString();

            if (unDo == "z" || unDo == "Z") //You pressed "z/Z" key on the keyboard
            {
                if (undoZ > 1)
                {
                    pictureBox12.Image.Dispose();
                    pictureBox12.Image = Image.FromFile(Path.Combine(Path.GetTempPath(), "jscreen\\" + (undoZ - 1) + ".jpeg"));
                    a_resize();
                    try
                    {
                        File.Delete(Path.Combine(Path.GetTempPath(), "jscreen\\" + undoZ + ".jpeg"));
                        undoZ--;
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Cannot UNDO");
                    }
                    
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < 32)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - 12 && pos.Y >= this.ClientSize.Height - 12)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }


        //Button Animation START!
        void pictureBox1_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_horizontal_hovered));
        }
        void pictureBox1_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_horizontal_pressed));
        }

        void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_horizontal_normal1));
        }


        void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_horizontal_hovered));
        }

        void pictureBox2_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_vertical_hovered));
        }
        void pictureBox2_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_vertical_pressed));
        }

        void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_vertical_normal1));
        }


        void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.flip_vertical_hovered));
        }

        void pictureBox3_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_left_hovered));
        }
        void pictureBox3_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_left_pressed));
        }

        void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_left_normal1));
        }


        void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_left_hovered));
        }

        void pictureBox4_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_right_hovered));
        }
        void pictureBox4_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_right_pressed));
        }

        void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_right_normal1));
        }


        void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rotate_right_hovered));
        }

        void pictureBox5_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.resize_hovered));
        }
        void pictureBox5_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.resize_pressed));
        }

        void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.resize_normal1));
        }


        void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.resize_hovered));
        }

        void pictureBox6_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.invert_hovered));
        }
        void pictureBox6_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.invert_pressed));
        }

        void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.invert_normal));
        }


        void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.invert_hovered));
        }

        void pictureBox7_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.bw_hovered));
        }
        void pictureBox7_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.bw_pressed));
        }

        void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.bw_normal2));
        }


        void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.bw_hovered));
        }

        void pictureBox8_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_hover));
        }
        void pictureBox8_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_pressed));
        }

        void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_normal));
        }


        void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_hover));
        }

        void pictureBox9_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_hover));
        }
        void pictureBox9_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_pressed));
        }

        void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_normal));
        }


        void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_hover));
        }

        void pictureBox10_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_hover));
        }
        void pictureBox10_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_pressed));
        }

        void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_normal));
        }


        void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_hover));
        }

        void pictureBox13_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open_hovered));
        }
        void pictureBox13_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open_pressed));
        }

        void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open_normal));
        }


        void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.open_hovered));
        }

        void pictureBox14_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closefile_hovered));
        }
        void pictureBox14_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closefile_pressed));
        }

        void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closefile_normal));
        }


        void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closefile_hovered));
        }

        void pictureBox15_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.save_hovered));
        }
        void pictureBox15_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.save_pressed));
        }

        void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.save_normal));
        }


        void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.save_hovered));
        }

        void pictureBox18_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red_channel_hovered));
        }
        void pictureBox18_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red_channel_pressed));
        }

        void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red_channel1));
        }


        void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.red_channel_hovered1));
        }

        void pictureBox19_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.green_channel_hovered1));
        }
        void pictureBox19_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.green_channel_pressed1));
        }

        void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.green_channel1));
        }


        void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.green_channel_hovered1));
        }

        void pictureBox20_MouseUp(object sender, EventArgs e)
        {
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_channel_hovered1));
        }
        void pictureBox20_MouseDown(object sender, EventArgs e)
        {
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_channel_pressed1));
        }

        void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_channel1));
        }


        void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_channel_hovered1));
        }

        //Button Animation FINISH

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Bitmap first = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = first.Width;
                int height = first.Height;
                Bitmap second = new Bitmap(width, height * 2);
                for (int y = 0; y < width; y++)
                {
                    for (int ux = 0, dx = height * 2 - 1; ux < height; ux++, dx--)
                    {
                        //get source pixel value
                        Color p = first.GetPixel(y, ux);

                        //set mirror pixel value
                        second.SetPixel(y, ux, p);
                        second.SetPixel(y, dx, p);
                    }
                }
                first.Dispose();
                pictureBox12.Image = second;
                a_resize();
                //Rhisto();
                Save();
            }

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int flag = 0;
        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (flag == 1)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (flag == 1)
            {
                flag = 0;
            }
            else flag = 1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Bitmap first = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = first.Width;
                int height = first.Height;
                Bitmap second = new Bitmap(width * 2, height);
                for (int y = 0; y < height; y++)
                {
                    for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                    {
                        //get source pixel value
                        Color p = first.GetPixel(lx, y);

                        //set mirror pixel value
                        second.SetPixel(lx, y, p);
                        second.SetPixel(rx, y, p);
                    }
                }
                first.Dispose();
                pictureBox12.Image = second;
                a_resize();
                //Rhisto();
                Save();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Grayhisto();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Bitmap grayscale = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = grayscale.Width;
                int height = grayscale.Height;
                Color p;

                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        p = grayscale.GetPixel(i, j);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int gr = (r + g + b) / 3;

                        grayscale.SetPixel(i, j, Color.FromArgb(a, gr, gr, gr));
                    }
                }
                pictureBox12.Image = grayscale;
                a_resize();
                //Rhisto();
                Save();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Bitmap negate = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);


                int width = negate.Width;
                int height = negate.Height;

                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {

                        Color p = negate.GetPixel(i, j);


                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;


                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        negate.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox12.Image = negate;
                a_resize();
                //Rhisto();
                Save();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();

                pictureBox12.Image =  new Bitmap(Path.Combine(Path.GetTempPath(), "jscreen\\" + undoZ + ".jpeg"));
                a_resize();
            }

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {

                Image RotatedImage = null;

                float angle;
                if (!float.TryParse("90", out angle)) return;

                System.Drawing.Image img = pictureBox12.Image;

                // Find the size of the image's rotated bounding box.
                Matrix rotation = new Matrix();
                rotation.Rotate(angle);
                int oldWidth = img.Width;
                int oldHeight = img.Height;
                PointF[] coordinates =
                {
                    new PointF(0, 0),
                    new PointF(oldWidth, 0),
                    new PointF(0, oldHeight),
                    new PointF(oldWidth, oldHeight),
                };

                rotation.TransformPoints(coordinates);
                float[] xs = { coordinates[0].X, coordinates[1].X, coordinates[2].X, coordinates[3].X };
                float[] ys = { coordinates[0].Y, coordinates[1].Y, coordinates[2].Y, coordinates[3].Y };
                int newWidth = (int)(xs.Max() - xs.Min());
                int newHeight = (int)(ys.Max() - ys.Min());



                // Make the rotated image.
                RotatedImage = new Bitmap(newWidth, newHeight);
                using (Graphics gr = Graphics.FromImage(RotatedImage))
                {
                    gr.TranslateTransform(-oldWidth / 2, -oldHeight / 2, MatrixOrder.Append);
                    gr.RotateTransform(angle, MatrixOrder.Append);
                    gr.TranslateTransform(newWidth / 2, newHeight / 2, MatrixOrder.Append);
                    RectangleF SourceRect = new RectangleF(0, 0, img.Width, img.Height);
                    PointF[] destCoordinates =
                    {
                        new PointF(0, 0),
                        new PointF(img.Width, 0),
                        new PointF(0, img.Height),
                    };
                    gr.DrawImage(pictureBox12.Image, destCoordinates, SourceRect, GraphicsUnit.Pixel);
                }

                pictureBox12.Image = RotatedImage;
                a_resize();
                img.Dispose();
                Save();


                //OTHER TYPE OF ROTATE, SLOW!
                /*if (pictureBox12.Image != null)
                {
                    Bitmap first = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                    int width = first.Height;
                    int height = first.Width;
                    Bitmap second = new Bitmap(width, height);

                    for (int i = 0; i < first.Height; i++)
                    {
                        for (int j = 0; j < first.Width; j++)
                        {
                            second.SetPixel(i, j, first.GetPixel(j, i));
                        }
                    }
                    first.Dispose();
                    Bitmap third = new Bitmap(width, height);
                    for (int y = 0; y < height; y++)
                    {
                        for (int lx = 0, rx = width - 1; lx < width; lx++, rx--)
                        {
                            //get source pixel value
                            Color p = second.GetPixel(lx, y);

                            third.SetPixel(rx, y, p);
                        }
                    }
                    second.Dispose();

                    pictureBox12.Image = third;
                    pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
                     
                    Save();
                }*/
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {

                Image RotatedImage = null;
                
                float angle;
                if (!float.TryParse("-90", out angle)) return;

                System.Drawing.Image img = pictureBox12.Image;
                
                // Find the size of the image's rotated bounding box.
                Matrix rotation = new Matrix();
                rotation.Rotate(angle);
                int oldWidth = img.Width;
                int oldHeight = img.Height;
                PointF[] coordinates =
                {
                    new PointF(0, 0),
                    new PointF(oldWidth, 0),
                    new PointF(0, oldHeight),
                    new PointF(oldWidth, oldHeight),
                };

                rotation.TransformPoints(coordinates);
                float[] xs = { coordinates[0].X, coordinates[1].X, coordinates[2].X, coordinates[3].X };
                float[] ys = { coordinates[0].Y, coordinates[1].Y, coordinates[2].Y, coordinates[3].Y };
                int newWidth = (int)(xs.Max() - xs.Min());
                int newHeight = (int)(ys.Max() - ys.Min());

                

                // Make the rotated image.
                RotatedImage = new Bitmap(newWidth, newHeight);
                using (Graphics gr = Graphics.FromImage(RotatedImage))
                {
                    gr.TranslateTransform(-oldWidth / 2, -oldHeight / 2, MatrixOrder.Append);
                    gr.RotateTransform(angle, MatrixOrder.Append);
                    gr.TranslateTransform(newWidth / 2, newHeight / 2, MatrixOrder.Append);
                    RectangleF SourceRect = new RectangleF(0, 0, img.Width, img.Height);
                    PointF[] destCoordinates =
                    {
                        new PointF(0, 0),
                        new PointF(img.Width, 0),
                        new PointF(0, img.Height),
                    };
                    gr.DrawImage(pictureBox12.Image, destCoordinates, SourceRect, GraphicsUnit.Pixel);
                }

                pictureBox12.Image = RotatedImage;
                a_resize();
                img.Dispose();
                Save();



                /*if (pictureBox12.Image != null)
                {
                    Bitmap first = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                    int width = first.Height;
                    int height = first.Width;
                    Bitmap second = new Bitmap(width, height);

                    for (int i = 0; i < first.Height; i++)
                    {
                        for (int j = 0; j < first.Width; j++)
                        {
                            second.SetPixel(i, j, first.GetPixel(first.Width-1-j, first.Height-1-i));
                        }
                    }
                    first.Dispose();
                    Bitmap third = new Bitmap(width, height);
                    for (int y = 0; y < height; y++)
                    {
                        for (int lx = 0, rx = width - 1; lx < width; lx++, rx--)
                        {
                            //get source pixel value
                            Color p = second.GetPixel(lx, y);

                            third.SetPixel(rx, y, p);
                        }
                    }
                    second.Dispose();

                    pictureBox12.Image = third;
                    pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
                    //Rhisto();
                    Save();
                }*/
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }



        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                pictureBox12.Image.Dispose();
                pictureBox12.Image = null;
                string folderName = System.IO.Path.GetTempPath();
                string pathString = System.IO.Path.Combine(folderName, "jscreen");
                System.IO.Directory.CreateDirectory(pathString);



                string[] fileNames = Directory.GetFiles(pathString);
                foreach (string fileName in fileNames)
                    File.Delete(fileName);
            }
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files|*.bmp;*.jpg;*.gif;*.jpeg;*.png;";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox12.Image = new Bitmap((String)dlg.FileName); //

                    a_resize();

                    string folderName = System.IO.Path.GetTempPath();
                    string pathString = System.IO.Path.Combine(folderName, "jscreen");
                    System.IO.Directory.CreateDirectory(pathString);

                    

                    string[] fileNames = Directory.GetFiles(pathString);
                    foreach (string fileName in fileNames)
                        File.Delete(fileName);

                    pictureBox12.Image.Save(Path.Combine(Path.GetTempPath(), "jscreen\\original.bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
                    pictureBox16.Image = pictureBox12.Image;
                    undoZ = 0;
                    Save();
                    Grayhisto();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                pictureBox12.Image.Dispose();
                pictureBox12.Image = null;
            }
            pictureBox16.Image = pictureBox12.Image;
            undoZ = 0;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Title = "Save Image";
                    dlg.Filter = "Bitmap|*.bmp;| JPEG |*.jpeg;| PNG |*.png;";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        string savefile = Path.Combine(dlg.FileName, "");
                        if (System.IO.File.Exists(dlg.FileName))
                            System.IO.File.Delete(dlg.FileName);

                        if (dlg.FileName.Contains(".jpg") || dlg.FileName.Contains(".jpeg"))
                            pictureBox12.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        else if (dlg.FileName.Contains(".png"))
                            pictureBox12.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        else if (dlg.FileName.Contains(".bmp"))
                            pictureBox12.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        else pictureBox12.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                pictureBox12.Image.Dispose();
                pictureBox12.Image = null;
                pictureBox12.Image = new Bitmap(Path.Combine(Path.GetTempPath(), "jscreen\\original.bmp"));

                string folderName = System.IO.Path.GetTempPath();
                string pathString = System.IO.Path.Combine(folderName, "jscreen");
                System.IO.Directory.CreateDirectory(pathString);

                string[] fileNames = Directory.GetFiles(pathString);
                foreach (string fileName in fileNames)
                    if (!fileName.Contains("original"))
                        File.Delete(fileName);

                undoZ = 0;
                Save();
                MessageBox.Show("Image Reloaded");
                a_resize();
            }
            
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                pictureBox12.Image.Dispose();
                pictureBox12.Image = null;
                pictureBox12.Image = new Bitmap(Path.Combine(Path.GetTempPath(), "jscreen\\original.bmp"));

                string folderName = System.IO.Path.GetTempPath();
                string pathString = System.IO.Path.Combine(folderName, "jscreen");
                System.IO.Directory.CreateDirectory(pathString);

                string[] fileNames = Directory.GetFiles(pathString);
                foreach (string fileName in fileNames)
                    if (!fileName.Contains("original"))
                        File.Delete(fileName);

                undoZ = 0;
                Save();
                MessageBox.Show("Image Reloaded");
                a_resize();
            }
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {

                Bitmap bmp = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = bmp.Width;
                int height = bmp.Height;

                //3 bitmap for red green blue image
                Bitmap rbmp = new Bitmap(bmp);


                //red  image
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);


                        int a = p.A;
                        int r = p.R;


                        //set red image pixel
                        rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));


                    }
                }

                //load red image in picturebox
                pictureBox12.Image = rbmp;
                //Rhisto();
                Save();
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {

                Bitmap bmp = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = bmp.Width;
                int height = bmp.Height;

                Bitmap gbmp = new Bitmap(bmp);


                //red green blue image
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB value from p
                        int a = p.A;

                        int g = p.G;

                        //set green image pixel
                        gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    }

                }


                //load green image in picturebox3
                pictureBox12.Image = gbmp;
                // Rhisto();
                Save();
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {

                Bitmap bmp = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = bmp.Width;
                int height = bmp.Height;
                //3 bitmap for  blue image

                Bitmap bbmp = new Bitmap(bmp);

                // blue image
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB value from p
                        int a = p.A;

                        int b = p.B;

                        //set blue image pixel
                        bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }
                }

                //load blue image in picturebox3
                pictureBox12.Image = bbmp;
                // Rhisto();
                Save();
            }
        }

        public void Rhisto()
        {

            Bitmap bmp = new Bitmap(pictureBox12.Image);
            int[] histogram_r = new int[256];
            int[] histogram_b = new int[256];
            int[] histogram_g = new int[256];
            float max = 0;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int bValue = bmp.GetPixel(i, j).B;
                    if (bValue == 0)
                        continue;
                    histogram_b[bValue]++;
                    if (max < histogram_b[bValue])
                        max = histogram_b[bValue];
                }
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int redValue = bmp.GetPixel(i, j).R;
                    if (redValue == 0)
                        continue;
                    histogram_r[redValue]++;
                    if (max < histogram_r[redValue])
                        max = histogram_r[redValue];
                }
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int greenValue = bmp.GetPixel(i, j).G;
                    if (greenValue == 0)
                        continue;
                    histogram_g[greenValue]++;
                    if (max < histogram_g[greenValue])
                        max = histogram_g[greenValue];
                }
            }



            int histHeight = 256;
            Bitmap img = new Bitmap(256, histHeight + 10);
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < histogram_r.Length; i++)
                {
                    float pct = histogram_r[i] / max;   // What percentage of the max is this value?
                    float pct1 = histogram_b[i] / max;   // What percentage of the max is this value?
                    float pct2 = histogram_g[i] / max;   // What percentage of the max is this value?

                    if (pct1 >= pct && pct1 >= pct2)
                    {
                        g.DrawLine(Pens.Blue,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct1 * histHeight))  // Use that percentage of the height
                        );
                        if (pct >= pct2)
                        {
                            g.DrawLine(Pens.Red,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                        }
                        else if (pct2 >= pct)
                        {
                            g.DrawLine(Pens.Green,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct2 * histHeight))  // Use that percentage of the height
                        );
                            g.DrawLine(Pens.Red,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                        }
                    }

                    if (pct >= pct1 && pct >= pct2)
                    {
                        g.DrawLine(Pens.Red,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                        if (pct1 >= pct2)
                        {
                            g.DrawLine(Pens.Blue,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct1 * histHeight))  // Use that percentage of the height
                            );
                        }
                        else if (pct2 >= pct1)
                        {
                            g.DrawLine(Pens.Green,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct2 * histHeight))  // Use that percentage of the height
                        );
                            g.DrawLine(Pens.Blue,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct1 * histHeight))  // Use that percentage of the height
                            );
                        }

                    }

                    if (pct2 >= pct && pct2 >= pct1)
                    {
                        g.DrawLine(Pens.Green,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct2 * histHeight))  // Use that percentage of the height
                        );
                        if (pct >= pct1)
                        {
                            g.DrawLine(Pens.Red,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                        }
                        else if (pct1 >= pct)
                        {
                            g.DrawLine(Pens.Blue,
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct1 * histHeight))  // Use that percentage of the height
                        );
                            g.DrawLine(Pens.Red,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                        }
                    }


                }
            }
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.Image = img;





        }



        private void Grayhisto()
        {

            if (pictureBox12.Image != null)
            {
                Bitmap grayscale = new Bitmap(pictureBox12.Image, pictureBox12.Image.Width, pictureBox12.Image.Height);
                int width = grayscale.Width;
                int height = grayscale.Height;
                Color p;
                float max = 0;
                int[] histogram_r = new int[256];
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        p = grayscale.GetPixel(i, j);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int gr = (r + g + b) / 3;

                        histogram_r[gr]++;
                        if (max < histogram_r[gr])
                            max = histogram_r[gr];
                    }
                }


                int histHeight = 256;
                Bitmap img = new Bitmap(256, histHeight + 10);
                using (Graphics g = Graphics.FromImage(img))
                {
                    for (int i = 0; i < histogram_r.Length; i++)
                    {
                        float pct = histogram_r[i] / max;   // What percentage of the max is this value?
                        g.DrawLine(Pens.WhiteSmoke,
                            new Point(i, img.Height - 5),
                            new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                    }
                }
                pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox21.Image = img;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != null)
            {
                Rhisto();
            }
        }
    }
}
