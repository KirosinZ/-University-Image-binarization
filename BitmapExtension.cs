using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG1
{
    static class BitmapExtension
    {
        public static Bitmap ToGrayscale(this Bitmap @this)
        {
            Bitmap res = new Bitmap(@this);
            BitmapWrapper wres = new BitmapWrapper(res);
            wres.Lock();

            for (int i = 0; i < wres.Length / 4; i++)
            {
                Color col = wres[i];

                if (col.R == col.G && col.R == col.B) continue;

                byte y = (byte)(0.299 * col.R + 0.587 * col.G + 0.114 * col.B);
                wres[i] = Color.FromArgb(col.A, y, y, y);
            }

            wres.Unlock();
            return res;
        }

        public static Bitmap Resize(this Bitmap @this, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(@this.HorizontalResolution, @this.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(@this, destRect, 0, 0, @this.Width, @this.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
