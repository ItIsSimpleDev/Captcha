using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        private Guid guid = new Guid();

        public Form1()
        {
            InitializeComponent();
            captchaPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            captchaPicBox.Image = CaptchaServer.GetCaptchaImage(guid.ToString());
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CaptchaServer.UseCaptcha(guid.ToString(), captchaValueTxtBox.Text);
                MessageBox.Show("Correct Captcha");
                refreshCaptcha();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                captchaValueTxtBox.Text = string.Empty;
                refreshCaptcha();
                return;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshCaptcha();
        }
        private void refreshCaptcha()
        {
            Guid newGuid = new Guid();
            captchaPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            captchaPicBox.Image = CaptchaServer.GetCaptchaImage(newGuid.ToString());
            captchaValueTxtBox.Text = string.Empty;
        }
    }
}
