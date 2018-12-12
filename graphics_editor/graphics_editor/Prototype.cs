using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_editor
{
    abstract class iFigure//prototype
    {
        public Image pbox1;
        public abstract iFigure Clone(iFigure figure,Image srcBitmap, Rectangle section);
    }

    class CopyCircle : iFigure//concrete prototype1
    {
        public override iFigure Clone(iFigure figure, Image srcBitmap, Rectangle section)
        {
            // Вырезаем выбранный кусок картинки
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }
            figure.pbox1 = bmp;
            //Возвращаем кусок картинки.
            return figure;

            //Clipboard.SetDataObject(result.pbox2.Image, true);
            //return result;
        }

    }
    class CopyRectangle : iFigure//concrete prototype2
    {
        public override iFigure Clone(iFigure figure, Image srcBitmap, Rectangle section)
        {
            // Вырезаем выбранный кусок картинки
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }
            figure.pbox1 = bmp;
            //Возвращаем кусок картинки.
            return figure;
            //Clipboard.SetDataObject(result.pbox2.Image, true);
            //return result;
        }
    }
}