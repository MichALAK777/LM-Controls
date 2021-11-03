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
            if (rjProgressBar1.Value < rjProgressBar1.Maximum)
                rjProgressBar1.Value++;
            else
                timer1.Stop();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjProgressBar1.Value = 0;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
