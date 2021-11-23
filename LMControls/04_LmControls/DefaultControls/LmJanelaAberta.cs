using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [Designer(typeof(LmControls.Design.LmJanelaAbertaDesign))]
    public partial class LmJanelaAberta : UserControl, ILmControl
    {
        #region Construtor

        public LmJanelaAberta(LmTheme theme)
        {
            this.Theme = theme;

            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            this.DoubleBuffered = true;
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

                this.Theme = lmStyleManager.Theme;

            }
        }

        #endregion

        #region Fields

        [Browsable(false)]
        public bool IsSelected { get; set; } = true;
        [Browsable(false)]
        public bool IsHovered { get; set; } = false;
        [Browsable(false)]

        #endregion

        #region Paint Method

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Color backColor = BackColor;
                Color foreColor = ForeColor;

                if (IsSelected)
                    backColor = LmPaint.BackColor.Form(this.Theme);
                else if (IsHovered)
                {
                    backColor = LmPaint.BackColor.MenuJanelaAberta.JanelaAberta(this.Theme);

                    if (backColor.IsDarkColor())
                        backColor = Color.FromArgb(backColor.R + 30, backColor.G + 30, backColor.B + 30);
                    else
                        backColor = Color.FromArgb(backColor.R - 30, backColor.G - 30, backColor.B - 30);
                }
                else
                    backColor = LmPaint.BackColor.MenuJanelaAberta.JanelaAberta(this.Theme);

                foreColor = backColor.GetForeColor(LmControlStatus.Normal);

                lblNomeJanela.ForeColor = foreColor;

                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                    return;
                }

                base.OnPaint(e);

                // OnCustomPaintBackground(new LmPaintEventArgs(backColor, Color.Empty, e.Graphics));
            }
            catch
            {
                Invalidate();
            }
        }

        #endregion

        #region Eventos

        public delegate void ClickControl(object sender, EventArgs e);

        public event ClickControl ClickJanela;
        public event ClickControl FecharContainerForms;
        public event ClickControl FecharTudo;
        public event ClickControl FecharTudoExetoEsta;
        public event ClickControl FecharTudoDireita;
        public event ClickControl FecharTudoEsquerda;


        #endregion

        public void SetText(string text)
        {
            this.lblNomeJanela.Text = text;

            this.lblNomeJanela.Refresh();
            this.Width = this.lblNomeJanela.Width + this.lnkFechar.Width - 1;
        }

        private void LmJanelaAberta_MouseEnter(object sender, EventArgs e)
        {
            if (!IsHovered)
            {
                IsHovered = true;
                Invalidate();
            }
        }

        private void LmJanelaAberta_MouseLeave(object sender, EventArgs e)
        {
            if (IsHovered)
            {
                IsHovered = false;
                Invalidate();
            }
        }

        private void LblNomeJanela_Click(object sender, EventArgs e)
        {
            ClickJanela?.Invoke(this, new EventArgs());
        }

        private void LnkFechar_Click(object sender, EventArgs e)
        {
            FecharContainerForms?.Invoke(this, new EventArgs());
        }

        private void TsFecharTudoExcetoEsta_Click(object sender, EventArgs e)
        {
            FecharTudoExetoEsta?.Invoke(this, new EventArgs());
        }

        private void TsFecharEstaAba_Click(object sender, EventArgs e)
        {
            FecharContainerForms?.Invoke(this, new EventArgs());
        }

        private void TsFecharTudoEsquerda_Click(object sender, EventArgs e)
        {
            FecharTudoEsquerda?.Invoke(this, new EventArgs());
        }

        private void TsFecharTudoDireita_Click(object sender, EventArgs e)
        {
            FecharTudoDireita?.Invoke(this, new EventArgs());
        }

        private void TsFecharTudo_Click(object sender, EventArgs e)
        {
            FecharTudo?.Invoke(this, new EventArgs());
        }
    }
}
