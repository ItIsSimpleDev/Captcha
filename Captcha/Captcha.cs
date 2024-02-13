using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Captcha
{
    public class Captcha
    {
        static Font font = null;

        static Captcha()
        {
            font = new Font("Arial", 24f, FontStyle.Bold);
        }

        public string Guid { get; }
        public string Code { get; }
        public DateTime CreatedTime { get; }

        public Captcha(string guid)
        {
            Guid = guid;
            Code = CreateCode();
            CreatedTime = DateTime.Now;
        }

        public byte[] GetImage()
        {
            byte[] bitmapArray = null;
            Bitmap bitmap = new Bitmap(180, 50);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                Brush brush = Brushes.Blue;
                StringFormat stringFormat = new StringFormat();
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.Alignment = StringAlignment.Center;
                graphics.DrawString(Code, font, Brushes.Gray, new Rectangle(2, 2, bitmap.Width, bitmap.Height), stringFormat);
                graphics.DrawString(Code, font, brush, new Rectangle(0, 0, bitmap.Width, bitmap.Height), stringFormat);
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    bitmapArray = stream.ToArray();
                }
            }
            return bitmapArray;
        }
        private string CreateCode()
        {
            string code = "";
            string charset = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnopqrstuvw23456789";

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int pos = rnd.Next(charset.Length);
                code += charset[pos];
            }
            return code;
        }
    }
}