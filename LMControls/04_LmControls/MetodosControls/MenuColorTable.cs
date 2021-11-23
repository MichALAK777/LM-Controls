using LMControls.LmDesign;
using System.Drawing;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    public class MenuColorTable : ProfessionalColorTable
    {
        //Fields
        private Color backColor;
        private Color imageColorBegin;
        private Color imageColorMidle;
        private Color imageColorEnd;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        //Constructor
        public MenuColorTable(LmTheme lmTheme)
        {
            backColor =  LmPaint.BackColor.MenuStrip.MenuSubItemNormal(lmTheme);
            menuItemSelectedColor =  LmPaint.BackColor.MenuStrip.MenuSubItemSelected(lmTheme);
            borderColor = LmPaint.BackColor.FormHeader(lmTheme);

            imageColorBegin = LmPaint.BackColor.MenuStrip.ImageMarginGradientBegin(lmTheme);
            imageColorMidle = LmPaint.BackColor.MenuStrip.ImageMarginGradientMiddle(lmTheme);
            imageColorEnd =  LmPaint.BackColor.MenuStrip.ImageMarginGradientEnd(lmTheme);

            menuItemBorderColor = LmPaint.BackColor.MenuStrip.MenuSubItemSelected(lmTheme);
        }

        //Overrides
        public override Color ToolStripDropDownBackground { get { return backColor; } }
        public override Color MenuBorder { get { return borderColor; } }
        public override Color MenuItemBorder { get { return menuItemBorderColor; } }
        public override Color MenuItemSelectedGradientBegin { get { return menuItemSelectedColor; } }
        public override Color MenuItemSelectedGradientEnd { get { return menuItemSelectedColor; } }
        public override Color ImageMarginGradientBegin { get { return imageColorBegin; } }
        public override Color ImageMarginGradientMiddle { get { return imageColorMidle; } }
        public override Color ImageMarginGradientEnd { get { return imageColorEnd; } }
    }
}