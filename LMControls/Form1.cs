using LMControls.LmDesign;
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
    public partial class Form1 : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public Form1()
        {
            WinTheme.LoadTheme();

            InitializeComponent();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

            lblThemeColor.BackColor = WinTheme.ThemeColor;
            lblLightColor.BackColor = WinTheme.LightColor;
            lblLightLightColor.BackColor = WinTheme.LightLightColor;
            lblDarkColor.BackColor = WinTheme.DarkColor;
            lblDarkDarkColor.BackColor = WinTheme.DarkDarkColor;
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

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                WinTheme.LoadTheme();
            }
        }
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }
    }
}
