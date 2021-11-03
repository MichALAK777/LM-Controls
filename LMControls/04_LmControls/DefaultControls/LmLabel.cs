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
    [DefaultEvent("Click")]
    [Designer("LMControls.LmControls.Design.LmLabelDesign")]
    public partial class LmLabel : Label, ILmControl
    {
        #region Construtor

        public LmLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true);

            Margin = new Padding(3);
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
            set { lmTheme = value; }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set { lmStyleManager = value; }
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

        private bool useStyleColors = false;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseStyleColors
        {
            get { return useStyleColors; }
            set { useStyleColors = value; }
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

        #region Campos

        private LmLabelSize lmLabelSize = LmLabelSize.Medium;
        [DefaultValue(LmLabelSize.Medium)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmLabelSize FontSize
        {
            get { return lmLabelSize; }
            set { lmLabelSize = value; Refresh(); }
        }

        private LmLabelWeight lmLabelWeight = LmLabelWeight.Regular;
        [DefaultValue(LmLabelWeight.Regular)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmLabelWeight FontWeight
        {
            get { return lmLabelWeight; }
            set { lmLabelWeight = value; Refresh(); }
        }

        private bool wrapToLine;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool WrapToLine
        {
            get { return wrapToLine; }
            set { wrapToLine = value; Refresh(); }
        }

        private bool isLink;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool IsLink
        {
            get { return isLink; }
            set
            {
                isLink = value;
                Cursor = isLink ? Cursors.Hand : Cursors.Default;
            }
        }

        #endregion

        #region Paint Methods

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                Color backColor = BackColor;

                if (!UseCustomBackColor)
                    backColor = Color.Transparent;

                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                    return;
                }

                base.OnPaintBackground(e);

                OnCustomPaintBackground(new LmPaintEventArgs(backColor, Color.Empty, e.Graphics));
            }
            catch
            {
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (GetStyle(ControlStyles.AllPaintingInWmPaint))
                {
                    OnPaintBackground(e);
                }

                OnCustomPaint(new LmPaintEventArgs(Color.Empty, Color.Empty, e.Graphics));
                OnPaintForeground(e);
            }
            catch
            {
                Invalidate();
            }
        }

        protected virtual void OnPaintForeground(PaintEventArgs e)
        {
            Color foreColor;

            if (IsLink)
            {
                foreColor = Theme == LmTheme.Preto ? Color.FromArgb(70, 110, 255) : Color.FromArgb(0, 0, 210);
            }
            else if (useCustomForeColor)
            {
                foreColor = ForeColor;
            }
            else
            {
                if (!Enabled)
                {
                    if (Parent != null)
                    {
                        foreColor = LmPaint.ForeColor.Label.Disabled(Theme);
                    }
                    else
                    {
                        foreColor = LmPaint.ForeColor.Label.Disabled(Theme);
                    }
                }
                else
                {
                    if (Parent != null)
                    {
                        foreColor = LmPaint.ForeColor.Label.Normal(Theme);
                    }
                    else
                        foreColor = LmPaint.ForeColor.Label.Normal(Theme);
                }
            }

            TextRenderer.DrawText(e.Graphics, Text, LmFonts.Label(lmLabelSize, lmLabelWeight, IsLink), ClientRectangle, foreColor, LmPaint.GetTextFormatFlags(TextAlign, wrapToLine));
            OnCustomPaintForeground(new LmPaintEventArgs(Color.Empty, foreColor, e.Graphics));
        }

        #endregion

        #region Overridden Methods

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size preferredSize;
            base.GetPreferredSize(proposedSize);

            using (var g = CreateGraphics())
            {
                proposedSize = new Size(int.MaxValue, int.MaxValue);
                preferredSize = TextRenderer.MeasureText(g, Text, LmFonts.Label(lmLabelSize, lmLabelWeight), proposedSize, LmPaint.GetTextFormatFlags(TextAlign));
            }

            return preferredSize;
        }

        #endregion
    }
}
