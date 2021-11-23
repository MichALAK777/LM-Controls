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
    //[Designer(typeof(LmControls.Design.LmMenuItemDesign))]
    public class LmMenuItem : IconButton
    {
        private bool isHovered = false;
        private bool isFocused = false;

        private Font _default = new Font("Segoe UI", 8F, FontStyle.Bold);

        public LmMenuItem()
        {
            Font = _default;
            this.Size = new Size(110, 30);
            TabStop = false;
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

        #endregion

        #region Paint Methods

        private void AplicarStilo()
        {
            Font = _default;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(Theme);
            this.FlatAppearance.MouseDownBackColor = LmPaint.BackColor.Button.Normal(Theme);
            this.FlatAppearance.MouseOverBackColor = LmPaint.BackColor.Button.Normal(Theme);
            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Normal);

            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //if (this.ContextMenuStrip == null)
            //    return;

            //var arrowSize = new Size(5, 12);
            //var rect = new Rectangle(this.Width - 15, (this.Height - arrowSize.Height) / 2, arrowSize.Width, arrowSize.Height);
            //// var rect = new Rectangle(this.Width - 15, y, 7, 14);
            //using (GraphicsPath path = new GraphicsPath())
            //using (Pen pen = new Pen(this.ForeColor, 2))
            //{
            //    //Drawing
            //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //    path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
            //    path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
            //    e.Graphics.DrawPath(pen, path);
            //}
        }

        #endregion

        #region Override Metodos

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;

            this.BackColor = LmPaint.BackColor.Button.Normal(Theme);

            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Selected);

            Invalidate();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!isFocused)
                isHovered = false;

            this.BackColor = LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(Theme);

            this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Normal);

            Invalidate();

            Font = _default;
            GC.Collect();
            base.OnMouseLeave(e);
        }

        //protected override void OnGotFocus(EventArgs e)
        //{
        //    isFocused = true;
        //    isHovered = true;
        //    this.SetLastFocusedControl();

        //    this.BackColor = LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(Theme);
        //    this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Selected);

        //    Invalidate();

        //    //ColorIcon();

        //    GC.Collect();
        //    base.OnGotFocus(e);
        //}

        //protected override void OnLostFocus(EventArgs e)
        //{
        //    isFocused = false;
        //    isHovered = false;

        //    this.BackColor = LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(Theme);
        //    this.ForeColor = this.IconColor = this.BackColor.GetForeColor(LmControlStatus.Normal);

        //    Invalidate();

        //    //ColorIcon();

        //    GC.Collect();
        //    base.OnLostFocus(e);
        //}

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        #endregion

        #region Metodos

        #endregion

        #region Events

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion

    }
}
