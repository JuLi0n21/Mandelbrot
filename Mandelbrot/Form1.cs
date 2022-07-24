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
        float Xmax;     //X maximum
        float Xmin;     //X minimum

        float Ymax;     //Y maximum
        float Ymin;     //Y minimum
        
        float Xtotal;   //Lenght of X
        float Ytotal;   //Length of Y
        
        Bitmap image = new Bitmap(1, 1);    //creates Bitmpa to draw on
        
        //mouse coords in relation to picutrebox
        float lastMouseclickx;
        float lastMouseclicky;
        float Zoomfactor = 2;
        
        
       
       
        public Form1()
        {

            InitializeComponent();
            Xmax = float.Parse(txt_Xmax.Text);
            Xmax = float.Parse(txt_Xmin.Text);
            Ymax = float.Parse(txt_Ymax.Text);
            Xmin = float.Parse(txt_Ymin.Text);
            Xtotal = Xmax - Xmin;
            Xtotal = Ymax - Ymin;
            //creates bitmap with picturebox sizes 
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);  
            //renders standart mandelbrot
            reset();


        }

        private void Form1_Load(object sender, EventArgs e)
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
            render();
        }

        private void render()
        {
            Cursor.Current = Cursors.WaitCursor;
            int maxiteration = 1000;    // how often it should check if it convexes
          


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
                    

                    while (maxiteration > iteration && (zReal * zReal + zImaginary * zImaginary) < 4) //breakloop cause its gonna go to infinity 100%
                    {
                        float temp = zReal * zReal - zImaginary * zImaginary + cReal;
                        zImaginary = 2 * zReal * zImaginary + cImaginary;
                        zReal = temp;
                        iteration++;
                    }
                    if (iteration > 0 && iteration < 25)
                    {
                        image.SetPixel(i, j, Color.FromArgb((iteration % 25) * 10, 0, 0));
                    }
                    else if(iteration > 25 && iteration < 51)
                    {
                        image.SetPixel(i, j, Color.FromArgb(0, (iteration % 25) * 10, 0));
                    }
                    else if (iteration > 51 && iteration < 73)
                    {
                        image.SetPixel(i, j, Color.FromArgb(0, 0, (iteration % 25) * 10));
                    }
                    else if (iteration > 73 && iteration < maxiteration)
                    {
                        image.SetPixel(i, j, Color.FromArgb((iteration % 25) * 10, (iteration % 25) * 10, (iteration % 25) * 10));
                    }
                    else
                    {

                        image.SetPixel(i, j, Color.Black);
                    }
                }

            }
            pictureBox1.Image = image; // set bitmap to picbox
            Cursor.Current = Cursors.Default;
        }

        private void updatetxt(float Xmin, float Xmax, float Ymin, float Ymax, float Xtotal, float Ytotal)
        {
            txt_Xmax.Text = Convert.ToString(Xmax);
            txt_Xmin.Text = Convert.ToString(Xmin);
            txt_Ymax.Text = Convert.ToString(Ymax);
            txt_Ymin.Text = Convert.ToString(Ymin);
            
            lbl_Xtotal.Text = Convert.ToString("Xt: " + Xtotal);
            lbl_Ytotal.Text = Convert.ToString("Yt: " + Ytotal);
            
            lbl_xy.Text = Convert.ToString(Xmin + " / " + (-Ymin));
            lbl_xy_2.Text = Convert.ToString(Xmax + " / " +(-Ymax));
          
            lbl_y25.Text = Convert.ToString(-(Ymin + Ytotal * 0.25));
            lbl_y25_2.Text = Convert.ToString(-(Ymin + Ytotal * 0.25));

            lbl_y50.Text = Convert.ToString(-(Ymin + Ytotal * 0.50));
            lbl_y50_2.Text = Convert.ToString(-(Ymin + Ytotal * 0.50));
            
            lbl_y75.Text = Convert.ToString(-(Ymin + Ytotal * 0.75));
            lbl_y75_2.Text = Convert.ToString(-(Ymin + Ytotal * 0.75));
            
            lbl_x25.Text = Convert.ToString(Xmin + Xtotal * 0.25);
            lbl_x25_2.Text = Convert.ToString(Xmin + Xtotal * 0.25);

            lbl_x50.Text = Convert.ToString(Xmin + Xtotal * 0.50);
            lbl_x50_2.Text = Convert.ToString(Xmin + Xtotal * 0.50);

            lbl_x75.Text = Convert.ToString(Xmin + Xtotal * 0.75);
            lbl_x75_2.Text = Convert.ToString(Xmin + Xtotal * 0.75);

            lbl_x100.Text = Convert.ToString(Xmin + Xtotal);
        }


        private void btn_savetopng_Click(object sender, EventArgs e)
        {
             
                Xmin = lastMouseclickx - (0.2f * Xtotal) / 2;
                Xmax = lastMouseclickx + (0.2f * Xtotal) / 2;
                Xtotal = Xmax - Xmin;

                Ymin = lastMouseclicky - (0.2f * Ytotal) / 2;
                Ymax = lastMouseclicky + (0.2f * Ytotal) / 2;
                Ytotal = Ymax - Ymin;
                updatetxt(Xmin, Xmax, Ymin, Ymax, Xtotal, Ytotal);
                render();
                
            
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_x.Text = Convert.ToString(((Xtotal * e.X) / pictureBox1.Width) + Xmin);
            lbl_y.Text = Convert.ToString(-(((Ytotal * e.Y) / pictureBox1.Height) + Ymin));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastMouseclickx = (((Xtotal * e.X) / pictureBox1.Width) +Xmin);
            lastMouseclicky = (((Ytotal * e.Y) / pictureBox1.Height) + Ymin);
            lbl_xclick.Text = "X: " + Convert.ToString(lastMouseclickx);
            lbl_yclick.Text = "Y: " + Convert.ToString(lastMouseclicky);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset() 
        {
            Zoomfactor = 2;
            txt_Zoomfactor.Text = "2";
            Xmax = 1;
            Xmin = -2;
            Ymax = 1;
            Ymin = -1;
            Xtotal = Xmax - Xmin;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax, Xtotal, Ytotal);
            render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String name = "Mandelbrot_" + DateTime.UtcNow.Day.ToString()
                + DateTime.UtcNow.Hour.ToString() 
                + DateTime.UtcNow.Minute.ToString() 
                + DateTime.UtcNow.Second.ToString() 
                + DateTime.UtcNow.Millisecond.ToString()
                + ".png";
            image.Save(name);
            MessageBox.Show("Current Image saved as: " + name);
        }

        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            Zoomfactor = Convert.ToInt32(txt_Zoomfactor.Text);
            if (Zoomfactor == 0) { Zoomfactor = 2; }
            Xmin = lastMouseclickx - (Zoomfactor * Xtotal) / 2;
            Xmax = lastMouseclickx + (Zoomfactor * Xtotal) / 2;
            Xtotal = Xmax - Xmin;

            Ymin = lastMouseclicky - (Zoomfactor * Ytotal) / 2;
            Ymax = lastMouseclicky + (Zoomfactor * Ytotal) / 2;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax, Xtotal, Ytotal);
            render();
        }

        private void btn_smaller_Click(object sender, EventArgs e)
        {
            Zoomfactor = Convert.ToInt32(txt_Zoomfactor.Text);
            if (Zoomfactor == 0) { Zoomfactor = 2; }
            Xmin = lastMouseclickx - (Xtotal/Zoomfactor) / 2;
            Xmax = lastMouseclickx + (Xtotal / Zoomfactor) / 2;
            Xtotal = Xmax - Xmin;

            Ymin = lastMouseclicky - (Ytotal / Zoomfactor) / 2;
            Ymax = lastMouseclicky + (Ytotal / Zoomfactor) / 2;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax, Xtotal, Ytotal);
            render();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
           
            Xmin = lastMouseclickx - (Xtotal) / 2;
            Xmax = lastMouseclickx + (Xtotal) / 2;
            Xtotal = Xmax - Xmin;

            Ymin = lastMouseclicky - (Ytotal) / 2;
            Ymax = lastMouseclicky + (Ytotal) / 2;
            Ytotal = Ymax - Ymin;
            updatetxt(Xmin, Xmax, Ymin, Ymax, Xtotal, Ytotal);
            render();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_smaller_MouseHover(object sender, EventArgs e)
        {
            tool_tip.Show("Zoomes into the Picture.", btn_smaller);
        }

        private void btn_bigger_MouseHover(object sender, EventArgs e)
        {
            tool_tip.Show("Zoomes out of the Picture.", btn_bigger);
        }

        private void btn_savecoords_MouseHover(object sender, EventArgs e)
        {
            tool_tip.Show("Sets the X and Y to the ones given by the user.", btn_savecoords);
        }

        private void btn_reset_MouseHover(object sender, EventArgs e)
        {
            tool_tip.Show("Resets to the default Values.", btn_reset);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            tool_tip.Show("Creates and Saves an Image of the Current displayed Image \n the Name is determained by the current time.", btn_savetopng);
        }
    } 

}
