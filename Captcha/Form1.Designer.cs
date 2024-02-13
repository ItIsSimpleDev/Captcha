
namespace Captcha
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.captchaPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.captchaValueTxtBox = new System.Windows.Forms.TextBox();
            this.approveBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captchaPicBox
            // 
            this.captchaPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captchaPicBox.Location = new System.Drawing.Point(199, 72);
            this.captchaPicBox.Name = "captchaPicBox";
            this.captchaPicBox.Size = new System.Drawing.Size(254, 74);
            this.captchaPicBox.TabIndex = 0;
            this.captchaPicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.approveBtn);
            this.panel1.Controls.Add(this.captchaValueTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.captchaPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 345);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value:";
            // 
            // captchaValueTxtBox
            // 
            this.captchaValueTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captchaValueTxtBox.Font = new System.Drawing.Font("Consolas", 18F);
            this.captchaValueTxtBox.Location = new System.Drawing.Point(199, 164);
            this.captchaValueTxtBox.Name = "captchaValueTxtBox";
            this.captchaValueTxtBox.Size = new System.Drawing.Size(254, 36);
            this.captchaValueTxtBox.TabIndex = 2;
            // 
            // approveBtn
            // 
            this.approveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.approveBtn.Font = new System.Drawing.Font("Consolas", 18F);
            this.approveBtn.Location = new System.Drawing.Point(322, 206);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(131, 39);
            this.approveBtn.TabIndex = 3;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.Font = new System.Drawing.Font("Consolas", 18F);
            this.refreshBtn.Location = new System.Drawing.Point(199, 206);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(117, 39);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 345);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox captchaPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.TextBox captchaValueTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshBtn;
    }
}

