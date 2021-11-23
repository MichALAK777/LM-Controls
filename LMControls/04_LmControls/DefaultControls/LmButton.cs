using FontAwesome.Sharp;
using LMControls.Components;
using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [DefaultEvent("Click")]
    //[Designer(typeof(LmControls.Design.LmButtonDesign))]
    public class LmButton : IconButton
    {
        private bool isHovered = false;
        private bool isPressed = false;
        private bool isFocused = false;

        private Font _default = new Font("Segoe UI", 8F, FontStyle.Bold);

        public LmButton()
        {
            Font = _default;
            this.Size = new Size(110, 30);
            AplicarStilo();
        }

        #region Interface

        private LmTheme lmTheme = LmTheme.Padrao;
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

                AplicarStilo();
            }
        }

        #endregion

        #region Fields

        private int borderSize = 0;

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        private int borderRadius = 15;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;

                if (borderRadius > Height / 2)
                    borderRadius = Height / 2;

                this.Invalidate();
            }
        }

        private Color borderColor = Color.PaleVioletRed;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        #endregion

        #region Paint Methods

        private void AplicarStilo()
        {
            Font = _default;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Enabled ? LmPaint.BackColor.Button.Normal(Theme) : LmPaint.BackColor.Button.Disabled(Theme);
            this.FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Normal(Theme);
            this.FlatAppearance.MouseDownBackColor = LmPaint.BackColor.Button.Press(Theme);
            this.FlatAppearance.MouseOverBackColor = LmPaint.BackColor.Button.Selected(Theme);
            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Normal);
           

            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        #endregion

        #region Override Metodos

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;

            this.BackColor = Enabled
                ? LmPaint.BackColor.Button.Selected(Theme)
                : LmPaint.BackColor.Button.Disabled(Theme);
            this.ForeColor = this.IconColor = Enabled
                ? this.BackColor.GetForeColor(LmControlStatus.Selected)
                : this.BackColor.GetForeColor(LmControlStatus.Disabled);

            Invalidate();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!isFocused)
                isHovered = false;

            this.BackColor =
               Enabled
               ? isFocused ? LmPaint.BackColor.Button.Selected(Theme)
               : LmPaint.BackColor.Button.Normal(Theme)
               : LmPaint.BackColor.Button.Disabled(Theme);

            this.ForeColor = this.IconColor = Enabled
                ? isFocused ? this.BackColor.GetForeColor(LmControlStatus.Selected)
                : this.BackColor.GetForeColor(LmControlStatus.Normal)
                : this.BackColor.GetForeColor(LmControlStatus.Disabled);

            Invalidate();

            Font = _default;
            GC.Collect();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isPressed = false;
            Invalidate();

            GC.Collect();
            base.OnMouseUp(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (Enabled)
            {
                FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Normal(Theme);
                this.BackColor = LmPaint.BackColor.Button.Normal(Theme);
            }
            else
            {
                FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Disabled(Theme);
                this.BackColor = LmPaint.BackColor.Button.Disabled(Theme);
            }

            Invalidate();

            //ColorIcon();

            GC.Collect();
            base.OnEnabledChanged(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            isFocused = true;
            isHovered = true;
            this.SetLastFocusedControl();

            FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Selected(Theme);
            this.BackColor = LmPaint.BackColor.Button.Selected(Theme);
            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Selected);

            Invalidate();

            //ColorIcon();

            GC.Collect();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            isFocused = false;
            isHovered = false;
            isPressed = false;

            FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Normal(Theme);
            this.BackColor = LmPaint.BackColor.Button.Normal(Theme);
            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Normal);

            Invalidate();

            //ColorIcon();

            GC.Collect();
            base.OnLostFocus(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        #endregion

        #region Metodos

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        #endregion

        #region Events

        //private void Button_Resize(object sender, EventArgs e)
        //{
        //    if (borderRadius > this.Height / 2)
        //        borderRadius = this.Height / 2;
        //}

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion

    }
}
