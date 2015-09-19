using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class FormMain : Form
    {
        private Bitmap image;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.AutoSize;
                    image = new Bitmap(openImageDialog.FileName);
                  //  pictureBoxMain.ClientSize = new Size(xSize, ySize);
                    pictureBoxMain.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
