using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmDesign
{
    public class LmPaintEventArgs : EventArgs
    {
        public Color BackColor { get; private set; }
        public Color ForeColor { get; private set; }
        public Graphics Graphics { get; private set; }

        public LmPaintEventArgs(Color backColor, Color foreColor, Graphics g)
        {
            BackColor = backColor;
            ForeColor = foreColor;
            Graphics = g;
        }
    }

    public sealed class LmPaint
    {
        public sealed class BackColor
        {
            public static Color Form(LmTheme Theme)
            {
                Color defaultColor = LmCores.Bc_Azul_Form;
                switch (Theme)
                {
                    case LmTheme.Laranja: return LmCores.Bc_Laranja_Form;
                    case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Form;
                    case LmTheme.Marrom: return LmCores.Bc_Marrom_Form;
                    case LmTheme.Lilas: return LmCores.Bc_Marrom_Form;
                    case LmTheme.Azul: return LmCores.Bc_Azul_Form;
                    case LmTheme.Verde: return LmCores.Bc_Verde_Form;
                    case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Form;
                    case LmTheme.Cinza: return LmCores.Bc_Cinza_Form;
                    case LmTheme.Preto: return LmCores.Bc_Preto_Form;
                    case LmTheme.Personalizado: return LmCores.Bc_Person_Form;
                    default: return defaultColor;
                }
            }

            public static Color FormHeader(LmTheme Theme)
            {
                Color defaultColor = LmCores.Bc_Azul_Header;
                switch (Theme)
                {
                    case LmTheme.Laranja: return LmCores.Bc_Laranja_Header;
                    case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Header;
                    case LmTheme.Marrom: return LmCores.Bc_Marrom_Header;
                    case LmTheme.Lilas: return LmCores.Bc_Lilas_Header;
                    case LmTheme.Azul: return LmCores.Bc_Azul_Header;
                    case LmTheme.Verde: return LmCores.Bc_Verde_Header;
                    case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Header;
                    case LmTheme.Cinza: return LmCores.Bc_Cinza_Header;
                    case LmTheme.Preto: return LmCores.Bc_Preto_Header;
                    case LmTheme.Personalizado: return LmCores.Bc_Person_Header;
                    default: return defaultColor;
                }
            }

            public class TextBox
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Hover(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Hover;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Hover;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Hover;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Hover;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Hover;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Hover;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Hover;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Hover;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Hover;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Hover;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Hover;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class Button
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Normal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Normal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Normal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Normal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Normal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Normal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Normal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Normal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Normal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Selected;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Selected;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Selected;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Selected;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Selected;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Selected;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Selected;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Selected;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Selected;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Press(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Press;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Press;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Press;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Press;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Press;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Press;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Press;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Press;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Press;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Press;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Press;
                        default: return defaultColor;
                    }

                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class TabControl
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class GridView
            {
                public static Color CellNormal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_CellNormal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_CellNormal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_CellNormal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_CellNormal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_CellNormal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_CellNormal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_CellNormal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_CellNormal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_CellNormal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_CellNormal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_CellNormal;
                        default: return defaultColor;
                    }
                }

                public static Color CellSelected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_CellSelected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_CellSelected;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_CellSelected;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_CellSelected;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_CellSelected;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_CellSelected;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_CellSelected;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_CellSelected;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_CellSelected;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_CellSelected;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_CellSelected;
                        default: return defaultColor;
                    }
                }

                public static Color Header(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_Header;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_Header;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_Header;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_Header;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_Header;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_Header;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_Header;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_Header;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_Header;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_Header;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_Header;
                        default: return defaultColor;
                    }
                }
            }

            public class Toggle
            {
                public static Color OnBackColorAtivo(LmTheme Theme) 
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Azul_Btn_Normal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Normal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Normal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Normal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Normal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Normal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Normal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Normal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Normal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color OnBackColorInativo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Disabled;
                        default: return defaultColor;
                    }
                }

                public static Color OnToggleColorAtivo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Hover;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Hover;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Hover;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Hover;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Hover;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Hover;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Hover;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Hover;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Hover;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Hover;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Hover;
                        default: return defaultColor;
                    }
                }

                public static Color OnToggleColorInativo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }

                public static Color OffBackColorAtivo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Hover;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Hover;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Hover;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Hover;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Hover;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Hover;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Hover;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Hover;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Hover;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Hover;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Hover;
                        default: return defaultColor;
                    }
                }

                public static Color OffBackColorInativo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }

                public static Color OffToggleColorAtivo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Normal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Normal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Normal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Normal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Normal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Normal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Normal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Normal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Normal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color OffToggleColorInativo(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Btn_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Btn_Disabled;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Btn_Disabled;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Btn_Disabled;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Btn_Disabled;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Btn_Disabled;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Btn_Disabled;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Btn_Disabled;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Btn_Disabled;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Btn_Disabled;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Btn_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class MenuStrip
            {
                public static Color MenuPrincipalNormal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Header;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Header;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Header;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Header;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Header;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Header;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Header;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Header;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Header;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Header;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Header;
                        default: return defaultColor;
                    }

                }

                public static Color MenuSubItemSelected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Form;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Form;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Form;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Form;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Form;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Form;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Form;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Form;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Form;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Form;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Form;
                        default: return defaultColor;
                    }

                }

                public static Color ImageMarginGradientBegin(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_Header;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_Header;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_Header;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_Header;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_Header;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_Header;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_Header;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_Header;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_Header;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_Header;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_Header;
                        default: return defaultColor;
                    }
                }

                public static Color ImageMarginGradientMiddle(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_CellSelected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_CellSelected;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_CellSelected;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_CellSelected;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_CellSelected;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_CellSelected;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_CellSelected;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_CellSelected;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_CellSelected;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_CellSelected;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_CellSelected;
                        default: return defaultColor;
                    }
                }

                public static Color ImageMarginGradientEnd(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Dgv_CellNormal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Dgv_CellNormal;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Dgv_CellNormal;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Dgv_CellNormal;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Dgv_CellNormal;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Dgv_CellNormal;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Dgv_CellNormal;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Dgv_CellNormal;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Dgv_CellNormal;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Dgv_CellNormal;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Dgv_CellNormal;
                        default: return defaultColor;
                    }
                }

            }

            public sealed class MenuJanelaAberta
            {
                public static Color JanelaAberta(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Bc_Azul_Header;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Bc_Laranja_Header;
                        case LmTheme.Vermelho: return LmCores.Bc_Vermelho_Header;
                        case LmTheme.Marrom: return LmCores.Bc_Marrom_Header;
                        case LmTheme.Lilas: return LmCores.Bc_Lilas_Header;
                        case LmTheme.Azul: return LmCores.Bc_Azul_Header;
                        case LmTheme.Verde: return LmCores.Bc_Verde_Header;
                        case LmTheme.Amarelo: return LmCores.Bc_Amarelo_Header;
                        case LmTheme.Cinza: return LmCores.Bc_Cinza_Header;
                        case LmTheme.Preto: return LmCores.Bc_Preto_Header;
                        case LmTheme.Personalizado: return LmCores.Bc_Person_Header;
                        default: return defaultColor;
                    }

                }

            }
        }

        public sealed class ForeColor
        {
            public sealed class Label
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Disabled;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class Link
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Press(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Selected;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Disabled;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class TextBox
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Selected;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Disabled;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class Button
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Selected;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Press(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Selected;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Disabled;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Disabled;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class TabControl
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class GridView
            {
                public static Color CellNormal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color CellSelected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Selected;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Selected;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Header(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class MenuStrip
            {
                public static Color MenuStripForeColor(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Fr_Escuro_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Vermelho: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Marrom: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Lilas: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Azul: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Verde: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Amarelo: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Cinza: return LmCores.Fr_Escuro_Normal;
                        case LmTheme.Preto: return LmCores.Fr_Claro_Normal;
                        case LmTheme.Personalizado: return LmCores.Fr_Person_Normal;
                        default: return defaultColor;
                    }
                }
            }
        }

        public sealed class BorderColor
        {
            public static class TextBox
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public static class Button
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Cinza_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public static class Panel
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Cinza_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public static class TabControl
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }
            }

            public class Toggle
            {
                public static Color Normal(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Normal;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Normal;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Normal;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Normal;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Normal;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Normal;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Normal;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Normal;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Normal;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Normal;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Normal;
                        default: return defaultColor;
                    }
                }

                public static Color Hover(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Selected(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Disabled(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Disabled;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Disabled;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Disabled;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Disabled;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Disabled;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Disabled;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Disabled;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Disabled;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Disabled;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Disabled;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Disabled;
                        default: return defaultColor;
                    }
                }
            }

            public sealed class MenuStrip
            {
                public static Color MenuItem(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }

                public static Color Menu(LmTheme Theme)
                {
                    Color defaultColor = LmCores.Br_Azul_Txt_Selected;
                    switch (Theme)
                    {
                        case LmTheme.Laranja: return LmCores.Br_Laranja_Txt_Selected;
                        case LmTheme.Vermelho: return LmCores.Br_Vermelho_Txt_Selected;
                        case LmTheme.Marrom: return LmCores.Br_Marrom_Txt_Selected;
                        case LmTheme.Lilas: return LmCores.Br_Lilas_Txt_Selected;
                        case LmTheme.Azul: return LmCores.Br_Azul_Txt_Selected;
                        case LmTheme.Verde: return LmCores.Br_Verde_Txt_Selected;
                        case LmTheme.Amarelo: return LmCores.Br_Amarelo_Txt_Selected;
                        case LmTheme.Cinza: return LmCores.Br_Cinza_Txt_Selected;
                        case LmTheme.Preto: return LmCores.Br_Preto_Txt_Selected;
                        case LmTheme.Personalizado: return LmCores.Br_Person_Txt_Selected;
                        default: return defaultColor;
                    }
                }
            }
        }

        #region Helper Methods

        public static TextFormatFlags GetTextFormatFlags(ContentAlignment textAlign)
        {
            return GetTextFormatFlags(textAlign, false);
        }

        public static TextFormatFlags GetTextFormatFlags(ContentAlignment textAlign, bool WrapToLine)
        {
            TextFormatFlags controlFlags = TextFormatFlags.Default;

            switch (WrapToLine)
            {
                case true:
                    controlFlags = TextFormatFlags.WordBreak;
                    break;
                case false:
                    controlFlags = TextFormatFlags.EndEllipsis;
                    break;
            }
            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.Left;
                    break;
                case ContentAlignment.TopCenter:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.TopRight:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.Right;
                    break;

                case ContentAlignment.MiddleLeft:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                    break;
                case ContentAlignment.MiddleCenter:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.MiddleRight:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                    break;

                case ContentAlignment.BottomLeft:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.Left;
                    break;
                case ContentAlignment.BottomCenter:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.BottomRight:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.Right;
                    break;
            }

            return controlFlags;
        }

        #endregion
    }
}
