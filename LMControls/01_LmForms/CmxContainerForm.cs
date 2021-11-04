using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmControls;
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

namespace LMControls.LmForms
{
    public class LmContainerForm : ContainerControl, ILmForm, IDisposable
    {
        #region Constructor

        private ToolTip toolTip1;
        internal LmPanelFlow pnlForms = new LmPanelFlow();
        public LmStyleManager Estilo = new LmStyleManager();
        public LmContainerForm()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.UserPaint, true);

            this.AutoScroll = true;
            this.Name = "LmContainerForm";


            StyleManager = Estilo;
            Estilo.Owner = this;
            Estilo.Theme = InfoDefaultUI.DefaultStyle;
            Estilo.TipoMensagem = InfoDefaultUI.DefaultMsgType;

            this.toolTip1 = new ToolTip();
            this.SuspendLayout();
            this.Dock = DockStyle.Fill;

            this.ControlAdded += LmContainerForm_ControlAdded;
            this.ControlRemoved += LmContainerForm_ControlRemoved;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.Collect();
            }

            base.Dispose(disposing);
        }

        #endregion

        #region Interface

        private LmTheme lmTheme = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmTheme Theme
        {
            get
            {
                if (StyleManager != null)
                {
                    return StyleManager.Theme;
                }

                return lmTheme;
            }
            set { lmTheme = value; }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set { lmStyleManager = value; }
        }

        #endregion

        #region Campos

        [Browsable(false)]
        public override Color BackColor => LmPaint.BackColor.Form(Theme);

        private new Padding Padding
        {
            get { return base.Padding; }
            set
            {
                base.Padding = value;
            }
        }

        protected override Padding DefaultPadding
        {
            get { return new Padding(0, 30, 0, 0); }
        }


        internal List<string> FormsAbertos { get; set; } = new List<string>();

        #endregion

        #region Eventos

        #endregion

        #region Paint Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Pintar Cabeçalho
            using (SolidBrush b = new SolidBrush(LmPaint.BackColor.FormHeader(Theme)))
            {
                Rectangle topRect = new Rectangle(0, this.Padding.Top - 2, Width, 3);
                e.Graphics.FillRectangle(b, topRect);
            }
        }

        #endregion

        #region Metodos Privados

        internal void LmContainerForm_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                if (e.Control is LmChildForm frm)
                {
                    if (windowButtonList != null)
                        ClearWindowButton();

                    AddWindowButton(WindowButtons.Close, frm.Name);

                    AddWindowButton(WindowButtons.Help, frm.Name);

                    UpdateWindowButtonPosition();

                    if (!FormsAbertos.Contains(frm.Name))
                        FormsAbertos.Add(frm.Name);

                    AtualizarLinks();

                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro ao Adicionar Form ao Container");
            }
        }

        private void LmContainerForm_ControlRemoved(object sender, ControlEventArgs e)
        {
            try
            {
                if (e.Control is LmChildForm)
                {
                    FormsAbertos.Remove(e.Control.Name);

                    if (FormsAbertos.Count > 0)
                    {
                        var frm = this.Controls[FormsAbertos[FormsAbertos.Count - 1]] as LmChildForm;
                        frm.IsSelected = true;
                        frm.BringToFront();

                        if (windowButtonList != null)
                            ClearWindowButton();

                        AddWindowButton(WindowButtons.Close, frm.Name);

                        AddWindowButton(WindowButtons.Help, frm.Name);

                        UpdateWindowButtonPosition();

                        AtualizarLinks();
                    }
                    else
                    {
                        this.pnlForms.Controls.Clear();
                        this.Parent.Controls.Remove(this);
                    }
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro ao Remover Form do Container");
            }
        }

        public void AtualizarLinks()
        {
            try
            {
                this.pnlForms.Controls.Clear();

                foreach (var nomeForm in FormsAbertos)
                {
                    var frm = this.Controls[nomeForm] as LmChildForm;

                    var lmLabel = new LmLabel();
                    lmLabel.AutoSize = true;
                    lmLabel.Name = frm.Name;
                    lmLabel.FontSize = LmLabelSize.Small;
                    lmLabel.UseCustomForeColor = true;
                    lmLabel.Margin = new Padding(0, 5, 0, 0);

                    lmLabel.Text = frm.Text;

                    if (frm.IsSelected)
                    {
                        frm.Focus();

                        lmLabel.Cursor = Cursors.Default;
                        lmLabel.FontWeight = LmLabelWeight.Bold;

                        if (this.Parent != null && this.Parent.Parent != null)
                            ((LmJanelaAberta)this.Parent.Parent.Controls["msMenuJanelaAberta"].Controls["flpMain"].Controls[this.Name]).SetText(lmLabel.Text);
                    }
                    else
                    {
                        lmLabel.Cursor = Cursors.Hand;
                        lmLabel.FontWeight = LmLabelWeight.Regular;
                    }

                    lmLabel.Click += Lmlink_Click;

                    var isDark = this.BackColor.IsDarkColor();

                    if (this.pnlForms.Controls.Count > 0)
                    {
                        LmLabel lbl = new LmLabel();
                        lbl.AutoSize = true;
                        lbl.Text = "|";
                        lbl.Name = "divisor";
                        lbl.FontSize = LmLabelSize.Small;
                        lbl.Margin = new Padding(0, 5, 0, 0);
                        lbl.FontWeight = LmLabelWeight.Regular;

                        lbl.ForeColor = isDark ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;

                        this.pnlForms.Controls.Add(lbl);
                    }

                    lmLabel.ForeColor = isDark ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;

                    this.pnlForms.Controls.Add(lmLabel);
                }
            }
            catch (Exception ex)
            {
                LmException.ShowException(ex, "Erro ao Adicionar Controle");
            }
        }

        private void Lmlink_Click(object sender, EventArgs e)
        {
            try
            {
                var form = this.Controls[((Control)sender).Name] as LmChildForm;
                form.IsSelected = true;
                form.BringToFront();

                foreach (Control ctrl in pnlForms.Controls)
                {
                    if (ctrl is LmLabel link)
                    {
                        if (link.Name == form.Name)
                        {
                            link.Cursor = Cursors.Default;
                            link.FontWeight = LmLabelWeight.Bold;

                            if (this.Parent != null && this.Parent.Parent != null)
                                ((LmJanelaAberta)this.Parent.Parent.Controls["msMenuJanelaAberta"].Controls["flpMain"].Controls[this.Name]).SetText(link.Text);
                        }
                        else if (link.Name != "divisor")
                        {
                            link.Cursor = Cursors.Hand;
                            link.FontWeight = LmLabelWeight.Regular;
                        }

                        link.Size = link.GetPreferredSize(new Size(0, 0));
                        link.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("Aconteceu um erro de navegação\nFeche todas as telas abertas, para normalizar a navegação.",
                    "Erro de Navegação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Window Buttons

        public delegate void ButClick(object sender, EventArgs e);

        public event ButClick ClickHelp;

        private enum WindowButtons
        {
            Close,
            Help,
        }

        private Dictionary<WindowButtons, LmFormButton> windowButtonList;

        private void AddWindowButton(WindowButtons button, string formName)
        {
            this.ControlAdded -= LmContainerForm_ControlAdded;

            if (windowButtonList == null)
                windowButtonList = new Dictionary<WindowButtons, LmFormButton>();

            if (windowButtonList.ContainsKey(button))
                return;

            LmFormButton newButton = new LmFormButton(button == WindowButtons.Close);
            var fntWeb = new Font("Webdings", 9.25f);
            var fntArial = new Font("Arial", 14f);

            if (button == WindowButtons.Close)
            {
                newButton.Name = "btnClose";
                this.toolTip1.SetToolTip(newButton, "Fechar");
                newButton.Font = fntWeb;
                newButton.Text = "r";
            }
            else if (button == WindowButtons.Help)
            {
                newButton.Name = "btnHelp";
                this.toolTip1.SetToolTip(newButton, "Ajuda da Tela");
                newButton.Font = fntWeb;
                newButton.Text = "s";
            }
            newButton.Theme = Theme;
            newButton.Tag = button;

            newButton.Size = new Size(30, 28);
            newButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newButton.TabStop = false;
            newButton.Click += WindowButton_Click;
            Controls.Add(newButton);

            windowButtonList.Add(button, newButton);

            this.ControlAdded += LmContainerForm_ControlAdded;
        }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            var btn = sender as LmFormButton;
            if (btn != null)
            {
                var btnFlag = (WindowButtons)btn.Tag;
                if (btnFlag == WindowButtons.Close)
                {
                    this.Controls.OfType<LmChildForm>().FirstOrDefault().Close();
                }
                else if (btnFlag == WindowButtons.Help)
                {
                    ClickHelp?.Invoke(this.Controls.OfType<LmChildForm>().FirstOrDefault(), e);
                }
            }
        }

        private void ClearWindowButton()
        {
            this.ControlRemoved -= LmContainerForm_ControlRemoved;

            foreach (KeyValuePair<WindowButtons, LmFormButton> button in windowButtonList)
                this.Controls.Remove(button.Value);

            this.ControlRemoved += LmContainerForm_ControlRemoved;

            windowButtonList.Clear();

            Refresh();
        }

        private void UpdateWindowButtonPosition()
        {
            Dictionary<int, WindowButtons> priorityOrder = new Dictionary<int, WindowButtons>(3) {
                { 0, WindowButtons.Close }, { 1, WindowButtons.Help }};

            Point firstButtonLocation = new Point(ClientRectangle.Width - 30, 0);
            int lastDrawedButtonPosition = firstButtonLocation.X - 30;

            LmFormButton firstButton = null;

            if (windowButtonList.Count == 1)
            {
                foreach (KeyValuePair<WindowButtons, LmFormButton> button in windowButtonList)
                {
                    button.Value.Location = firstButtonLocation;
                }
            }
            else
            {
                foreach (KeyValuePair<int, WindowButtons> button in priorityOrder)
                {
                    bool buttonExists = windowButtonList.ContainsKey(button.Value);

                    if (firstButton == null && buttonExists)
                    {
                        firstButton = windowButtonList[button.Value];
                        firstButton.Location = firstButtonLocation;
                        continue;
                    }

                    if (firstButton == null || !buttonExists) continue;

                    windowButtonList[button.Value].Location = new Point(lastDrawedButtonPosition, 0);
                    lastDrawedButtonPosition = lastDrawedButtonPosition - 30;
                }
            }

            pnlForms.Location = new Point(0, 0);
            pnlForms.Size = new Size(this.Width - 92, 28);
            pnlForms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(pnlForms);

            Refresh();
        }

        private class LmFormButton : Button, ILmControl
        {
            #region Interface

            public event EventHandler<LmPaintEventArgs> CustomPaintBackground;
            protected virtual void OnCustomPaintBackground(LmPaintEventArgs e)
            {
                if (GetStyle(ControlStyles.UserPaint) && CustomPaintBackground != null)
                {
                    CustomPaintBackground(this, e);
                }
            }

            public event EventHandler<LmPaintEventArgs> CustomPaint;
            protected virtual void OnCustomPaint(LmPaintEventArgs e)
            {
                if (GetStyle(ControlStyles.UserPaint) && CustomPaint != null)
                {
                    CustomPaint(this, e);
                }
            }

            public event EventHandler<LmPaintEventArgs> CustomPaintForeground;
            protected virtual void OnCustomPaintForeground(LmPaintEventArgs e)
            {
                if (GetStyle(ControlStyles.UserPaint) && CustomPaintForeground != null)
                {
                    CustomPaintForeground(this, e);
                }
            }

            private LmTheme lmTema = LmTheme.Padrao;
            [DefaultValue(LmTheme.Padrao)]
            public LmTheme Theme
            {
                get
                {
                    if (DesignMode || lmTema != LmTheme.Padrao)
                    {
                        return lmTema;
                    }

                    if (StyleManager != null && lmTema == LmTheme.Padrao)
                    {
                        return StyleManager.Theme;
                    }
                    if (StyleManager == null && lmTema == LmTheme.Padrao)
                    {
                        return LmDefault.Theme;
                    }

                    return lmTema;
                }
                set { lmTema = value; }
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
            public bool UseCustomBackColor
            {
                get { return useCustomBackColor; }
                set { useCustomBackColor = value; }
            }

            private bool useCustomForeColor = false;
            [DefaultValue(false)]
            public bool UseCustomForeColor
            {
                get { return useCustomForeColor; }
                set { useCustomForeColor = value; }
            }

            private bool useStyleColors = false;
            [DefaultValue(false)]
            public bool UseStyleColors
            {
                get { return useStyleColors; }
                set { useStyleColors = value; }
            }

            [Browsable(false)]
            [DefaultValue(false)]
            public bool UseSelectable
            {
                get { return GetStyle(ControlStyles.Selectable); }
                set { SetStyle(ControlStyles.Selectable, value); }
            }

            #endregion

            #region Fields

            private bool isHovered = false;
            private bool isPressed = false;
            private bool isCloseBtn = false;

            #endregion

            #region Constructor

            public LmFormButton(bool isCloseButton)
            {
                SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.ResizeRedraw |
                         ControlStyles.UserPaint, true);

                isCloseBtn = isCloseButton;


            }

            #endregion

            #region Paint Methods

            protected override void OnPaint(PaintEventArgs e)
            {
                Color foreColor;

                LmTheme _Tema = Theme;
                if (Parent != null)
                {
                    if (Parent is ILmForm)
                    {
                        _Tema = ((ILmForm)Parent).Theme;
                    }

                    var backColor = LmPaint.BackColor.Form(_Tema);

                    var isDarkForm = LmCores.IsDarkColor(backColor.R, backColor.G, backColor.B);

                    foreColor = isDarkForm ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;

                    if (isHovered && !isPressed && Enabled)
                    {
                        if (!isCloseBtn)
                        {
                            foreColor = isDarkForm ? LmCores.Fr_Claro_Selected : LmCores.Fr_Escuro_Selected;

                            backColor = LmPaint.BackColor.FormHeader(_Tema);
                        }
                        else
                        {
                            foreColor = LmPaint.BackColor.Form(_Tema);
                            backColor = Color.FromArgb(232, 17, 35);
                        }
                    }
                    else if (isHovered && isPressed && Enabled)
                    {
                        foreColor = isDarkForm ? LmCores.Fr_Claro_Selected : LmCores.Fr_Escuro_Selected;

                        backColor = LmPaint.BackColor.GridView.CellNormal(_Tema);
                    }
                    else if (!Enabled)
                    {
                        foreColor = isDarkForm ? LmCores.Fr_Claro_Disabled : LmCores.Fr_Escuro_Disabled;

                        backColor = LmPaint.BackColor.Button.Disabled(_Tema);
                    }

                    e.Graphics.Clear(backColor);
                    TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, foreColor, backColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                }
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
                isHovered = false;
                Invalidate();

                base.OnMouseLeave(e);
            }

            #endregion
        }

        #endregion

    }
}
