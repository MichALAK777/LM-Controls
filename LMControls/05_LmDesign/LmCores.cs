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

        #region BackColor

        // Azul
        internal static Color Bc_Azul_Form => Color.FromArgb(187, 222, 251);
        internal static Color Bc_Azul_Header => Color.FromArg(27, 79, 114);
        internal static Color Bc_Azul_Txt_Normal => Color.FromArg(
            Bc_Azul_Form.R + 10 >= 255 ? 255 : Bc_Azul_Form.R + 10,
            Bc_Azul_Form.G + 10 >= 255 ? 255 : Bc_Azul_Form.G + 10,
            Bc_Azul_Form.B + 10 >= 255 ? 255 : Bc_Azul_Form.B + 10);
        internal static Color Bc_Azul_Txt_Hover => Color.FromArg(
            Bc_Azul_Form.R - 10 <= 20 ? 25 : Bc_Azul_Form.R - 10,
            Bc_Azul_Form.G - 10 >= 20 ? 25 : Bc_Azul_Form.G - 10,
            Bc_Azul_Form.B - 10 >= 20 ? 25 : Bc_Azul_Form.B - 10);
        internal static Color Bc_Azul_Txt_Selected => Color.FromArg(
            Bc_Azul_Form.R + 20 >= 255 ? 255 : Bc_Azul_Form.R + 20,
            Bc_Azul_Form.G + 20 >= 255 ? 255 : Bc_Azul_Form.G + 20,
            Bc_Azul_Form.B + 20 >= 255 ? 255 : Bc_Azul_Form.B + 20);
        internal static Color Bc_Azul_Txt_Disabled => Color.FromArg(
            Bc_Azul_Form.R - 30 <= 20 ? 25 : Bc_Azul_Form.R - 30,
            Bc_Azul_Form.G - 30 >= 20 ? 25 : Bc_Azul_Form.G - 30,
            Bc_Azul_Form.B - 30 >= 20 ? 25 : Bc_Azul_Form.B - 30);
        internal static Color Bc_Azul_Btn_Normal => Color.FromArg(41, 128, 185);
        internal static Color Bc_Azul_Btn_Selected => Color.FromArg(41, 128, 185);
        internal static Color Bc_Azul_Btn_Press => Color.FromArg(133, 193, 233);
        internal static Color Bc_Azul_Btn_Disabled => Color.FromArg(127, 179, 213);
        internal static Color Bc_Azul_Dgv_CellNormal => Color.FromArg(212, 230, 241);
        internal static Color Bc_Azul_Dgv_CellHover => Color.FromArg(174, 214, 241);
        internal static Color Bc_Azul_Dgv_CellSelected => Color.FromArg(127, 179, 213);
        internal static Color Bc_Azul_Dgv_Header => Color.FromArg(84, 153, 199);

        // Vermelho
        internal static Color Bc_Vermelho_Form => Color.FromArgb(255, 235, 238);
        internal static Color Bc_Vermelho_Header => Color.FromArg(100, 30, 22);
        internal static Color Bc_Vermelho_Txt_Normal => Color.FromArg(
            Bc_Vermelho_Form.R + 10 >= 255 ? 255 : Bc_Vermelho_Form.R + 10,
            Bc_Vermelho_Form.G + 10 >= 255 ? 255 : Bc_Vermelho_Form.G + 10,
            Bc_Vermelho_Form.B + 10 >= 255 ? 255 : Bc_Vermelho_Form.B + 10);
        internal static Color Bc_Vermelho_Txt_Hover => Color.FromArg(
            Bc_Vermelho_Form.R - 10 <= 20 ? 25 : Bc_Vermelho_Form.R - 10,
            Bc_Vermelho_Form.G - 10 >= 20 ? 25 : Bc_Vermelho_Form.G - 10,
            Bc_Vermelho_Form.B - 10 >= 20 ? 25 : Bc_Vermelho_Form.B - 10);
        internal static Color Bc_Vermelho_Txt_Selected => Color.FromArg(
            Bc_Vermelho_Form.R + 20 >= 255 ? 255 : Bc_Vermelho_Form.R + 20,
            Bc_Vermelho_Form.G + 20 >= 255 ? 255 : Bc_Vermelho_Form.G + 20,
            Bc_Vermelho_Form.B + 20 >= 255 ? 255 : Bc_Vermelho_Form.B + 20);
        internal static Color Bc_Vermelho_Txt_Disabled => Color.FromArg(
            Bc_Vermelho_Form.R - 30 <= 20 ? 25 : Bc_Vermelho_Form.R - 30,
            Bc_Vermelho_Form.G - 30 >= 20 ? 25 : Bc_Vermelho_Form.G - 30,
            Bc_Vermelho_Form.B - 30 >= 20 ? 25 : Bc_Vermelho_Form.B - 30);
        internal static Color Bc_Vermelho_Btn_Normal => Color.FromArg(192, 57, 43);
        internal static Color Bc_Vermelho_Btn_Selected => Color.FromArg(146, 43, 33);
        internal static Color Bc_Vermelho_Btn_Press => Color.FromArg(217, 136, 128);
        internal static Color Bc_Vermelho_Btn_Disabled => Color.FromArg(205, 97, 85);
        internal static Color Bc_Vermelho_Dgv_CellNormal => Color.FromArg(242, 215, 213);
        internal static Color Bc_Vermelho_Dgv_CellHover => Color.FromArg(230, 176, 170);
        internal static Color Bc_Vermelho_Dgv_CellSelected => Color.FromArg(217, 136, 128);
        internal static Color Bc_Vermelho_Dgv_Header => Color.FromArg(205, 97, 85);

        // Lilas
        internal static Color Bc_Lilas_Form => Color.FromArg(245, 238, 248);
        internal static Color Bc_Lilas_Header => Color.FromArg(81, 46, 95);
        internal static Color Bc_Lilas_Txt_Normal => Color.FromArg(
            Bc_Lilas_Form.R + 10 >= 255 ? 255 : Bc_Lilas_Form.R + 10,
            Bc_Lilas_Form.G + 10 >= 255 ? 255 : Bc_Lilas_Form.G + 10,
            Bc_Lilas_Form.B + 10 >= 255 ? 255 : Bc_Lilas_Form.B + 10);
        internal static Color Bc_Lilas_Txt_Hover => Color.FromArg(
            Bc_Lilas_Form.R - 10 <= 20 ? 25 : Bc_Lilas_Form.R - 10,
            Bc_Lilas_Form.G - 10 >= 20 ? 25 : Bc_Lilas_Form.G - 10,
            Bc_Lilas_Form.B - 10 >= 20 ? 25 : Bc_Lilas_Form.B - 10);
        internal static Color Bc_Lilas_Txt_Selected => Color.FromArg(
            Bc_Lilas_Form.R + 20 >= 255 ? 255 : Bc_Lilas_Form.R + 20,
            Bc_Lilas_Form.G + 20 >= 255 ? 255 : Bc_Lilas_Form.G + 20,
            Bc_Lilas_Form.B + 20 >= 255 ? 255 : Bc_Lilas_Form.B + 20);
        internal static Color Bc_Lilas_Txt_Disabled => Color.FromArg(
            Bc_Lilas_Form.R - 30 <= 20 ? 25 : Bc_Lilas_Form.R - 30,
            Bc_Lilas_Form.G - 30 >= 20 ? 25 : Bc_Lilas_Form.G - 30,
            Bc_Lilas_Form.B - 30 >= 20 ? 25 : Bc_Lilas_Form.B - 30);
        internal static Color Bc_Lilas_Btn_Normal => Color.FromArg(142, 68, 173);
        internal static Color Bc_Lilas_Btn_Selected => Color.FromArg(118, 68, 138);
        internal static Color Bc_Lilas_Btn_Press => Color.FromArg(187, 143, 206);
        internal static Color Bc_Lilas_Btn_Disabled => Color.FromArg(142, 68, 173);
        internal static Color Bc_Lilas_Dgv_CellNormal => Color.FromArg(235, 222, 240);
        internal static Color Bc_Lilas_Dgv_CellHover => Color.FromArg(215, 189, 226);
        internal static Color Bc_Lilas_Dgv_CellSelected => Color.FromArg(195, 155, 211);
        internal static Color Bc_Lilas_Dgv_Header => Color.FromArg(175, 122, 197);

        // Verde
        internal static Color Bc_Verde_Form => Color.FromArg(234, 250, 241); // ultima coluna da tab Cor
        internal static Color Bc_Verde_Header => Color.FromArg(24, 106, 59);
        internal static Color Bc_Verde_Txt_Normal => Color.FromArg(
            Bc_Verde_Form.R + 10 >= 255 ? 255 : Bc_Verde_Form.R + 10,
            Bc_Verde_Form.G + 10 >= 255 ? 255 : Bc_Verde_Form.G + 10,
            Bc_Verde_Form.B + 10 >= 255 ? 255 : Bc_Verde_Form.B + 10);
        internal static Color Bc_Verde_Txt_Hover => Color.FromArg(
            Bc_Verde_Form.R - 10 <= 20 ? 25 : Bc_Verde_Form.R - 10,
            Bc_Verde_Form.G - 10 >= 20 ? 25 : Bc_Verde_Form.G - 10,
            Bc_Verde_Form.B - 10 >= 20 ? 25 : Bc_Verde_Form.B - 10);
        internal static Color Bc_Verde_Txt_Selected => Color.FromArg(
            Bc_Verde_Form.R + 20 >= 255 ? 255 : Bc_Verde_Form.R + 20,
            Bc_Verde_Form.G + 20 >= 255 ? 255 : Bc_Verde_Form.G + 20,
            Bc_Verde_Form.B + 20 >= 255 ? 255 : Bc_Verde_Form.B + 20);
        internal static Color Bc_Verde_Txt_Disabled => Color.FromArg(
            Bc_Verde_Form.R - 30 <= 20 ? 25 : Bc_Verde_Form.R - 30,
            Bc_Verde_Form.G - 30 >= 20 ? 25 : Bc_Verde_Form.G - 30,
            Bc_Verde_Form.B - 30 >= 20 ? 25 : Bc_Verde_Form.B - 30);
        internal static Color Bc_Verde_Btn_Normal => Color.FromArg(39, 174, 96);
        internal static Color Bc_Verde_Btn_Selected => Color.FromArg(25, 111, 61);
        internal static Color Bc_Verde_Btn_Press => Color.FromArg(82, 190, 128);
        internal static Color Bc_Verde_Btn_Disabled => Color.FromArg(39, 174, 96);
        internal static Color Bc_Verde_Dgv_CellNormal => Color.FromArg(212, 239, 223);
        internal static Color Bc_Verde_Dgv_CellHover => Color.FromArg(171, 235, 198);
        internal static Color Bc_Verde_Dgv_CellSelected => Color.FromArg(130, 224, 170);
        internal static Color Bc_Verde_Dgv_Header => Color.FromArg(82, 190, 128);

        // Amarelo
        internal static Color Bc_Amarelo_Form => Color.FromArg(254, 249, 231);
        internal static Color Bc_Amarelo_Header => Color.FromArg(125, 102, 8);
        internal static Color Bc_Amarelo_Txt_Normal => Color.FromArg(
            Bc_Amarelo_Form.R + 10 >= 255 ? 255 : Bc_Amarelo_Form.R + 10,
            Bc_Amarelo_Form.G + 10 >= 255 ? 255 : Bc_Amarelo_Form.G + 10,
            Bc_Amarelo_Form.B + 10 >= 255 ? 255 : Bc_Amarelo_Form.B + 10);
        internal static Color Bc_Amarelo_Txt_Hover => Color.FromArg(
            Bc_Amarelo_Form.R - 10 <= 20 ? 25 : Bc_Amarelo_Form.R - 10,
            Bc_Amarelo_Form.G - 10 >= 20 ? 25 : Bc_Amarelo_Form.G - 10,
            Bc_Amarelo_Form.B - 10 >= 20 ? 25 : Bc_Amarelo_Form.B - 10);
        internal static Color Bc_Amarelo_Txt_Selected => Color.FromArg(
            Bc_Amarelo_Form.R + 20 >= 255 ? 255 : Bc_Amarelo_Form.R + 20,
            Bc_Amarelo_Form.G + 20 >= 255 ? 255 : Bc_Amarelo_Form.G + 20,
            Bc_Amarelo_Form.B + 20 >= 255 ? 255 : Bc_Amarelo_Form.B + 20);
        internal static Color Bc_Amarelo_Txt_Disabled => Color.FromArg(
            Bc_Amarelo_Form.R - 30 <= 20 ? 25 : Bc_Amarelo_Form.R - 30,
            Bc_Amarelo_Form.G - 30 >= 20 ? 25 : Bc_Amarelo_Form.G - 30,
            Bc_Amarelo_Form.B - 30 >= 20 ? 25 : Bc_Amarelo_Form.B - 30);
        internal static Color Bc_Amarelo_Btn_Normal => Color.FromArg(241, 196, 15);
        internal static Color Bc_Amarelo_Btn_Selected => Color.FromArg(154, 125, 10);
        internal static Color Bc_Amarelo_Btn_Press => Color.FromArg(249, 231, 159);
        internal static Color Bc_Amarelo_Btn_Disabled => Color.FromArg(244, 208, 63);
        internal static Color Bc_Amarelo_Dgv_CellNormal => Color.FromArg(252, 243, 207);
        internal static Color Bc_Amarelo_Dgv_CellHover => Color.FromArg(249, 231, 159);
        internal static Color Bc_Amarelo_Dgv_CellSelected => Color.FromArg(247, 220, 111);
        internal static Color Bc_Amarelo_Dgv_Header => Color.FromArg(241, 196, 15);

        // Laranja
        internal static Color Bc_Laranja_Form => Color.FromArg(254, 249, 231);
        internal static Color Bc_Laranja_Header => Color.FromArg(125, 102, 8);
        internal static Color Bc_Laranja_Txt_Normal => Color.FromArg(
            Bc_Laranja_Form.R + 10 >= 255 ? 255 : Bc_Laranja_Form.R + 10,
            Bc_Laranja_Form.G + 10 >= 255 ? 255 : Bc_Laranja_Form.G + 10,
            Bc_Laranja_Form.B + 10 >= 255 ? 255 : Bc_Laranja_Form.B + 10);
        internal static Color Bc_Laranja_Txt_Hover => Color.FromArg(
            Bc_Laranja_Form.R - 10 <= 20 ? 25 : Bc_Laranja_Form.R - 10,
            Bc_Laranja_Form.G - 10 >= 20 ? 25 : Bc_Laranja_Form.G - 10,
            Bc_Laranja_Form.B - 10 >= 20 ? 25 : Bc_Laranja_Form.B - 10);
        internal static Color Bc_Laranja_Txt_Selected => Color.FromArg(
            Bc_Laranja_Form.R + 20 >= 255 ? 255 : Bc_Laranja_Form.R + 20,
            Bc_Laranja_Form.G + 20 >= 255 ? 255 : Bc_Laranja_Form.G + 20,
            Bc_Laranja_Form.B + 20 >= 255 ? 255 : Bc_Laranja_Form.B + 20);
        internal static Color Bc_Laranja_Txt_Disabled => Color.FromArg(
            Bc_Laranja_Form.R - 30 <= 20 ? 25 : Bc_Laranja_Form.R - 30,
            Bc_Laranja_Form.G - 30 >= 20 ? 25 : Bc_Laranja_Form.G - 30,
            Bc_Laranja_Form.B - 30 >= 20 ? 25 : Bc_Laranja_Form.B - 30);
        internal static Color Bc_Laranja_Btn_Normal => Color.FromArg(241, 196, 15);
        internal static Color Bc_Laranja_Btn_Selected => Color.FromArg(154, 125, 10);
        internal static Color Bc_Laranja_Btn_Press => Color.FromArg(249, 231, 159);
        internal static Color Bc_Laranja_Btn_Disabled => Color.FromArg(244, 208, 63);
        internal static Color Bc_Laranja_Dgv_CellNormal => Color.FromArg(252, 243, 207);
        internal static Color Bc_Laranja_Dgv_CellHover => Color.FromArg(249, 231, 159);
        internal static Color Bc_Laranja_Dgv_CellSelected => Color.FromArg(247, 220, 111);
        internal static Color Bc_Laranja_Dgv_Header => Color.FromArg(241, 196, 15);

        // Marrom
        internal static Color Bc_Marrom_Form => Color.FromArg(251, 238, 230);
        internal static Color Bc_Marrom_Header => Color.FromArg(110, 44, 0);
        internal static Color Bc_Marrom_Txt_Normal => Color.FromArg(
            Bc_Marrom_Form.R + 10 >= 255 ? 255 : Bc_Marrom_Form.R + 10,
            Bc_Marrom_Form.G + 10 >= 255 ? 255 : Bc_Marrom_Form.G + 10,
            Bc_Marrom_Form.B + 10 >= 255 ? 255 : Bc_Marrom_Form.B + 10);
        internal static Color Bc_Marrom_Txt_Hover => Color.FromArg(
            Bc_Marrom_Form.R - 10 <= 20 ? 25 : Bc_Marrom_Form.R - 10,
            Bc_Marrom_Form.G - 10 >= 20 ? 25 : Bc_Marrom_Form.G - 10,
            Bc_Marrom_Form.B - 10 >= 20 ? 25 : Bc_Marrom_Form.B - 10);
        internal static Color Bc_Marrom_Txt_Selected => Color.FromArg(
            Bc_Marrom_Form.R + 20 >= 255 ? 255 : Bc_Marrom_Form.R + 20,
            Bc_Marrom_Form.G + 20 >= 255 ? 255 : Bc_Marrom_Form.G + 20,
            Bc_Marrom_Form.B + 20 >= 255 ? 255 : Bc_Marrom_Form.B + 20);
        internal static Color Bc_Marrom_Txt_Disabled => Color.FromArg(
            Bc_Marrom_Form.R - 30 <= 20 ? 25 : Bc_Marrom_Form.R - 30,
            Bc_Marrom_Form.G - 30 >= 20 ? 25 : Bc_Marrom_Form.G - 30,
            Bc_Marrom_Form.B - 30 >= 20 ? 25 : Bc_Marrom_Form.B - 30);
        internal static Color Bc_Marrom_Btn_Normal => Color.FromArg(211, 84, 0);
        internal static Color Bc_Marrom_Btn_Selected => Color.FromArg(135, 54, 0);
        internal static Color Bc_Marrom_Btn_Press => Color.FromArg(237, 187, 153);
        internal static Color Bc_Marrom_Btn_Disabled => Color.FromArg(220, 118, 51);
        internal static Color Bc_Marrom_Dgv_CellNormal => Color.FromArg(246, 221, 204);
        internal static Color Bc_Marrom_Dgv_CellHover => Color.FromArg(237, 187, 153);
        internal static Color Bc_Marrom_Dgv_CellSelected => Color.FromArg(229, 152, 102);
        internal static Color Bc_Marrom_Dgv_Header => Color.FromArg(211, 84, 0);

        // Cinza
        internal static Color Bc_Cinza_Form => Color.FromArg(242, 244, 244);
        internal static Color Bc_Cinza_Header => Color.FromArg(66, 73, 73);
        internal static Color Bc_Cinza_Txt_Normal => Color.FromArg(
            Bc_Cinza_Form.R + 10 >= 255 ? 255 : Bc_Cinza_Form.R + 10,
            Bc_Cinza_Form.G + 10 >= 255 ? 255 : Bc_Cinza_Form.G + 10,
            Bc_Cinza_Form.B + 10 >= 255 ? 255 : Bc_Cinza_Form.B + 10);
        internal static Color Bc_Cinza_Txt_Hover => Color.FromArg(
            Bc_Cinza_Form.R - 10 <= 20 ? 25 : Bc_Cinza_Form.R - 10,
            Bc_Cinza_Form.G - 10 >= 20 ? 25 : Bc_Cinza_Form.G - 10,
            Bc_Cinza_Form.B - 10 >= 20 ? 25 : Bc_Cinza_Form.B - 10);
        internal static Color Bc_Cinza_Txt_Selected => Color.FromArg(
            Bc_Cinza_Form.R + 20 >= 255 ? 255 : Bc_Cinza_Form.R + 20,
            Bc_Cinza_Form.G + 20 >= 255 ? 255 : Bc_Cinza_Form.G + 20,
            Bc_Cinza_Form.B + 20 >= 255 ? 255 : Bc_Cinza_Form.B + 20);
        internal static Color Bc_Cinza_Txt_Disabled => Color.FromArg(
            Bc_Cinza_Form.R - 30 <= 20 ? 25 : Bc_Cinza_Form.R - 30,
            Bc_Cinza_Form.G - 30 >= 20 ? 25 : Bc_Cinza_Form.G - 30,
            Bc_Cinza_Form.B - 30 >= 20 ? 25 : Bc_Cinza_Form.B - 30);
        internal static Color Bc_Cinza_Btn_Normal => Color.FromArg(112, 123, 124);
        internal static Color Bc_Cinza_Btn_Selected => Color.FromArg(81, 90, 90);
        internal static Color Bc_Cinza_Btn_Press => Color.FromArg(204, 209, 209);
        internal static Color Bc_Cinza_Btn_Disabled => Color.FromArg(153, 163, 164);
        internal static Color Bc_Cinza_Dgv_CellNormal => Color.FromArg(234, 237, 237);
        internal static Color Bc_Cinza_Dgv_CellHover => Color.FromArg(204, 209, 209);
        internal static Color Bc_Cinza_Dgv_CellSelected => Color.FromArg(178, 186, 187);
        internal static Color Bc_Cinza_Dgv_Header => Color.FromArg(112, 123, 124);

        // Preto
        internal static Color Bc_Preto_Form => Color.FromArg(82, 82, 88);
        internal static Color Bc_Preto_Header => Color.FromArg(45, 45, 50);
        internal static Color Bc_Preto_Txt_Normal => Color.FromArg(65, 65, 65);
        internal static Color Bc_Preto_Txt_Hover => Color.FromArg(45, 45, 45);
        internal static Color Bc_Preto_Txt_Selected => Color.FromArg(75, 75, 75);
        internal static Color Bc_Preto_Txt_Disabled => Color.FromArg(62, 62, 62);
        internal static Color Bc_Preto_Txt_WithError => Color.FromArg(158, 57, 60);
        internal static Color Bc_Preto_Btn_Normal => Color.FromArg(104, 93, 94);
        internal static Color Bc_Preto_Btn_Selected => Color.FromArg(72, 66, 67);
        internal static Color Bc_Preto_Btn_Press => Color.FromArg(110, 108, 110);
        internal static Color Bc_Preto_Btn_Disabled => Color.FromArg(169, 169, 169);
        internal static Color Bc_Preto_Dgv_CellNormal => Color.FromArg(91, 91, 92);
        internal static Color Bc_Preto_Dgv_CellHover => Color.FromArg(81, 81, 72);
        internal static Color Bc_Preto_Dgv_CellSelected => Color.FromArg(53, 53, 55);
        internal static Color Bc_Preto_Dgv_Header => Color.FromArg(60, 48, 58);

        // Personalizado
        public static Color Bc_Person_Form { get; set; } = Bc_Azul_Form;
        public static Color Bc_Person_Header { get; set; } = Bc_Azul_Header;
        public static Color Bc_Person_Txt_Normal { get; set; } = Bc_Azul_Txt_Normal;
        public static Color Bc_Person_Txt_Hover { get; set; } = Bc_Azul_Txt_Hover;
        public static Color Bc_Person_Txt_Selected { get; set; } = Bc_Azul_Txt_Selected;
        public static Color Bc_Person_Txt_Disabled { get; set; } = Bc_Azul_Txt_Disabled;
        public static Color Bc_Person_Btn_Normal { get; set; } = Bc_Azul_Btn_Normal;
        public static Color Bc_Person_Btn_Selected { get; set; } = Bc_Azul_Btn_Selected;
        public static Color Bc_Person_Btn_Press { get; set; } = Bc_Azul_Btn_Press;
        public static Color Bc_Person_Btn_Disabled { get; set; } = Bc_Azul_Btn_Disabled;
        public static Color Bc_Person_Dgv_CellNormal { get; set; } = Bc_Azul_Dgv_CellNormal;
        public static Color Bc_Person_Dgv_CellHover { get; set; } = Bc_Azul_Dgv_CellHover;
        public static Color Bc_Person_Dgv_CellSelected { get; set; } = Bc_Azul_Dgv_CellSelected;
        public static Color Bc_Person_Dgv_Header { get; set; } = Bc_Azul_Dgv_Header;

        #endregion

        #region ForeColor

        internal static Color Fr_Claro_Normal => Color.FromArgb(43, 41, 38);
        internal static Color Fr_Claro_Hover => Color.FromArgb(0, 0, 0);
        internal static Color Fr_Claro_Selected => Color.FromArgb(23, 21, 18);
        internal static Color Fr_Claro_Disabled => Color.FromArgb(85, 85, 90);
        internal static Color Fr_Claro_WaterMark => Color.FromArgb(123, 123, 123);

        internal static Color Fr_Escuro_Normal => Color.FromArgb(255, 255, 255);
        internal static Color Fr_Escuro_Hover => Color.FromArgb(205, 205, 235);
        internal static Color Fr_Escuro_Selected => Color.FromArgb(225, 225, 235);
        internal static Color Fr_Escuro_Disabled => Color.FromArgb(129, 129, 129);
        internal static Color Fr_Escuro_WaterMark => Color.FromArgb(95, 95, 95);

        public static Color Fr_Person_Normal { get; set; } = Fr_Claro_Normal;
        public static Color Fr_Person_Hover { get; set; } = Fr_Claro_Hover;
        public static Color Fr_Person_Selected { get; set; } = Fr_Claro_Selected;
        public static Color Fr_Person_Disabled { get; set; } = Fr_Claro_Disabled;
        public static Color Fr_Person_WaterMark { get; set; } = Fr_Claro_WaterMark;

        #endregion

        #region BorderColor

        // Vermelho
        internal static Color Br_Vermelho_Txt_Normal => Color.FromArgb(38, 12, 9);
        internal static Color Br_Vermelho_Txt_Selected => Bc_Vermelho_Btn_Selected;
        internal static Color Br_Vermelho_Txt_Disabled => Color.FromArgb(
            Br_Vermelho_Txt_Normal.R + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.R + 10,
            Br_Vermelho_Txt_Normal.G + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.G + 10,
            Br_Vermelho_Txt_Normal.B + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.B + 10);

        // Lilas
        internal static Color Br_Lilas_Txt_Normal => Color.FromArgb(20, 10, 24);
        internal static Color Br_Lilas_Txt_Selected => Bc_Lilas_Btn_Selected;
        internal static Color Br_Lilas_Txt_Disabled => Color.FromArgb(
            Br_Lilas_Txt_Normal.R + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.R + 10,
            Br_Lilas_Txt_Normal.G + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.G + 10,
            Br_Lilas_Txt_Normal.B + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.B + 10);

        // Azul
        internal static Color Br_Azul_Txt_Normal => Color.FromArgb(5, 19, 27);
        internal static Color Br_Azul_Txt_Selected => Bc_Azul_Btn_Selected;
        internal static Color Br_Azul_Txt_Disabled => Color.FromArgb(
            Br_Azul_Txt_Normal.R + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.R + 10,
            Br_Azul_Txt_Normal.G + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.G + 10,
            Br_Azul_Txt_Normal.B + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.B + 10);

        // Verde
        internal static Color Br_Verde_Txt_Normal => Color.FromArgb(5, 27, 15);
        internal static Color Br_Verde_Txt_Selected => Bc_Verde_Btn_Selected;
        internal static Color Br_Verde_Txt_Disabled => Color.FromArgb(
            Br_Verde_Txt_Normal.R + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.R + 10,
            Br_Verde_Txt_Normal.G + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.G + 10,
            Br_Verde_Txt_Normal.B + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.B + 10);

        // Amarelo
        internal static Color Br_Amarelo_Txt_Normal => Color.FromArgb(20, 16, 1);
        internal static Color Br_Amarelo_Txt_Selected => Bc_Amarelo_Btn_Selected;
        internal static Color Br_Amarelo_Txt_Disabled => Color.FromArgb(
            Br_Amarelo_Txt_Normal.R + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.R + 10,
            Br_Amarelo_Txt_Normal.G + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.G + 10,
            Br_Amarelo_Txt_Normal.B + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.B + 10);

        // Marrom
        internal static Color Br_Marrom_Txt_Normal => Color.FromArgb(36, 15, 0);
        internal static Color Br_Marrom_Txt_Selected => Bc_Marrom_Btn_Selected;
        internal static Color Br_Marrom_Txt_Disabled => Color.FromArgb(
            Br_Marrom_Txt_Normal.R + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.R + 10,
            Br_Marrom_Txt_Normal.G + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.G + 10,
            Br_Marrom_Txt_Normal.B + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.B + 10);

        // Cinza
        internal static Color Br_Cinza_Txt_Normal => Color.FromArgb(21, 23, 23);
        internal static Color Br_Cinza_Txt_Selected => Bc_Cinza_Btn_Selected;
        internal static Color Br_Cinza_Txt_Disabled => Color.FromArgb(
            Br_Cinza_Txt_Normal.R + 10 >= 255 ? 255 : Br_Cinza_Txt_Normal.R + 10,
            Br_Cinza_Txt_Normal.G + 10 >= 255 ? 255 : Br_Cinza_Txt_Normal.G + 10,
            Br_Cinza_Txt_Normal.B + 10 >= 255 ? 255 : Br_Cinza_Txt_Normal.B + 10);

        // Preto
        internal static Color Br_Preto_Txt_Normal => Color.FromArgb(210, 210, 210);
        internal static Color Br_Preto_Txt_Selected => Color.FromArgb(230, 230, 230);
        internal static Color Br_Preto_Txt_Disabled => Color.FromArgb(113, 113, 113);

        // Personalizado
        public static Color Br_Person_Txt_Normal { get; set; } = Br_Azul_Txt_Normal;
        public static Color Br_Person_Txt_Selected { get; set; } = Br_Azul_Txt_Selected;
        public static Color Br_Person_Txt_Disabled { get; set; } = Br_Azul_Txt_Disabled;

        #endregion

    }
}
