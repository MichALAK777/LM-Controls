using LMControls.LmDesign;
using LMControls.LmForms;
using LMControls.RJControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls
{
    public partial class Form1 : LmSingleForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void LoadTheme()
        //{
        //    var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
        //    var lightColor = ControlPaint.Light(themeColor);
        //    var lightlightColor = ControlPaint.LightLight(themeColor);
        //    var darkColor = ControlPaint.Dark(themeColor);
        //    var darkdarkColor = ControlPaint.DarkDark(themeColor);

        //    panelTitleBar.BackColor = themeColor;
        //    rjCircularPictureBox1.BorderColor = themeColor;
        //    rjCircularPictureBox1.BorderColor2 = darkColor;

        //    btnDarkColor.BackColor = darkColor;
        //    btnDarkdarkColor.BackColor = darkdarkColor;
        //    btnLightColor.BackColor = lightColor;
        //    btnLightLightColor.BackColor = lightlightColor;
        //    btnThemeColor.BackColor = themeColor;


        //    ////Buttons
        //    //foreach (RJButton button in this.Controls.OfType<RJButton>())
        //    //{
        //    //    button.BackColor = themeColor;
        //    //}
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSize.Text = $"Size: {this.Size.ToString()} | ClientSize: {this.ClientSize.ToString()}";
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjProgressBar1.Value = 0;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //using (Bitmap bmp = new Bitmap("myImage.png"))
            //{

            //    // Set the image attribute's color mappings
            //    System.Drawing.Imaging.ColorMap[] colorMap = new System.Drawing.Imaging.ColorMap[1];
            //    colorMap[0] = new System.Drawing.Imaging.ColorMap();
            //    colorMap[0].OldColor = Color.Black;
            //    colorMap[0].NewColor = Color.Blue;
            //    System.Drawing.Imaging.ImageAttributes attr = new System.Drawing.Imaging.ImageAttributes();
            //    attr.SetRemapTable(colorMap);
            //    // Draw using the color map
            //    Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //    g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            //}
        }

        private void lmMenuItem2_Click(object sender, EventArgs e)
        {
            MenuControles.Show(lmMenuItem2, lmMenuItem2.Width, 0);
        }
    }
}
