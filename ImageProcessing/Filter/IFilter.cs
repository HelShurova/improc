using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing.Filter
{
    public interface IFilter
    {
        Bitmap ApplyFilter(Bitmap srcImage, int filterSubType, int level);
    }
}
