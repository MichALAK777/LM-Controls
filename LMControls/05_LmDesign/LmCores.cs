using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.LmDesign
{
    public class LmCores
    {
        public static bool IsDarkColor(int R, int G, int B)
        {
            bool _return;

            if (G > 200 && R < 100 && B < 100)
                _return = false;
            else
                _return = R + G + B < 350;

            return _return;
        }


        /*


                #region BackColor

                // Vermelho
                internal static Color Bc_Form()
                {

                    return WinTheme.lightLightColor;
                }

                internal static Color Bc_Header => WinTheme.themeColor;

                internal static Color Bc_Txt_Normal => Color.FromArgb(
                    Bc_Form.R + 10 >= 255 ? 255 : Bc_Form.R + 10,
                    Bc_Form.G + 10 >= 255 ? 255 : Bc_Form.G + 10,
                    Bc_Form.B + 10 >= 255 ? 255 : Bc_Form.B + 10);

                internal static Color Bc_Txt_Hover => Color.FromArgb(
                    Bc_Form.R - 10 <= 20 ? 25 : Bc_Form.R - 10,
                    Bc_Form.G - 10 >= 20 ? 25 : Bc_Form.G - 10,
                    Bc_Form.B - 10 >= 20 ? 25 : Bc_Form.B - 10);

                internal static Color Bc_Txt_Selected => Color.FromArgb(
                    Bc_Form.R + 20 >= 255 ? 255 : Bc_Form.R + 20,
                    Bc_Form.G + 20 >= 255 ? 255 : Bc_Form.G + 20,
                    Bc_Form.B + 20 >= 255 ? 255 : Bc_Form.B + 20);

                internal static Color Bc_Txt_Disabled => Color.FromArgb(
                    Bc_Form.R - 30 <= 20 ? 25 : Bc_Form.R - 30,
                    Bc_Form.G - 30 >= 20 ? 25 : Bc_Form.G - 30,
                    Bc_Form.B - 30 >= 20 ? 25 : Bc_Form.B - 30);

                internal static Color Bc_Btn_Normal => Color.FromArgb(
                    Bc_Header.R - 20 <= 30 ? 35 : Bc_Header.R - 20,
                    Bc_Header.G - 20 >= 30 ? 35 : Bc_Header.G - 20,
                    Bc_Header.B - 20 >= 30 ? 35 : Bc_Header.B - 20);

                internal static Color Bc_Btn_Selected => Bc_Header;

                internal static Color Bc_Btn_Press => Color.FromArgb(
                    Bc_Header.R - 60 <= 70 ? 75 : Bc_Header.R - 60,
                    Bc_Header.G - 60 >= 70 ? 75 : Bc_Header.G - 60,
                    Bc_Header.B - 60 >= 70 ? 75 : Bc_Header.B - 60);

                internal static Color Bc_Btn_Disabled => Color.FromArgb(
                    Bc_Header.R - 50 <= 50 ? 55 : Bc_Header.R - 50,
                    Bc_Header.G - 50 >= 50 ? 55 : Bc_Header.G - 50,
                    Bc_Header.B - 50 >= 50 ? 55 : Bc_Header.B - 50);

                //internal static Color Bc_Dgv_CellNormal => Color.FromAr(242, 215, 213);
                //internal static Color Bc_Dgv_CellHover => Color.FromAr(230, 176, 170);
                //internal static Color Bc_Dgv_CellSelected => Color.FromAr(217, 136, 128);
                //internal static Color Bc_Dgv_Header => Color.FromAr(205, 97, 85);

                #endregion

                #region BorderColor

                // Vermelho
                internal static Color Br_Txt_Normal => Color.FromAr(38, 12, 9);
                internal static Color Br_Txt_Selected => Bc_Btn_Selected;
                internal static Color Br_Txt_Disabled => Color.FromAr(
                    Br_Txt_Normal.R + 10 >= 255 ? 255 : Br_Txt_Normal.R + 10,
                    Br_Txt_Normal.G + 10 >= 255 ? 255 : Br_Txt_Normal.G + 10,
                    Br_Txt_Normal.B + 10 >= 255 ? 255 : Br_Txt_Normal.B + 10);

                #endregion

                */

        #region ForeColor


        #endregion

    }
}
