using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capture_Trim_From_Any_Camera
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void imageFromFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "*.jpg|*.jpeg|*.gif|*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    passportPic.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void useCameraBtn_Click(object sender, EventArgs e)
        {
            captureImageFrm capFrm = new captureImageFrm();
            capFrm.ShowDialog();

            if (global.passport != null)
                passportPic.Image = new Bitmap(global.passport);
        }
    }
}
