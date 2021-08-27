using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;

namespace capture_Trim_From_Any_Camera
{
    public partial class captureImageFrm : Form
    {
        public captureImageFrm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        //crop vars
        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.Yellow);

        private void captureImageFrm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("temporary_files"))
                Directory.CreateDirectory("temporary_files");


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cameraCmb.Items.Add(filterInfo.Name);
            cameraCmb.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCmb.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            livePic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void captureImageFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            if (livePic.Image != null)
            {
                try
                {
                    capturedPic.Image = new Bitmap(livePic.Image);
                    cropPic.Image = null;
                }
                catch (Exception ex) {}

            }
            else
            { MessageBox.Show("null exception"); }
     
            /*capturedPic.Image = null;
            capturedPic.Image = Image.FromFile(@"temporary_files\temp.jpg");*/
        }

        private void capturedPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (capturedPic.Image == null)
                return;

            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // set initial x,y co ordinates for crop rectangle
                //this is where we firstly click on image
                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void capturedPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (capturedPic.Image == null)
                return;

            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                capturedPic.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = capturedPic.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void capturedPic_MouseEnter(object sender, EventArgs e)
        {
            if (capturedPic.Image == null)
                return;

            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void capturedPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (capturedPic.Image == null)
                return;

            //label2.Text = "Dimensions :" + rectW + "," + rectH;
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
            Bitmap bmp2 = new Bitmap(capturedPic.Width, capturedPic.Height);
            capturedPic.DrawToBitmap(bmp2, capturedPic.ClientRectangle);

            
            try
            {
                Bitmap crpImg = new Bitmap(rectW, rectH);

                for (int i = 0; i < rectW; i++)
                {
                    for (int y = 0; y < rectH; y++)
                    {
                        Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                        crpImg.SetPixel(i, y, pxlclr);
                    }
                }

                cropPic.Image = (Image)crpImg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again");
                return;
            }

            
        }

        private void useImageBtn_Click(object sender, EventArgs e)
        {
            if (cropPic.Image != null)
            {
                global.passport = new Bitmap(cropPic.Image);
                this.Close();
            }
        }
    }
}
