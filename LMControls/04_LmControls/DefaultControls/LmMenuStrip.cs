using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [DefaultEvent("ItemClicked")]
    public partial class LmMenuStrip : MenuStrip, ILmControl
    {
        #region Construtor

        public LmMenuStrip()
        {
            Font = new Font("Arial", 9.75F);

            CustomMenuStripColorTable customColors = new CustomMenuStripColorTable(Theme);

            this.RenderMode = ToolStripRenderMode.Professional;
            this.Renderer = new ToolStripProfessionalRenderer(customColors);

            this.BackColor = customColors.MenuStripGradientBegin;
        }

        #endregion

        #region Interface

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaintBackground;
        protected virtual void OnCustomPaintBackground(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaintBackground != null)
            {
                CustomPaintBackground(this, e);
            }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaint;
        protected virtual void OnCustomPaint(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaint != null)
            {
                CustomPaint(this, e);
            }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaintForeground;
        protected virtual void OnCustomPaintForeground(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaintForeground != null)
            {
                CustomPaintForeground(this, e);
            }
        }

        private LmTheme lmTheme = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(LmTheme.Padrao)]
        public LmTheme Theme
        {
            get
            {
                if (DesignMode || lmTheme != LmTheme.Padrao)
                {
                    return lmTheme;
                }

                if (StyleManager != null && lmTheme == LmTheme.Padrao)
                {
                    return StyleManager.Theme;
                }
                if (StyleManager == null && lmTheme == LmTheme.Padrao)
                {
                    return LmDefault.Theme;
                }

                return lmTheme;
            }
            set
            {
                lmTheme = value;
            }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set
            {
                lmStyleManager = value;

                CustomMenuStripColorTable customColors = new CustomMenuStripColorTable(Theme);

                this.RenderMode = ToolStripRenderMode.Professional;
                this.Renderer = new ToolStripProfessionalRenderer(customColors);

                this.BackColor = customColors.MenuStripGradientBegin;

            }
        }

        private bool useCustomBackColor = false;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseCustomBackColor
        {
            get { return useCustomBackColor; }
            set { useCustomBackColor = value; }
        }

        private bool useCustomForeColor = false;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseCustomForeColor
        {
            get { return useCustomForeColor; }
            set { useCustomForeColor = value; }
        }

        [Browsable(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(false)]
        public bool UseSelectable
        {
            get { return GetStyle(ControlStyles.Selectable); }
            set { SetStyle(ControlStyles.Selectable, value); }
        }

        #endregion

        #region Paint Method

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        #endregion

        #region Custom Table Colors

        [ToolboxItem(false)]
        public class CustomMenuStripColorTable : ProfessionalColorTable
        {
            LmTheme _Theme = new LmTheme();

            public CustomMenuStripColorTable(LmTheme lmTheme) => _Theme = lmTheme;

            /// <summary>
            /// Gets the start color of the gradient used in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuStripGradientBegin => LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(_Theme);

            /// <summary>
            /// Gets the end color of the gradient used in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuStripGradientEnd => LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(_Theme);

            /// <summary>
            /// Gets the start color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemPressedGradientBegin => LmPaint.BackColor.Form(_Theme);

            /// <summary>
            /// Gets the middle color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemPressedGradientMiddle => LmPaint.BackColor.Form(_Theme);

            /// <summary>
            /// Gets the end color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemPressedGradientEnd => LmPaint.BackColor.Form(_Theme);

            /// <summary>
            /// Gets the start color of the gradient used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemSelectedGradientBegin => LmPaint.BackColor.Form(_Theme);

            /// <summary>
            /// Gets the end color of the gradient used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemSelectedGradientEnd => LmPaint.BackColor.Form(_Theme);

            /// <summary>
            /// Gets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemSelected => LmPaint.BackColor.MenuStrip.MenuSubItemSelected(_Theme);

            /// <summary>
            /// Gets the color used for the menu border in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuBorder => LmPaint.BorderColor.MenuStrip.Menu(_Theme);

            /// <summary>
            /// Gets the color used for the menu item border in the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color MenuItemBorder => LmPaint.BorderColor.MenuStrip.MenuItem(_Theme);

            /// <summary>
            /// Gets the starting color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color ImageMarginGradientBegin => LmPaint.BackColor.MenuStrip.ImageMarginGradientBegin(_Theme);

            /// <summary>
            /// Gets the middle color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color ImageMarginGradientMiddle => LmPaint.BackColor.MenuStrip.ImageMarginGradientMiddle(_Theme);

            /// <summary>
            /// Gets the ending color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
            /// </summary>
            public override Color ImageMarginGradientEnd => LmPaint.BackColor.MenuStrip.ImageMarginGradientEnd(_Theme);

            public override Color ToolStripContentPanelGradientBegin => Color.DarkGoldenrod;
            public override Color ToolStripContentPanelGradientEnd => Color.DarkSalmon;

        }


        #endregion

    }
}
