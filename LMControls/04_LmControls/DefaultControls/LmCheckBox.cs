using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using LMControls.Metodos;
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
    [DefaultEvent("CheckedChanged")]
    [Designer(typeof(LmControls.Design.LmCheckBoxDesign))]
    public partial class LmCheckBox : CheckBox, ILmControl
    {
        #region Construtor

        public LmCheckBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
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

        private LmCheckBoxSize lmCheckBoxSize = LmCheckBoxSize.Medium;
        [DefaultValue(LmCheckBoxSize.Medium)]

        [Description("Escolha Tamanho da Fonte")]
        public LmCheckBoxSize FontSize
        {
            get { return lmCheckBoxSize; }
            set { lmCheckBoxSize = value; }
        }

        private LmCheckBoxWeight lmCheckBoxWeight = LmCheckBoxWeight.Regular;
        [DefaultValue(LmCheckBoxWeight.Regular)]

        [Description("Escolha peso da Fonte")]
        public LmCheckBoxWeight FontWeight
        {
            get { return lmCheckBoxWeight; }
            set { lmCheckBoxWeight = value; }
        }

        [Browsable(false)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        private string propriedade;
        [DefaultValue("")]
        [Browsable(true)]
        public string Propriedade
        {
            get { return propriedade; }
            set { propriedade = value; }
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
                foreColor = this.Parent.BackColor .GetForeColor(LmControlStatus.Selected);
                borderColor = LmPaint.BorderColor.TextBox.Selected(Theme);
            }
            else if (isHovered && isPressed && Enabled)
            {
                foreColor = this.Parent.BackColor.GetForeColor(LmControlStatus.Selected);
                borderColor = LmPaint.BorderColor.TextBox.Selected(Theme);
            }
            else if (!Enabled)
            {
                foreColor = this.Parent.BackColor.GetForeColor(LmControlStatus.Disabled);
                borderColor = LmPaint.BorderColor.TextBox.Disabled(Theme);
            }
            else
            {
                foreColor = this.Parent.BackColor.GetForeColor(LmControlStatus.Normal);
                borderColor = LmPaint.BorderColor.TextBox.Normal(Theme);
            }

            Rectangle textRect = new Rectangle(16, 0, Width - 16, Height);
            Rectangle boxRect = new Rectangle(0, Height / 2 - 6, 12, 12);
            using (Pen p = new Pen(borderColor))
            {
                switch (CheckAlign)
                {
                    case ContentAlignment.TopLeft:
                        boxRect = new Rectangle(0, 0, 12, 12);
                        break;
                    case ContentAlignment.MiddleLeft:
                        boxRect = new Rectangle(0, Height / 2 - 6, 12, 12);
                        break;
                    case ContentAlignment.BottomLeft:
                        boxRect = new Rectangle(0, Height - 13, 12, 12);
                        break;
                    case ContentAlignment.TopCenter:
                        boxRect = new Rectangle(Width / 2 - 6, 0, 12, 12);
                        textRect = new Rectangle(16, boxRect.Top + boxRect.Height - 5, Width - 16 / 2, Height);
                        break;
                    case ContentAlignment.BottomCenter:
                        boxRect = new Rectangle(Width / 2 - 6, Height - 13, 12, 12);
                        textRect = new Rectangle(16, -10, Width - 16 / 2, Height);
                        break;
                    case ContentAlignment.MiddleCenter:
                        boxRect = new Rectangle(Width / 2 - 6, Height / 2 - 6, 12, 12);
                        break;
                    case ContentAlignment.TopRight:
                        boxRect = new Rectangle(Width - 13, 0, 12, 12);
                        textRect = new Rectangle(0, 0, Width - 16, Height);
                        break;
                    case ContentAlignment.MiddleRight:
                        boxRect = new Rectangle(Width - 13, Height / 2 - 6, 12, 12);
                        textRect = new Rectangle(0, 0, Width - 16, Height);
                        break;
                    case ContentAlignment.BottomRight:
                        boxRect = new Rectangle(Width - 13, Height - 13, 12, 12);
                        textRect = new Rectangle(0, 0, Width - 16, Height);
                        break;
                }

                e.Graphics.DrawRectangle(p, boxRect);
            }

            if (Checked)
            {
                Color fillColor = CheckState == CheckState.Indeterminate ? LmPaint.BackColor.Button.Disabled(Theme) : LmPaint.BackColor.Button.Selected(Theme);

                using (SolidBrush b = new SolidBrush(fillColor))
                {
                    Rectangle boxCheck = new Rectangle(boxRect.Left + 3, boxRect.Top + 3, 7, 7);
                    e.Graphics.FillRectangle(b, boxCheck);
                }
            }

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
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Control frm = this.Parent;

                short cont = 0;
                while (true)
                {
                    if (frm == null) return;

                    if (frm is Form)
                    {
                        break;
                    }
                    else
                    {
                        cont++;
                        frm = frm.Parent;
                    }
                    if (cont >= 20) return;
                }

                ((Form)frm).SelectNextControl(((Form)frm).ActiveControl, true, true, true, true);
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
            // Verifica se o controle pegou o foco
            // Senão remove a cor do foco
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

                if (CheckAlign == ContentAlignment.TopCenter || CheckAlign == ContentAlignment.BottomCenter)
                {
                    preferredSize.Height += 16;
                }
            }

            return preferredSize;
        }

        #endregion
    }
}
