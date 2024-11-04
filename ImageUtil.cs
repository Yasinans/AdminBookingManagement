using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement
{
    public static class ImageUtil
    {
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (Image clonedImage = new Bitmap(image))
                {
                    clonedImage.Save(ms, format);
                }
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms); 
                return image;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting Base64 to Image: {ex.Message}");
                return null;
            }
        }
    }
}
