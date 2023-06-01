using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ImageFilter
    {
        public static Image MakeTransparent(Image image, byte alpha)
        {
            Bitmap originalImage = new Bitmap(image);
            Bitmap transparentImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < originalImage.Width; ++x)
            {
                for (int y = 0; y < originalImage.Height; ++y)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    transparentImage.SetPixel(x, y, Color.FromArgb(alpha, pixel.R, pixel.G, pixel.B));
                }
            }

            return transparentImage;
        }
    }
}
