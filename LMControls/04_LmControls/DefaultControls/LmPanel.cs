using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using System.ComponentModel;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [DefaultEvent("Paint")]
    public partial class LmPanel : Panel, ILmControl
    {
        #region Construtor

        public LmPanel()
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
            set
            {
                lmTheme = value;
                Invalidate();
            }
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

        private bool isPanelMenu;

        public bool IsPanelMenu
        {
            get { return isPanelMenu; }
            set
            {
                isPanelMenu = value;
                Invalidate();
            }
        }

        #endregion

        #region OnPaint Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isPanelMenu)
                this.BackColor = LmPaint.BackColor.MenuStrip.MenuPrincipalNormal(this.Theme);
            else
                this.BackColor = LmPaint.BackColor.Form(this.Theme);
        }
        #endregion
    }
}