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
    [DefaultEvent("Enter")]
    [Designer("LMControls.LmControls.Design.LmGroupBoxDesign")]
    public class LmGroupBox : GroupBox, ILmControl
    {
        #region Construtor

        public LmGroupBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true);

            UpdateLabel();

            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            set
            {
                lmStyleManager = value;
                UpdateLabel();
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

        #region Fields


        private LmLabelSize fontSize = LmLabelSize.Medium;
        [DefaultValue(LmLabelSize.Medium)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmLabelSize FontSize
        {
            get { return fontSize; }
            set
            {
                fontSize = value;
                UpdateLabel();
            }
        }

        private LmLabelWeight fontWeight = LmLabelWeight.Regular;
        [DefaultValue(LmLabelWeight.Regular)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmLabelWeight FontWeight
        {
            get { return fontWeight; }
            set
            {
                fontWeight = value;
                UpdateLabel();
            }
        }

        private string text;
        [Browsable(true)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public override string Text
        {
            get { return text; }
            set { text = value; }
        }


        #endregion

        #region Paint Mathods

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                Color backColor = BackColor;

                if (!useCustomBackColor)
                    backColor = LmPaint.BackColor.Form(Theme);

                /*
                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                    // return;
                }
                */

                base.OnPaintBackground(e);

                OnCustomPaintBackground(new LmPaintEventArgs(backColor, Color.Empty, e.Graphics));

                Color borderColor = Enabled ? LmPaint.BorderColor.Panel.Normal(Theme) : LmPaint.BorderColor.Panel.Disabled(Theme);

                Brush textBrush = new SolidBrush(this.ForeColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = e.Graphics.MeasureString(this.Text, this.Font);
                Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                               this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               this.ClientRectangle.Width - 1,
                                               this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Coloque a cor do background aqui
                e.Graphics.Clear(backColor);

                // Draw text
                e.Graphics.DrawString(this.Text, this.Font, textBrush, this.Padding.Left, 0);

                // Drawing Border
                //Left
                e.Graphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                e.Graphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                e.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                e.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + this.Padding.Left, rect.Y));
                //Top2
                e.Graphics.DrawLine(borderPen, new Point(rect.X + this.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));

            }
            catch
            {
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            try
            {
                if (GetStyle(ControlStyles.AllPaintingInWmPaint))
                {
                    OnPaintBackground(e);
                }

                OnCustomPaint(new LmPaintEventArgs(Color.Empty, Color.Empty, e.Graphics));
            }
            catch
            {
                Invalidate();
            }
        }

        #endregion

        #region  Private Metodos

        private void UpdateLabel()
        {
            this.Font = LmFonts.Label(FontSize, FontWeight);
            this.ForeColor = this.Enabled ? LmPaint.ForeColor.Label.Normal(this.Theme) : LmPaint.ForeColor.Label.Disabled(this.Theme);
        }

        private void DrawBorder(Graphics g)
        {
            Color borderColor = Enabled ? LmPaint.BorderColor.Panel.Normal(Theme) : LmPaint.BorderColor.Panel.Disabled(Theme);

            Brush borderBrush = new SolidBrush(borderColor);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = g.MeasureString(this.Text, this.Font);
            Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                           this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           this.ClientRectangle.Width - 1,
                                           this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Drawing Border
            //Left
            g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + this.Padding.Left, rect.Y));
            //Top2
            g.DrawLine(borderPen, new Point(rect.X + this.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }

        #endregion
    }
}
