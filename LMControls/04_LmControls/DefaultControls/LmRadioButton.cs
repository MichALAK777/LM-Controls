using LMControls.Components;
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
    [DefaultEvent("CheckedChanged")]
    [Designer(typeof(LmControls.Design.LmRadioButtonDesign))]
    public partial class LmRadioButton : RadioButton, ILmControl
    {
        #region Construtor

        public LmRadioButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.UserPaint, true);
        }

        #endregion

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

        #endregion

        #region Fields

        private bool displayFocusRectangle = false;
        [DefaultValue(false)]

        public bool DisplayFocus
        {
            get { return displayFocusRectangle; }
            set { displayFocusRectangle = value; }
        }

        private LmCheckBoxSize lmCheckBoxSize = LmCheckBoxSize.Small;
        [DefaultValue(LmCheckBoxSize.Small)]

        public LmCheckBoxSize FontSize
        {
            get { return lmCheckBoxSize; }
            set { lmCheckBoxSize = value; }
        }

        private LmCheckBoxWeight lmCheckBoxWeight = LmCheckBoxWeight.Regular;
        [DefaultValue(LmCheckBoxWeight.Regular)]

        public LmCheckBoxWeight FontWeight
        {
            get { return lmCheckBoxWeight; }
            set { lmCheckBoxWeight = value; }
        }

        [Browsable(false)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }

        private bool isHovered = false;
        private bool isPressed = false;
        private bool isFocused = false;

        #endregion

        #region Paint Methods

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                Color backColor = backColor = LmPaint.BackColor.Form(Theme);

                if (backColor.A == 255)
                {
                    e.Graphics.Clear(backColor);
                    return;
                }

                base.OnPaintBackground(e);

                // OnCustomPaintBackground(new LmPaintEventArgs(backColor, Color.Empty, e.Graphics));
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

                // OnCustomPaint(new LmPaintEventArgs(Color.Empty, Color.Empty, e.Graphics));
                OnPaintForeground(e);
            }
            catch
            {
                Invalidate();
            }
        }

        protected virtual void OnPaintForeground(PaintEventArgs e)
        {
            Color borderColor, foreColor;

            if (isHovered && !isPressed && Enabled)
            {
                foreColor = BackColor.GetForeColor(LmControlStatus.Selected);
                borderColor = LmPaint.BorderColor.TextBox.Selected(Theme);
            }
            else if (isHovered && isPressed && Enabled)
            {
                foreColor = BackColor.GetForeColor(LmControlStatus.Selected);
                borderColor = LmPaint.BorderColor.TextBox.Selected(Theme);
            }
            else if (!Enabled)
            {
                foreColor = BackColor.GetForeColor(LmControlStatus.Disabled);
                borderColor = LmPaint.BorderColor.TextBox.Disabled(Theme);
            }
            else
            {
                foreColor = BackColor.GetForeColor(LmControlStatus.Normal);
                borderColor = LmPaint.BorderColor.TextBox.Normal(Theme);
            }

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (Pen p = new Pen(borderColor))
            {
                Rectangle boxRect = new Rectangle(0, Height / 2 - 6, 12, 12);
                e.Graphics.DrawEllipse(p, boxRect);
            }

            if (Checked)
            {
                Color fillColor = LmPaint.BackColor.Button.Selected(Theme);

                using (SolidBrush b = new SolidBrush(fillColor))
                {
                    Rectangle boxRect = new Rectangle(3, Height / 2 - 3, 6, 6);
                    e.Graphics.FillEllipse(b, boxRect);
                }
            }

            e.Graphics.SmoothingMode = SmoothingMode.Default;

            Rectangle textRect = new Rectangle(16, 0, Width - 16, Height);
            TextRenderer.DrawText(e.Graphics, Text, LmFonts.CheckBox(lmCheckBoxSize, lmCheckBoxWeight), textRect, foreColor, LmPaint.GetTextFormatFlags(TextAlign));

            // OnCustomPaintForeground(new LmPaintEventArgs(Color.Empty, foreColor, e.Graphics));

            if (displayFocusRectangle && isFocused)
                ControlPaint.DrawFocusRectangle(e.Graphics, ClientRectangle);
        }

        #endregion

        #region Focus Methods

        protected override void OnGotFocus(EventArgs e)
        {
            isFocused = true;
            isHovered = true;
            Invalidate();

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            isFocused = false;
            isHovered = false;
            isPressed = false;
            Invalidate();

            base.OnLostFocus(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            isFocused = true;
            isHovered = true;
            Invalidate();

            this.SetLastFocusedControl();

            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            isFocused = false;
            isHovered = false;
            isPressed = false;
            Invalidate();

            base.OnLeave(e);
        }

        #endregion

        #region Keyboard Methods

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isHovered = true;
                isPressed = true;
                Invalidate();
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //Remove this code cause this prevents the focus color
            //isHovered = false;
            //isPressed = false;
            Invalidate();

            base.OnKeyUp(e);
        }

        #endregion

        #region Mouse Methods

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            Invalidate();

            base.OnMouseEnter(e);
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

            base.OnMouseUp(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //This will check if control got the focus
            //If not thats the only it will remove the focus color
            if (!isFocused)
            {
                isHovered = false;
            }
            Invalidate();

            base.OnMouseLeave(e);
        }

        #endregion

        #region Overridden Methods

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            Invalidate();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size preferredSize;
            base.GetPreferredSize(proposedSize);

            using (var g = CreateGraphics())
            {
                proposedSize = new Size(int.MaxValue, int.MaxValue);
                preferredSize = TextRenderer.MeasureText(g, Text, LmFonts.CheckBox(lmCheckBoxSize, lmCheckBoxWeight), proposedSize, LmPaint.GetTextFormatFlags(TextAlign));
                preferredSize.Width += 16;
            }

            return preferredSize;
        }

        #endregion
    }
}
