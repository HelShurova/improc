using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Filter;

namespace ImageProcessing
{
    public partial class FormMain : Form
    {
        private Bitmap scrImage;

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
                    scrImage = new Bitmap(openImageDialog.FileName);
                    pictureBoxMain.Image = scrImage;
                    hScrollBarFilterIntensity.Value = 9;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void hScrollBarFilterIntensity_ValueChanged(object sender, EventArgs e)
        {
            int filterType = GetFilterType();
            int filterSubType = GetFilterSubType(filterType);
            
            IFilter filter = FilterFactory.GetInstance().GetFilter(filterType);
            Bitmap resImage = filter.ApplyFilter(scrImage, filterSubType, hScrollBarFilterIntensity.Value/10);
            pictureBoxMain.Image = resImage;
        }

        private void radioButtonMorphological_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMorphological.Checked)
            {
                groupBoxMorphAdditional.Visible = true;
            }
            else
            {
                groupBoxMorphAdditional.Visible = false;
            }
        }

        private int GetFilterType()
        {
            int filterType = 0;
            if (radioButtonMorphological.Checked)
            {
                filterType = FilterFactory.MORPHOLOGICAL;
            }
            return filterType;
        }

        private int GetFilterSubType(int filterType)
        {
            int filterSubType = 0;
            switch (filterType)
            {
                case FilterFactory.MORPHOLOGICAL:
                    if (radioButtonDilation.Checked)
                    {
                        filterSubType = MorphologicalFilter.DILATION;
                    }
                    else if (radioButtonErosion.Checked)
                    {
                        filterSubType = MorphologicalFilter.EROSION;
                    }
                    else if (radioButtonOpen.Checked)
                    {
                        filterSubType = MorphologicalFilter.OPEN;
                    }
                    else if (radioButtonClose.Checked)
                    {
                        filterSubType = MorphologicalFilter.CLOSE;
                    }
                    break;
            }
            return filterSubType;
        }
    }
}
