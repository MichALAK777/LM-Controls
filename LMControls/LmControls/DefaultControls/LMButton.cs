using LMControls.Interfaces;
using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [ToolboxBitmap(typeof(Button))]
    [DefaultEvent("Click")]
    [Designer("LMControls.LmControls.Design.LmButtonDesign")]
    public class LMButton : Button, ILmControl
    {
        private bool isHovered = false;
        private bool isPressed = false;
        private bool isFocused = false;

        private Font _default = new Font("Segoe UI", 8F, FontStyle.Bold);

        public LMButton()
        {
            this.Resize += new EventHandler(Button_Resize);

            AplicarStilo();
            //System.Threading.Thread t = new System.Threading.Thread(() => { AplicarStilo(); }) { IsBackground = true };
            //t.Start();
        }

        private void AplicarStilo()
        {
            Font = _default;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(110, 30);
            this.BackColor = WinTheme.LightColor;
            this.FlatAppearance.BorderColor = WinTheme.ThemeColor;
            //this.BackColor = Color.MediumSlateBlue;
            //this.ForeColor = Color.White;
            this.FlatAppearance.BorderColor = Enabled ? WinTheme.ThemeColor : WinTheme.LightColor;
            this.FlatAppearance.MouseDownBackColor = WinTheme.LightColor;
            this.FlatAppearance.MouseOverBackColor = WinTheme.ThemeColor;

            this.Refresh();
        }

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

        private bool useCustomBackColor = false;
        [DefaultValue(true)]
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

        #region Fields

        private bool useCustomIconColor = false;
        [DefaultValue(true)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseCustomIconColor
        {
            get { return useCustomIconColor; }
            set { useCustomIconColor = value; }
        }

        private int borderSize = 0;
        [Category(LmDefault.PropertyCategory.LmUI)]
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
        [Category(LmDefault.PropertyCategory.LmUI)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        private Color borderColor = Color.PaleVioletRed;
        [Category(LmDefault.PropertyCategory.LmUI)]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion

        #region Paint Methods

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            WinTheme.LoadTheme();

            //this.BackgroundColor = Enabled
            //    ? !isFocused ? WinTheme.LightColor : WinTheme.ThemeColor
            //    : WinTheme.LightLightColor;
            //this.TextColor = Enabled
            //    ? BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal
            //    : BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Disabled : WinTheme.Fr_Preto_Disabled;

            //this.FlatAppearance.BorderColor = !isFocused ? WinTheme.ThemeColor : WinTheme.DarkColor;

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

        #region Override Metodos

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;

            this.BackgroundColor = WinTheme.ThemeColor;
            this.FlatAppearance.BorderColor = WinTheme.DarkColor;
            this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;

            Invalidate();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!isFocused)
                isHovered = false;

            this.BackgroundColor = !isFocused ? WinTheme.LightColor : WinTheme.ThemeColor;
            this.FlatAppearance.BorderColor = !isFocused ? WinTheme.ThemeColor : WinTheme.DarkColor;
            this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;

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

            //FlatAppearance.BorderColor = LmPaint.BorderColor.Button.Hover(Theme);
            GC.Collect();
            base.OnMouseUp(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (Enabled)
            {
                this.BackgroundColor = WinTheme.LightColor;
                this.FlatAppearance.BorderColor = WinTheme.ThemeColor;
                this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;
            }
            else
            {
                this.BackgroundColor = WinTheme.LightLightColor;
                this.FlatAppearance.BorderColor = WinTheme.LightColor;
                this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;
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

            this.BackgroundColor = WinTheme.ThemeColor;
            this.FlatAppearance.BorderColor = WinTheme.DarkColor;
            this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;

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

            this.BackgroundColor = WinTheme.LightColor;
            this.FlatAppearance.BorderColor = WinTheme.ThemeColor;
            this.TextColor = BackgroundColor.IsDarkColor() ? WinTheme.Fr_Branco_Normal : WinTheme.Fr_Preto_Normal;

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

        #region Events

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
