using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        float Xmax;
        float Xmin;
        float Ymax;
        float Ymin;
        float Xtotal;
        float Ytotal;
        Bitmap image = new Bitmap(1, 1);


        public Form1()
        {

            InitializeComponent();
            Xmax = float.Parse(txt_Xmax.Text);
            Xmax = float.Parse(txt_Xmin.Text);
            Ymax = float.Parse(txt_Ymax.Text);
            Xmin = float.Parse(txt_Ymin.Text);
            Xtotal = Xmax - Xmin;
            Xtotal = Ymax - Ymin;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_x.Text = "";
            lbl_y.Text = "";
        }

        private void btn_move_up_Click(object sender, EventArgs e)
        {
            Ymax = Ymax + Ymax *0.5f;
            Ymin = Ymin + Ymin * 0.5f;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }



        private void btn_move_left_Click(object sender, EventArgs e)
        {
            Xmax = Xmax + Xtotal * 0.1f;
            Xmin = Xmin + Xtotal * 0.1f;
            Xtotal = Xmax - Xmin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }

        private void btn_move_down_Click(object sender, EventArgs e)
        {
            Ymax = Ymax - Ymax * 0.5f;
            Ymin = Ymin - Ymin * 0.5f;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }

        private void btn_move_right_Click(object sender, EventArgs e)
        {
            Xmax = Xmax - Xtotal * 0.1f;
            Xmin = Xmin - Xtotal * 0.1f;
            Xtotal = Xmax - Xmin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }

        private void btn_Render_Click(object sender, EventArgs e)
        {
            render();
        }

        private void pictureBox1_MouseCaptureChanged(object sender, MouseEventArgs e)
        {

            lbl_x.Text = Convert.ToString(((Xtotal * e.X) / pictureBox1.Width) + Xmin);
            lbl_y.Text = Convert.ToString(((Ytotal * e.Y) / pictureBox1.Height) + Ymin);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_savecoords_Click(object sender, EventArgs e)
        {

            Xmax = float.Parse(txt_Xmax.Text);
            Xmin = float.Parse(txt_Xmin.Text);
            Ymax = float.Parse(txt_Ymax.Text);
            Ymin = float.Parse(txt_Ymin.Text);
            Xtotal = Xmax - Xmin;
            Ytotal = Ymax - Ymin;
        }

        private void render()
        {
            float cReal, cImaginary;
            for (int i = 0; i <= image.Width - 1; i++)
            {


                for (int j = 0; j <= image.Height - 1; j++)
                {
                    cReal = ((Xtotal * i) / pictureBox1.Width) + Xmin;
                    cImaginary = ((Ytotal * j) / pictureBox1.Height + Ymin);

                    float zReal = 0;
                    float zImaginary = 0;

                    int iteration = 0;
                    int maxiteration = 100;

                    while (maxiteration > iteration && (zReal * zReal + zImaginary * zImaginary) <= 4)
                    {
                        float temp = zReal * zReal - zImaginary * zImaginary + cReal;
                        zImaginary = 2 * zReal * zImaginary + cImaginary;
                        zReal = temp;
                        iteration++;
                    }
                    if (iteration >= maxiteration - 1)
                    {
                        image.SetPixel(i, j, Color.Black);
                    }
                    else if (iteration >= 50 && iteration < 60)
                    {
                        image.SetPixel(i, j, Color.Blue);
                    }
                    else if (iteration >= 40 && iteration < 50)
                    {
                        image.SetPixel(i, j, Color.Green);
                    }
                    else if (iteration >= 30 && iteration < 40)
                    {
                        image.SetPixel(i, j, Color.Yellow);
                    }
                    else if (iteration >= 20 && iteration < 30)
                    {
                        image.SetPixel(i, j, Color.Orange);
                    }
                    else if (iteration >= 10 && iteration < 20)
                    {
                        image.SetPixel(i, j, Color.Red);
                    }
                    else
                    {
                        image.SetPixel(i, j, Color.White);
                    }

                }

            }
            pictureBox1.Image = image;
        }

        private void updatetxt(float Xmin, float Xmax, float Ymin, float Ymax)
        {
            txt_Xmax.Text = Convert.ToString(Xmax);
            txt_Xmin.Text = Convert.ToString(Xmin);
            txt_Ymax.Text = Convert.ToString(Ymax);
            txt_Ymin.Text = Convert.ToString(Ymin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //screenratio as param to keep it "the same"
            float param = image.Width / image.Height;
            Xmin = Xmin + 0.1f;
            Xmax = Xmax - 0.1f;
            Ymin = Ymin + 0.1f * param;
            Ymax = Ymax - 0.1f * param;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }

        private void btn_Zoomout_Click(object sender, EventArgs e)
        {
            //screenratio as param to keep it "the same"

            Xmin = Xmin *0.9f;
            Xmax = Xmax *0.9f;
            Ymin = Ymin * 0.9f;
            Ymax = Ymax *0.9f;
            Xtotal = Xmax - Xmin;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);
            render();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //when clicked take mouse 
           
            //current mouse coords
            float y = ((Xtotal * MousePosition.X) / Form1.ActiveForm.Width) + Xmin;
            float x = ((Ytotal * MousePosition.Y) / Form1.ActiveForm.Height) + Ymin;
            // cords as middle point and go make xMIN XMan ymax ymin xtotal ytotal from taht 
            Xmin = Xmin + (x - Xmin) - Xtotal/2;
            Xmax = Xmax + (x - Xmax) + Xtotal/2;
            Xtotal = Xmax - Xmin;

            Ymin = Ymin + (y - Ymin) - Ytotal/2;
            Ymax = Ymax + (y - Ymax) + Ytotal / 2;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax);

            render();
     

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    } 

}
