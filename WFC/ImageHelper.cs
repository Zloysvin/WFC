using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC
{
    public static class ImageHelper
    {
        public static List<Bitmap> GetSplittedBitmaps()
        {
            Bitmap main = ReadImage();
        }

        private static Bitmap ReadImage()
        {
            Console.WriteLine("Enter Base Image Path:");
            string path = @Console.ReadLine(); // TODO: add checks for valid paths

            return new Bitmap(path);
        }
    }
}
