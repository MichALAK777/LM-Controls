using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LMControls.LmDesign
{
    public class WinTheme
    {
        public static Color ThemeColor { get; set; }
        public static Color LightColor { get; set; }
        public static Color LightLightColor { get; set; }
        public static Color DarkColor { get; set; }
        public static Color DarkDarkColor { get; set; }

        internal static Color Fr_Preto_Normal => Color.FromArgb(43, 41, 38);
        internal static Color Fr_Preto_Selected => Color.FromArgb(23, 21, 18);
        internal static Color Fr_Preto_Disabled => Color.FromArgb(85, 85, 90);

        internal static Color Fr_Branco_Normal => Color.FromArgb(255, 255, 255);
        internal static Color Fr_Branco_Selected => Color.FromArgb(225, 225, 235);
        internal static Color Fr_Branco_Disabled => Color.FromArgb(129, 129, 129); 

        //Extern methods
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        private static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType,
                                                                    bool bIgnoreHighContrast, uint dwHighContrastCacheMode);

        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        private static extern uint GetImmersiveColorTypeFromName(IntPtr pName);

        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        //Public methods
        public static Color GetAccentColor()
        {
            var userColorSet = GetImmersiveUserColorSetPreference(false, false);
            var colorType = GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
            var colorSetEx = GetImmersiveColorFromColorSetEx((uint)userColorSet, colorType, false, 0);

            return ConvertDWordColorToRGB(colorSetEx);
        }

        //Private methods
        private static Color ConvertDWordColorToRGB(uint colorSetEx)
        {
            byte redColor = (byte)((0x000000FF & colorSetEx) >> 0);
            byte greenColor = (byte)((0x0000FF00 & colorSetEx) >> 8);
            byte blueColor = (byte)((0x00FF0000 & colorSetEx) >> 16);
            //byte alphaColor = (byte)((0xFF000000 & colorSetEx) >> 24);

            return Color.FromArgb(redColor, greenColor, blueColor);
        }

        internal static void LoadTheme()
        {
             ThemeColor = WinTheme.GetAccentColor();//Windows Accent Color
             LightColor = ControlPaint.Light(ThemeColor);
             LightLightColor = ControlPaint.LightLight(ThemeColor);
             DarkColor = ControlPaint.Dark(ThemeColor);
             DarkDarkColor = ControlPaint.DarkDark(ThemeColor);
        }

    }
}
