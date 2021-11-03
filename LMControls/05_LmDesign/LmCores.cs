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
        internal static Color Bc_Azul_Header => Color.FromArgb(13, 71, 161);
        internal static Color Bc_Azul_Txt_Normal => Color.FromArgb(
            Bc_Azul_Form.R + 10 >= 255 ? 255 : Bc_Azul_Form.R + 10,
            Bc_Azul_Form.G + 10 >= 255 ? 255 : Bc_Azul_Form.G + 10,
            Bc_Azul_Form.B + 10 >= 255 ? 255 : Bc_Azul_Form.B + 10);
        internal static Color Bc_Azul_Txt_Hover => Color.FromArgb(
            Bc_Azul_Form.R - 10 <= 20 ? 25 : Bc_Azul_Form.R - 10,
            Bc_Azul_Form.G - 10 >= 20 ? 25 : Bc_Azul_Form.G - 10,
            Bc_Azul_Form.B - 10 >= 20 ? 25 : Bc_Azul_Form.B - 10);
        internal static Color Bc_Azul_Txt_Selected => Color.FromArgb(
            Bc_Azul_Form.R + 20 >= 255 ? 255 : Bc_Azul_Form.R + 20,
            Bc_Azul_Form.G + 20 >= 255 ? 255 : Bc_Azul_Form.G + 20,
            Bc_Azul_Form.B + 20 >= 255 ? 255 : Bc_Azul_Form.B + 20);
        internal static Color Bc_Azul_Txt_Disabled => Color.FromArgb(
            Bc_Azul_Form.R - 30 <= 20 ? 25 : Bc_Azul_Form.R - 30,
            Bc_Azul_Form.G - 30 >= 20 ? 25 : Bc_Azul_Form.G - 30,
            Bc_Azul_Form.B - 30 >= 20 ? 25 : Bc_Azul_Form.B - 30);
        internal static Color Bc_Azul_Btn_Normal => Color.FromArgb(25, 118, 210);
        internal static Color Bc_Azul_Btn_Selected => Color.FromArgb(13, 71, 161);
        internal static Color Bc_Azul_Btn_Press => Color.FromArgb(144, 202, 249);
        internal static Color Bc_Azul_Btn_Disabled => Color.FromArgb(100, 181, 246);
        internal static Color Bc_Azul_Dgv_CellNormal => Color.FromArgb(187, 222, 251);
        //internal static Color Bc_Azul_Dgv_CellHover => Color.FromArgb(187, 222, 251);
        internal static Color Bc_Azul_Dgv_CellSelected => Color.FromArgb(100, 181, 246);
        internal static Color Bc_Azul_Dgv_Header => Color.FromArgb(33, 150, 243);

        // Vermelho
        internal static Color Bc_Vermelho_Form => Color.FromArgb(255, 235, 238);
        internal static Color Bc_Vermelho_Header => Color.FromArgb(183, 28, 28);
        internal static Color Bc_Vermelho_Txt_Normal => Color.FromArgb(
            Bc_Vermelho_Form.R + 10 >= 255 ? 255 : Bc_Vermelho_Form.R + 10,
            Bc_Vermelho_Form.G + 10 >= 255 ? 255 : Bc_Vermelho_Form.G + 10,
            Bc_Vermelho_Form.B + 10 >= 255 ? 255 : Bc_Vermelho_Form.B + 10);
        internal static Color Bc_Vermelho_Txt_Hover => Color.FromArgb(
            Bc_Vermelho_Form.R - 10 <= 20 ? 25 : Bc_Vermelho_Form.R - 10,
            Bc_Vermelho_Form.G - 10 >= 20 ? 25 : Bc_Vermelho_Form.G - 10,
            Bc_Vermelho_Form.B - 10 >= 20 ? 25 : Bc_Vermelho_Form.B - 10);
        internal static Color Bc_Vermelho_Txt_Selected => Color.FromArgb(
            Bc_Vermelho_Form.R + 20 >= 255 ? 255 : Bc_Vermelho_Form.R + 20,
            Bc_Vermelho_Form.G + 20 >= 255 ? 255 : Bc_Vermelho_Form.G + 20,
            Bc_Vermelho_Form.B + 20 >= 255 ? 255 : Bc_Vermelho_Form.B + 20);
        internal static Color Bc_Vermelho_Txt_Disabled => Color.FromArgb(
            Bc_Vermelho_Form.R - 30 <= 20 ? 25 : Bc_Vermelho_Form.R - 30,
            Bc_Vermelho_Form.G - 30 >= 20 ? 25 : Bc_Vermelho_Form.G - 30,
            Bc_Vermelho_Form.B - 30 >= 20 ? 25 : Bc_Vermelho_Form.B - 30);
        internal static Color Bc_Vermelho_Btn_Normal => Color.FromArgb(211, 47, 47);
        internal static Color Bc_Vermelho_Btn_Selected => Color.FromArgb(183, 28, 28);
        internal static Color Bc_Vermelho_Btn_Press => Color.FromArgb(239, 154, 154);
        internal static Color Bc_Vermelho_Btn_Disabled => Color.FromArgb(229, 115, 115);
        internal static Color Bc_Vermelho_Dgv_CellNormal => Color.FromArgb(255, 205, 210);
        //internal static Color Bc_Vermelho_Dgv_CellHover => Color.FromArgb(239, 154, 154);
        internal static Color Bc_Vermelho_Dgv_CellSelected => Color.FromArgb(229, 115, 115);
        internal static Color Bc_Vermelho_Dgv_Header => Color.FromArgb(244, 67, 54);

        // Lilas
        internal static Color Bc_Lilas_Form => Color.FromArgb(243,229,245);
        internal static Color Bc_Lilas_Header => Color.FromArgb(74, 20, 140);
        internal static Color Bc_Lilas_Txt_Normal => Color.FromArgb(
            Bc_Lilas_Form.R + 10 >= 255 ? 255 : Bc_Lilas_Form.R + 10,
            Bc_Lilas_Form.G + 10 >= 255 ? 255 : Bc_Lilas_Form.G + 10,
            Bc_Lilas_Form.B + 10 >= 255 ? 255 : Bc_Lilas_Form.B + 10);
        internal static Color Bc_Lilas_Txt_Hover => Color.FromArgb(
            Bc_Lilas_Form.R - 10 <= 20 ? 25 : Bc_Lilas_Form.R - 10,
            Bc_Lilas_Form.G - 10 >= 20 ? 25 : Bc_Lilas_Form.G - 10,
            Bc_Lilas_Form.B - 10 >= 20 ? 25 : Bc_Lilas_Form.B - 10);
        internal static Color Bc_Lilas_Txt_Selected => Color.FromArgb(
            Bc_Lilas_Form.R + 20 >= 255 ? 255 : Bc_Lilas_Form.R + 20,
            Bc_Lilas_Form.G + 20 >= 255 ? 255 : Bc_Lilas_Form.G + 20,
            Bc_Lilas_Form.B + 20 >= 255 ? 255 : Bc_Lilas_Form.B + 20);
        internal static Color Bc_Lilas_Txt_Disabled => Color.FromArgb(
            Bc_Lilas_Form.R - 30 <= 20 ? 25 : Bc_Lilas_Form.R - 30,
            Bc_Lilas_Form.G - 30 >= 20 ? 25 : Bc_Lilas_Form.G - 30,
            Bc_Lilas_Form.B - 30 >= 20 ? 25 : Bc_Lilas_Form.B - 30);
        internal static Color Bc_Lilas_Btn_Normal => Color.FromArgb(123, 31, 162);
        internal static Color Bc_Lilas_Btn_Selected => Color.FromArgb(74, 20, 140);
        internal static Color Bc_Lilas_Btn_Press => Color.FromArgb(186, 104, 200);
        internal static Color Bc_Lilas_Btn_Disabled => Color.FromArgb(206, 147, 216);
        internal static Color Bc_Lilas_Dgv_CellNormal => Color.FromArgb(225, 190, 231);
        //internal static Color Bc_Lilas_Dgv_CellHover => Color.FromArgb(206, 147, 216);
        internal static Color Bc_Lilas_Dgv_CellSelected => Color.FromArgb(186, 104, 200);
        internal static Color Bc_Lilas_Dgv_Header => Color.FromArgb(156, 39, 176);

        // Verde
        internal static Color Bc_Verde_Form => Color.FromArgb(232, 245, 233);
        internal static Color Bc_Verde_Header => Color.FromArgb(27, 94, 32);
        internal static Color Bc_Verde_Txt_Normal => Color.FromArgb(
            Bc_Verde_Form.R + 10 >= 255 ? 255 : Bc_Verde_Form.R + 10,
            Bc_Verde_Form.G + 10 >= 255 ? 255 : Bc_Verde_Form.G + 10,
            Bc_Verde_Form.B + 10 >= 255 ? 255 : Bc_Verde_Form.B + 10);
        internal static Color Bc_Verde_Txt_Hover => Color.FromArgb(
            Bc_Verde_Form.R - 10 <= 20 ? 25 : Bc_Verde_Form.R - 10,
            Bc_Verde_Form.G - 10 >= 20 ? 25 : Bc_Verde_Form.G - 10,
            Bc_Verde_Form.B - 10 >= 20 ? 25 : Bc_Verde_Form.B - 10);
        internal static Color Bc_Verde_Txt_Selected => Color.FromArgb(
            Bc_Verde_Form.R + 20 >= 255 ? 255 : Bc_Verde_Form.R + 20,
            Bc_Verde_Form.G + 20 >= 255 ? 255 : Bc_Verde_Form.G + 20,
            Bc_Verde_Form.B + 20 >= 255 ? 255 : Bc_Verde_Form.B + 20);
        internal static Color Bc_Verde_Txt_Disabled => Color.FromArgb(
            Bc_Verde_Form.R - 30 <= 20 ? 25 : Bc_Verde_Form.R - 30,
            Bc_Verde_Form.G - 30 >= 20 ? 25 : Bc_Verde_Form.G - 30,
            Bc_Verde_Form.B - 30 >= 20 ? 25 : Bc_Verde_Form.B - 30);
        internal static Color Bc_Verde_Btn_Normal => Color.FromArgb(56, 142, 60);
        internal static Color Bc_Verde_Btn_Selected => Color.FromArgb(27, 94, 32);
        internal static Color Bc_Verde_Btn_Press => Color.FromArgb(165, 214, 167);
        internal static Color Bc_Verde_Btn_Disabled => Color.FromArgb(129, 199, 132);
        internal static Color Bc_Verde_Dgv_CellNormal => Color.FromArgb(200, 230, 201);
        //internal static Color Bc_Verde_Dgv_CellHover => Color.FromArgb(165, 214, 167);
        internal static Color Bc_Verde_Dgv_CellSelected => Color.FromArgb(129, 199, 132);
        internal static Color Bc_Verde_Dgv_Header => Color.FromArgb(76, 175, 80);

        // Amarelo
        internal static Color Bc_Amarelo_Form => Color.FromArgb(249, 251, 231);
        internal static Color Bc_Amarelo_Header => Color.FromArgb(130, 119, 23);
        internal static Color Bc_Amarelo_Txt_Normal => Color.FromArgb(
            Bc_Amarelo_Form.R + 10 >= 255 ? 255 : Bc_Amarelo_Form.R + 10,
            Bc_Amarelo_Form.G + 10 >= 255 ? 255 : Bc_Amarelo_Form.G + 10,
            Bc_Amarelo_Form.B + 10 >= 255 ? 255 : Bc_Amarelo_Form.B + 10);
        internal static Color Bc_Amarelo_Txt_Hover => Color.FromArgb(
            Bc_Amarelo_Form.R - 10 <= 20 ? 25 : Bc_Amarelo_Form.R - 10,
            Bc_Amarelo_Form.G - 10 >= 20 ? 25 : Bc_Amarelo_Form.G - 10,
            Bc_Amarelo_Form.B - 10 >= 20 ? 25 : Bc_Amarelo_Form.B - 10);
        internal static Color Bc_Amarelo_Txt_Selected => Color.FromArgb(
            Bc_Amarelo_Form.R + 20 >= 255 ? 255 : Bc_Amarelo_Form.R + 20,
            Bc_Amarelo_Form.G + 20 >= 255 ? 255 : Bc_Amarelo_Form.G + 20,
            Bc_Amarelo_Form.B + 20 >= 255 ? 255 : Bc_Amarelo_Form.B + 20);
        internal static Color Bc_Amarelo_Txt_Disabled => Color.FromArgb(
            Bc_Amarelo_Form.R - 30 <= 20 ? 25 : Bc_Amarelo_Form.R - 30,
            Bc_Amarelo_Form.G - 30 >= 20 ? 25 : Bc_Amarelo_Form.G - 30,
            Bc_Amarelo_Form.B - 30 >= 20 ? 25 : Bc_Amarelo_Form.B - 30);
        internal static Color Bc_Amarelo_Btn_Normal => Color.FromArgb(175, 180, 43);
        internal static Color Bc_Amarelo_Btn_Selected => Color.FromArgb(130, 119, 23);
        internal static Color Bc_Amarelo_Btn_Press => Color.FromArgb(230, 238, 156);
        internal static Color Bc_Amarelo_Btn_Disabled => Color.FromArgb(205, 220, 57);
        internal static Color Bc_Amarelo_Dgv_CellNormal => Color.FromArgb(240, 244, 195);
        //internal static Color Bc_Amarelo_Dgv_CellHover => Color.FromArgb(230, 238, 156);
        internal static Color Bc_Amarelo_Dgv_CellSelected => Color.FromArgb(220, 231, 117);
        internal static Color Bc_Amarelo_Dgv_Header => Color.FromArgb(205, 220, 57);

        // Laranja
        internal static Color Bc_Laranja_Form => Color.FromArgb(255, 243, 224);
        internal static Color Bc_Laranja_Header => Color.FromArgb(230, 81, 0);
        internal static Color Bc_Laranja_Txt_Normal => Color.FromArgb(
            Bc_Laranja_Form.R + 10 >= 255 ? 255 : Bc_Laranja_Form.R + 10,
            Bc_Laranja_Form.G + 10 >= 255 ? 255 : Bc_Laranja_Form.G + 10,
            Bc_Laranja_Form.B + 10 >= 255 ? 255 : Bc_Laranja_Form.B + 10);
        internal static Color Bc_Laranja_Txt_Hover => Color.FromArgb(
            Bc_Laranja_Form.R - 10 <= 20 ? 25 : Bc_Laranja_Form.R - 10,
            Bc_Laranja_Form.G - 10 >= 20 ? 25 : Bc_Laranja_Form.G - 10,
            Bc_Laranja_Form.B - 10 >= 20 ? 25 : Bc_Laranja_Form.B - 10);
        internal static Color Bc_Laranja_Txt_Selected => Color.FromArgb(
            Bc_Laranja_Form.R + 20 >= 255 ? 255 : Bc_Laranja_Form.R + 20,
            Bc_Laranja_Form.G + 20 >= 255 ? 255 : Bc_Laranja_Form.G + 20,
            Bc_Laranja_Form.B + 20 >= 255 ? 255 : Bc_Laranja_Form.B + 20);
        internal static Color Bc_Laranja_Txt_Disabled => Color.FromArgb(
            Bc_Laranja_Form.R - 30 <= 20 ? 25 : Bc_Laranja_Form.R - 30,
            Bc_Laranja_Form.G - 30 >= 20 ? 25 : Bc_Laranja_Form.G - 30,
            Bc_Laranja_Form.B - 30 >= 20 ? 25 : Bc_Laranja_Form.B - 30);
        internal static Color Bc_Laranja_Btn_Normal => Color.FromArgb(245, 124, 0);
        internal static Color Bc_Laranja_Btn_Selected => Color.FromArgb(230, 81, 0);
        internal static Color Bc_Laranja_Btn_Press => Color.FromArgb(255, 204, 128);
        internal static Color Bc_Laranja_Btn_Disabled => Color.FromArgb(255, 167, 38);
        internal static Color Bc_Laranja_Dgv_CellNormal => Color.FromArgb(255, 224, 178);
        //internal static Color Bc_Laranja_Dgv_CellHover => Color.FromArgb(255, 204, 128);
        internal static Color Bc_Laranja_Dgv_CellSelected => Color.FromArgb(255, 183, 77);
        internal static Color Bc_Laranja_Dgv_Header => Color.FromArgb(255, 152, 0);

        // Marrom
        internal static Color Bc_Marrom_Form => Color.FromArgb(239, 235, 233);
        internal static Color Bc_Marrom_Header => Color.FromArgb(62, 39, 35);
        internal static Color Bc_Marrom_Txt_Normal => Color.FromArgb(
            Bc_Marrom_Form.R + 10 >= 255 ? 255 : Bc_Marrom_Form.R + 10,
            Bc_Marrom_Form.G + 10 >= 255 ? 255 : Bc_Marrom_Form.G + 10,
            Bc_Marrom_Form.B + 10 >= 255 ? 255 : Bc_Marrom_Form.B + 10);
        internal static Color Bc_Marrom_Txt_Hover => Color.FromArgb(
            Bc_Marrom_Form.R - 10 <= 20 ? 25 : Bc_Marrom_Form.R - 10,
            Bc_Marrom_Form.G - 10 >= 20 ? 25 : Bc_Marrom_Form.G - 10,
            Bc_Marrom_Form.B - 10 >= 20 ? 25 : Bc_Marrom_Form.B - 10);
        internal static Color Bc_Marrom_Txt_Selected => Color.FromArgb(
            Bc_Marrom_Form.R + 20 >= 255 ? 255 : Bc_Marrom_Form.R + 20,
            Bc_Marrom_Form.G + 20 >= 255 ? 255 : Bc_Marrom_Form.G + 20,
            Bc_Marrom_Form.B + 20 >= 255 ? 255 : Bc_Marrom_Form.B + 20);
        internal static Color Bc_Marrom_Txt_Disabled => Color.FromArgb(
            Bc_Marrom_Form.R - 30 <= 20 ? 25 : Bc_Marrom_Form.R - 30,
            Bc_Marrom_Form.G - 30 >= 20 ? 25 : Bc_Marrom_Form.G - 30,
            Bc_Marrom_Form.B - 30 >= 20 ? 25 : Bc_Marrom_Form.B - 30);
        internal static Color Bc_Marrom_Btn_Normal => Color.FromArgb(93, 64, 55);
        internal static Color Bc_Marrom_Btn_Selected => Color.FromArgb(62, 39, 35);
        internal static Color Bc_Marrom_Btn_Press => Color.FromArgb(188, 170, 164);
        internal static Color Bc_Marrom_Btn_Disabled => Color.FromArgb(141, 110, 99);
        internal static Color Bc_Marrom_Dgv_CellNormal => Color.FromArgb(215, 204, 200);
        //internal static Color Bc_Marrom_Dgv_CellHover => Color.FromArgb(188, 170, 164);
        internal static Color Bc_Marrom_Dgv_CellSelected => Color.FromArgb(161, 136, 127);
        internal static Color Bc_Marrom_Dgv_Header => Color.FromArgb(121, 85, 72);

        // Cinza
        internal static Color Bc_Cinza_Form => Color.FromArgb(238, 238, 238);
        internal static Color Bc_Cinza_Header => Color.FromArgb(33, 33, 33);
        internal static Color Bc_Cinza_Txt_Normal => Color.FromArgb(
            Bc_Cinza_Form.R + 10 >= 255 ? 255 : Bc_Cinza_Form.R + 10,
            Bc_Cinza_Form.G + 10 >= 255 ? 255 : Bc_Cinza_Form.G + 10,
            Bc_Cinza_Form.B + 10 >= 255 ? 255 : Bc_Cinza_Form.B + 10);
        internal static Color Bc_Cinza_Txt_Hover => Color.FromArgb(
            Bc_Cinza_Form.R - 10 <= 20 ? 25 : Bc_Cinza_Form.R - 10,
            Bc_Cinza_Form.G - 10 >= 20 ? 25 : Bc_Cinza_Form.G - 10,
            Bc_Cinza_Form.B - 10 >= 20 ? 25 : Bc_Cinza_Form.B - 10);
        internal static Color Bc_Cinza_Txt_Selected => Color.FromArgb(
            Bc_Cinza_Form.R + 20 >= 255 ? 255 : Bc_Cinza_Form.R + 20,
            Bc_Cinza_Form.G + 20 >= 255 ? 255 : Bc_Cinza_Form.G + 20,
            Bc_Cinza_Form.B + 20 >= 255 ? 255 : Bc_Cinza_Form.B + 20);
        internal static Color Bc_Cinza_Txt_Disabled => Color.FromArgb(
            Bc_Cinza_Form.R - 30 <= 20 ? 25 : Bc_Cinza_Form.R - 30,
            Bc_Cinza_Form.G - 30 >= 20 ? 25 : Bc_Cinza_Form.G - 30,
            Bc_Cinza_Form.B - 30 >= 20 ? 25 : Bc_Cinza_Form.B - 30);
        internal static Color Bc_Cinza_Btn_Normal => Color.FromArgb(66, 66, 66);
        internal static Color Bc_Cinza_Btn_Selected => Color.FromArgb(33, 33, 33);
        internal static Color Bc_Cinza_Btn_Press => Color.FromArgb(158, 158, 158);
        internal static Color Bc_Cinza_Btn_Disabled => Color.FromArgb(117, 117, 117);
        internal static Color Bc_Cinza_Dgv_CellNormal => Color.FromArgb(224, 224, 224);
        //internal static Color Bc_Cinza_Dgv_CellHover => Color.FromArgb(189, 189, 189);
        internal static Color Bc_Cinza_Dgv_CellSelected => Color.FromArgb(117, 117, 117);
        internal static Color Bc_Cinza_Dgv_Header => Color.FromArgb(66, 66, 66);

        // Preto
        internal static Color Bc_Preto_Form => Color.FromArgb(82, 82, 88);
        internal static Color Bc_Preto_Header => Color.FromArgb(45, 45, 50);
        internal static Color Bc_Preto_Txt_Normal => Color.FromArgb(65, 65, 65);
        internal static Color Bc_Preto_Txt_Hover => Color.FromArgb(45, 45, 45);
        internal static Color Bc_Preto_Txt_Selected => Color.FromArgb(75, 75, 75);
        internal static Color Bc_Preto_Txt_Disabled => Color.FromArgb(62, 62, 62);
        internal static Color Bc_Preto_Txt_WithError => Color.FromArgb(158, 57, 60);
        internal static Color Bc_Preto_Btn_Normal => Color.FromArgb(104, 93, 94);
        internal static Color Bc_Preto_Btn_Selected => Color.FromArgb(72, 66, 67);
        internal static Color Bc_Preto_Btn_Press => Color.FromArgb(110, 108, 110);
        internal static Color Bc_Preto_Btn_Disabled => Color.FromArgb(169, 169, 169);
        internal static Color Bc_Preto_Dgv_CellNormal => Color.FromArgb(91, 91, 92);
        //internal static Color Bc_Preto_Dgv_CellHover => Color.FromArgb(81, 81, 72);
        internal static Color Bc_Preto_Dgv_CellSelected => Color.FromArgb(53, 53, 55);
        internal static Color Bc_Preto_Dgv_Header => Color.FromArgb(60, 48, 58);

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
        //public static Color Bc_Person_Dgv_CellHover { get; set; } = Bc_Azul_Dgv_CellHover;
        public static Color Bc_Person_Dgv_CellSelected { get; set; } = Bc_Azul_Dgv_CellSelected;
        public static Color Bc_Person_Dgv_Header { get; set; } = Bc_Azul_Dgv_Header;

        #endregion

        #region ForeColor

        internal static Color Fr_Escuro_Normal => Color.FromArgb(43, 41, 38);
        internal static Color Fr_Escuro_Selected => Color.FromArgb(23, 21, 18);
        internal static Color Fr_Escuro_Disabled => Color.FromArgb(85, 85, 90);

        internal static Color Fr_Claro_Normal => Color.FromArgb(255, 255, 255);
        internal static Color Fr_Claro_Selected => Color.FromArgb(225, 225, 235);
        internal static Color Fr_Claro_Disabled => Color.FromArgb(129, 129, 129);

        public static Color Fr_Person_Normal { get; set; } = Fr_Escuro_Normal;
        public static Color Fr_Person_Selected { get; set; } = Fr_Escuro_Selected;
        public static Color Fr_Person_Disabled { get; set; } = Fr_Escuro_Disabled;

        #endregion

        #region BorderColor

        // Azul
        internal static Color Br_Azul_Txt_Normal => Color.FromArgb(2, 13, 30);
        internal static Color Br_Azul_Txt_Selected => Bc_Azul_Btn_Selected;
        internal static Color Br_Azul_Txt_Disabled => Color.FromArgb(
            Br_Azul_Txt_Normal.R + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.R + 10,
            Br_Azul_Txt_Normal.G + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.G + 10,
            Br_Azul_Txt_Normal.B + 10 >= 255 ? 255 : Br_Azul_Txt_Normal.B + 10);

        // Vermelho
        internal static Color Br_Vermelho_Txt_Normal => Color.FromArgb(52, 7, 7);
        internal static Color Br_Vermelho_Txt_Selected => Bc_Vermelho_Btn_Selected;
        internal static Color Br_Vermelho_Txt_Disabled => Color.FromArgb(
            Br_Vermelho_Txt_Normal.R + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.R + 10,
            Br_Vermelho_Txt_Normal.G + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.G + 10,
            Br_Vermelho_Txt_Normal.B + 10 >= 255 ? 255 : Br_Vermelho_Txt_Normal.B + 10);

        // Lilas
        internal static Color Br_Lilas_Txt_Normal => Color.FromArgb(22, 6, 45);
        internal static Color Br_Lilas_Txt_Selected => Bc_Lilas_Btn_Selected;
        internal static Color Br_Lilas_Txt_Disabled => Color.FromArgb(
            Br_Lilas_Txt_Normal.R + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.R + 10,
            Br_Lilas_Txt_Normal.G + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.G + 10,
            Br_Lilas_Txt_Normal.B + 10 >= 255 ? 255 : Br_Lilas_Txt_Normal.B + 10);

        // Verde
        internal static Color Br_Verde_Txt_Normal => Color.FromArgb(10, 31, 13);
        internal static Color Br_Verde_Txt_Selected => Bc_Verde_Btn_Selected;
        internal static Color Br_Verde_Txt_Disabled => Color.FromArgb(
            Br_Verde_Txt_Normal.R + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.R + 10,
            Br_Verde_Txt_Normal.G + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.G + 10,
            Br_Verde_Txt_Normal.B + 10 >= 255 ? 255 : Br_Verde_Txt_Normal.B + 10);

        // Amarelo
        internal static Color Br_Amarelo_Txt_Normal => Color.FromArgb(38, 35, 6);
        internal static Color Br_Amarelo_Txt_Selected => Bc_Amarelo_Btn_Selected;
        internal static Color Br_Amarelo_Txt_Disabled => Color.FromArgb(
            Br_Amarelo_Txt_Normal.R + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.R + 10,
            Br_Amarelo_Txt_Normal.G + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.G + 10,
            Br_Amarelo_Txt_Normal.B + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.B + 10);

        // Laranja
        internal static Color Br_Laranja_Txt_Normal => Color.FromArgb(47, 16, 0);
        internal static Color Br_Laranja_Txt_Selected => Bc_Laranja_Btn_Selected;
        internal static Color Br_Laranja_Txt_Disabled => Color.FromArgb(
            Br_Laranja_Txt_Normal.R + 10 >= 255 ? 255 : Br_Laranja_Txt_Normal.R + 10,
            Br_Laranja_Txt_Normal.G + 10 >= 255 ? 255 : Br_Laranja_Txt_Normal.G + 10,
            Br_Amarelo_Txt_Normal.B + 10 >= 255 ? 255 : Br_Amarelo_Txt_Normal.B + 10);

        // Marrom
        internal static Color Br_Marrom_Txt_Normal => Color.FromArgb(30, 19, 17);
        internal static Color Br_Marrom_Txt_Selected => Bc_Marrom_Btn_Selected;
        internal static Color Br_Marrom_Txt_Disabled => Color.FromArgb(
            Br_Marrom_Txt_Normal.R + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.R + 10,
            Br_Marrom_Txt_Normal.G + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.G + 10,
            Br_Marrom_Txt_Normal.B + 10 >= 255 ? 255 : Br_Marrom_Txt_Normal.B + 10);

        // Cinza
        internal static Color Br_Cinza_Txt_Normal => Color.FromArgb(20, 20, 20);
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
