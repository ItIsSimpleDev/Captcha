using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class CaptchaServer
    {
        static private Dictionary<string, Captcha> captchas = new Dictionary<string, Captcha>();

        static public Image GetCaptchaImage(string guid)
        {
            if (CaptchaServer.captchas.ContainsKey(guid))
                CaptchaServer.captchas.Remove(guid);

            Captcha captcha = new Captcha(guid);
            CaptchaServer.captchas.Add(guid, captcha);
            Image image;
            using (MemoryStream ms = new MemoryStream(captcha.GetImage()))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        static public void UseCaptcha(string guid, string code)
        {
            if (!CaptchaServer.captchas.ContainsKey(guid))
                throw new Exception("Invalid captcha.");

            Captcha captcha = CaptchaServer.captchas[guid];
            if (code != captcha.Code)
                throw new Exception("Invalid captcha.");

            CaptchaServer.captchas.Remove(guid);
        }
    }
}
