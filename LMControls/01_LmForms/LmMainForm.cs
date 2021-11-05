using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmControls;
using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmForms
{
    #region Enums

    public enum LmFormTextAlign
    {
        Left = 0,
        Center = 1,
        Right = 2
    }

    public enum Modo
    {
        Novo = 0,
        Alteracao = 1,
        Exclusao = 2,
        EmLock = 3,
        Bloqueado = 4,
        Padrao = 99,
    }

    #endregion

    [DefaultEvent("Load")]
    [Designer(typeof(LmControls.Design.LmFormDesign), typeof(IRootDesigner))]
    public partial class LmMainForm : Form, ILmForm, IDisposable
    {
        #region Construtor

        private ToolTip toolTip1;
        public LmStyleManager Estilo = new LmStyleManager();
        public LmMainForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);

            this.Name = "LmMainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TransparencyKey = Color.Magenta;

            this.Padding = new Padding(borderSize);//Border size

            StyleManager = Estilo;
            Estilo.Owner = this;
            Estilo.Theme = InfoDefaultUI.DefaultStyle;
            Estilo.TipoMensagem = InfoDefaultUI.DefaultMsgType;

            TipoMensagem = InfoDefaultUI.DefaultMsgType;

            this.toolTip1 = new ToolTip();
            this.SuspendLayout();
            // 
            // LmForm
            // 
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.Name = "LmMainForm";
            this.ResumeLayout(false);
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

        private LmTheme lmTema = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
        public LmTheme Theme
        {
            get
            {
                if (StyleManager != null)
                {
                    return StyleManager.Theme;
                }

                return lmTema;
            }
            set
            {
                InvertMenuImageColor(value, lmTema);

                lmTema = value;

                SaveStyle();
            }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set
            {
                lmStyleManager = value;
            }
        }

        #endregion

        #region Campos

        //Fields
        private int borderSize = 1;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        [Category(LmDefault.PropertyCategory.LmUI)]
        [Browsable(true)]
        public LmFormTextAlign TextAlign { get; set; } = LmFormTextAlign.Left;

        [Browsable(false)]
        public override Color BackColor => LmPaint.BackColor.Form(Theme);

        public new Padding Padding
        {
            get { return base.Padding; }
            set
            {
                base.Padding = value;
            }
        }

        protected override Padding DefaultPadding
        {
            get { return new Padding(1, 30, 1, 3); }
        }

        private LmMessageType tipoMensagem = LmMessageType.Padrao;

        [DefaultValue(LmMessageType.Padrao)]
        [Browsable(false)]
        public LmMessageType TipoMensagem
        {
            get
            {
                if (StyleManager != null)
                {
                    return StyleManager.TipoMensagem;
                }

                return tipoMensagem;
            }
            set { tipoMensagem = value; SaveTipoMessage(); }
        }

        private int idUsuarioLogado;

        [DefaultValue(0)]
        [Browsable(false)]
        public int IdUsuarioLogado
        {
            get
            {
                if (StyleManager != null)
                {
                    return StyleManager.IdUsuarioLogado;
                }

                return idUsuarioLogado;

            }
            set { idUsuarioLogado = value; SaveIdUsuario(); }
        }

        private LmPanel PnlMain { get; set; } = null;
        private LmPanelFlow MenuJanelaAberta { get; set; } = null;

        private int contC = 1;

        #endregion

        #region Paint Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            Color foreColor = LmPaint.BackColor.FormHeader(Theme).IsDarkColor() ?LmCores.Fr_Claro_Normal :  LmCores.Fr_Escuro_Normal;

            // Pintar Cabeçalho
            using (SolidBrush b = new SolidBrush(LmPaint.BackColor.FormHeader(Theme)))
            {
                Rectangle topRect = new Rectangle(0, 0, Width, 30);
                e.Graphics.FillRectangle(b, topRect);
            }

            // pintar Rodapé
            using (SolidBrush b = new SolidBrush(LmPaint.BackColor.FormHeader(Theme)))
            {
                Rectangle bottonRect = new Rectangle(0, Height - 30, Width, 30);
                e.Graphics.FillRectangle(b, bottonRect);
            }

            // pintar Bordas
            using (Pen pen = new Pen(LmPaint.BackColor.FormHeader(Theme), 2))
            {
                e.Graphics.DrawLines(pen, new[]
                {
                    new Point(1, 1),
                    new Point(1, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, 1),
                    new Point(0, 1)
                });
            }

            // Imprimir Texto
            Rectangle bounds = new Rectangle(15, 5, ClientRectangle.Width - 2 * 30, 45);
            TextFormatFlags flags = TextFormatFlags.EndEllipsis | GetTextFormatFlags();
            TextRenderer.DrawText(e.Graphics, Text, LmFonts.TitleForm, bounds, foreColor, flags);
        }

        private TextFormatFlags GetTextFormatFlags()
        {
            switch (TextAlign)
            {
                case LmFormTextAlign.Left: return TextFormatFlags.Left;
                case LmFormTextAlign.Center: return TextFormatFlags.HorizontalCenter;
                case LmFormTextAlign.Right: return TextFormatFlags.Right;
            }

            throw new InvalidOperationException();
        }

        #endregion

        #region Metodos de Gestão

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            PnlMain = ((LmPanel)this.Controls["pnlMain"]);
            MenuJanelaAberta = ((LmPanelFlow)this.Controls["msMenuJanelaAberta"].Controls["flpMain"]);

            switch (StartPosition)
            {
                case FormStartPosition.CenterParent:
                    CenterToParent();
                    break;
                case FormStartPosition.CenterScreen:
                    CenterToScreen();

                    break;
            }

            if (ControlBox)
            {
                AddWindowButton(WindowButtons.Close);

                if (MaximizeBox)
                    AddWindowButton(WindowButtons.Maximize);

                if (MinimizeBox)
                    AddWindowButton(WindowButtons.Minimize);

                UpdateWindowButtonPosition();
            }

            if (PnlMain != null)
            {
                PnlMain.ControlRemoved += PnlMain_ControlRemoved;
                PnlMain.ControlAdded += PnlMain_ControlAdded;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized) return;

                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.O)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(50, 50);
            }
            else if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.C)
            {
                System.Diagnostics.Process.Start("Calc.exe");
            }
            else if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.K)
            {
                System.Diagnostics.Process.Start("osk.exe");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                foreach (var file in (Directory.GetFiles(ValPadrao.PastaTemp)))
                    File.Delete(file);
            }
            catch (Exception)
            {
            }
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        #endregion

        #region Window Buttons

        public delegate void ButClick(object sender, EventArgs e);

        public event ButClick ClickHelp;

        private enum WindowButtons
        {
            Minimize,
            Maximize,
            Close,
        }

        private Dictionary<WindowButtons, LmFormButton> windowButtonList;

        private void AddWindowButton(WindowButtons button)
        {
            if (windowButtonList == null)
                windowButtonList = new Dictionary<WindowButtons, LmFormButton>();

            if (windowButtonList.ContainsKey(button))
                return;

            LmFormButton newButton = new LmFormButton(button == WindowButtons.Close);
            var fntWeb = new Font("Webdings", 9.25f);

            if (button == WindowButtons.Close)
            {
                this.toolTip1.SetToolTip(newButton, "Fechar Sistema");
                newButton.Font = fntWeb;
                newButton.Text = "r";
            }
            else if (button == WindowButtons.Minimize)
            {
                this.toolTip1.SetToolTip(newButton, "Minimizar");
                newButton.Font = fntWeb;
                newButton.Text = "0";
            }
            else if (button == WindowButtons.Maximize)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    this.toolTip1.SetToolTip(newButton, "Maximizar");
                    newButton.Font = fntWeb;
                    newButton.Text = "1";
                }
                else
                {
                    this.toolTip1.SetToolTip(newButton, "Rest. Tamanho");
                    newButton.Font = fntWeb;
                    newButton.Text = "2";
                }
            }

            newButton.Theme = Theme;
            newButton.Tag = button;

            newButton.Size = new Size(30, 28);
            newButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newButton.TabStop = false;
            newButton.Click += WindowButton_Click;
            Controls.Add(newButton);

            windowButtonList.Add(button, newButton);
        }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            var btn = sender as LmFormButton;
            if (btn != null)
            {
                var btnFlag = (WindowButtons)btn.Tag;
                if (btnFlag == WindowButtons.Close)
                {
                    Close();
                }
                else if (btnFlag == WindowButtons.Minimize)
                {
                    WindowState = FormWindowState.Minimized;
                }
                else if (btnFlag == WindowButtons.Maximize)
                {
                    if (WindowState == FormWindowState.Normal)
                    {

                        WindowState = FormWindowState.Maximized;
                        this.toolTip1.SetToolTip(btn, "Rest. Tamanho");
                        btn.Text = "2";
                    }
                    else
                    {
                        WindowState = FormWindowState.Normal;
                        this.toolTip1.SetToolTip(btn, "Maximizar");
                        btn.Text = "1";
                    }
                }
            }
        }

        private void UpdateWindowButtonPosition()
        {
            if (!ControlBox) return;

            System.Threading.Thread.Sleep(100);
            Dictionary<int, WindowButtons> priorityOrder = new Dictionary<int, WindowButtons>(3) {
                { 0, WindowButtons.Close }, { 1, WindowButtons.Maximize }, { 2, WindowButtons.Minimize }};

            Point firstButtonLocation = new Point(ClientRectangle.Width - 32, 2);
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

                    windowButtonList[button.Value].Location = new Point(lastDrawedButtonPosition, 2);
                    lastDrawedButtonPosition = lastDrawedButtonPosition - 30;
                }
            }

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
                Color backColor, foreColor;

                LmTheme _Tema = Theme;
                if (Parent != null)
                {
                    if (Parent is ILmForm)
                    {
                        _Tema = ((ILmForm)Parent).Theme;
                    }

                    var corHead = LmPaint.BackColor.FormHeader(_Tema);
                    var corForm = LmPaint.BackColor.Form(_Tema);

                    var isDarkHead = LmCores.IsDarkColor(corHead.R, corHead.G, corHead.B);

                    foreColor = isDarkHead ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;

                    backColor = corHead;

                    if (isHovered && !isPressed && Enabled)
                    {
                        if (!isCloseBtn)
                        {
                            foreColor = isDarkHead ? LmCores.Fr_Claro_Selected : LmCores.Fr_Escuro_Selected;

                            backColor = LmPaint.BackColor.Form(_Tema);
                        }
                        else
                        {
                            foreColor = LmPaint.BackColor.Form(_Tema);
                            backColor = Color.FromArgb(232, 17, 35);
                        }
                    }
                    else if (isHovered && isPressed && Enabled)
                    {
                        foreColor = isDarkHead ? LmCores.Fr_Claro_Selected : LmCores.Fr_Escuro_Selected;

                        backColor = LmPaint.BackColor.GridView.CellNormal(_Tema);
                    }
                    else if (!Enabled)
                    {
                        foreColor = isDarkHead ? LmCores.Fr_Claro_Disabled : LmCores.Fr_Escuro_Disabled;

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

        #region Metodos Públicos

        /// <summary>
        /// Metodo Para Abrir Formulario LmForm Como Filho
        /// </summary>
        /// <param name="form">Deve ser do Tipo LmForm</param>
        public void OpenFormChild(LmChildForm form)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                if (PnlMain != null)
                {
                    if (PnlMain.Controls.Count > 12)
                    {
                        MsgBox.Show("O Lizard Permite trabalhar com no máximo Doze(12) Janelas ao mesmo tempo.\nFeche algumas janelas para continuar.",
                            "Limite de janelas atingido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                        return;
                    }

                    LmContainerForm frmContainer = new LmContainerForm
                    {
                        Name = "frmContainer" + contC,
                    };
                    contC++;

                    frmContainer.ClickHelp += MsJanelaAberta_ClickHelp;

                    var abaJanela = new LmJanelaAberta(this.Theme)
                    {
                        Name = frmContainer.Name,
                    };

                    abaJanela.SetText(form.Text);

                    abaJanela.FecharTudoExetoEsta += MsJanelaAberta_FecharTudoExetoEsta;
                    abaJanela.FecharContainerForms += MsJanelaAberta_FecharContainerForms;
                    abaJanela.FecharTudoEsquerda += MsJanelaAberta_FecharTudoEsquerda;
                    abaJanela.FecharTudoDireita += MsJanelaAberta_FecharTudoDireita;

                    form.Dock = DockStyle.Fill;

                    form.Modo = Modo.Novo;

                    MenuJanelaAberta.Controls.Add(abaJanela);

                    form.TopLevel = false;
                
                    form.IsSelected = true;
                    form.OnLoading();

                    frmContainer.Controls.Add(form);
                    frmContainer.Controls[form.Name].BringToFront();

                    form.Show();

                    PnlMain.Controls.Add(frmContainer);
                    PnlMain.Controls[frmContainer.Name].BringToFront();

                    System.Threading.Thread t1 = new System.Threading.Thread(() => { ((LmMenuJanelaAberta)MenuJanelaAberta.Parent).FocarContainer(frmContainer.Name); }) { IsBackground = true };
                    t1.Start();

                    System.Threading.Thread t2 = new System.Threading.Thread(() => { form.OnLoaded(); }) { IsBackground = true };
                    t2.Start();

                    frmContainer.TabStop = false;
                }
                else
                {
                    MsgBox.Show("Painel \"pnlMain\" do Formulário principal não encontrado.\nContate administrador do sistema.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Não foi possível abrir o formulário \"{form.Text}\"", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void MsJanelaAberta_ClickHelp(object sender, EventArgs e)
        {
            ClickHelp?.Invoke(((LmChildForm)sender).Text, e);
        }

        private void MsJanelaAberta_FecharContainerForms(object sender, EventArgs e)
        {
            try
            {
                var container = (LmContainerForm)PnlMain.Controls[((Control)sender).Name];

                int cont = 0;
                while (container.pnlForms.Controls.Count > 0 || cont == 100)
                {
                    var frm = container.Controls[container.pnlForms.Controls[container.pnlForms.Controls.Count - 1].Name] as LmChildForm;
                    frm.Close();

                    if (cont == 99)
                        MsgBox.Show("Fechar formulários entrou em um ciclo infinito, o Sistema tratou isto, e cancelou o fechamento.",
                            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    cont++;
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Erro ao Fechar Janelas.\n\n{ex.Message}",
                    "Fechar Tudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MsJanelaAberta_FecharTudo(object sender, EventArgs e)
        {
            try
            {
                List<string> containersRemover = new List<string>();

                foreach (var ctrl in MenuJanelaAberta.Controls)
                {
                    if (ctrl is LmJanelaAberta aberta)
                        containersRemover.Add(aberta.Name);
                }

                if (containersRemover.Count > 0 &&
                    MsgBox.Show("Deseja realmente fechar todas as abas abertas?",
                    "Fechar Tudo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in containersRemover)
                    {
                        object ctrl = MenuJanelaAberta.Controls[item];
                        MsJanelaAberta_FecharContainerForms(ctrl, new EventArgs());
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Erro ao Fechar Janelas.\n\n{ex.Message}",
                    "Fechar Tudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MsJanelaAberta_FecharTudoExetoEsta(object sender, EventArgs e)
        {
            List<string> containersRemover = new List<string>();

            foreach (var ctrl in MenuJanelaAberta.Controls)
            {
                if (ctrl is LmJanelaAberta aberta)
                {
                    if (aberta.Name != ((Control)sender).Name)
                        containersRemover.Add(aberta.Name);
                }
            }

            foreach (var item in containersRemover)
            {
                object ctrl = MenuJanelaAberta.Controls[item];
                MsJanelaAberta_FecharContainerForms(ctrl, new EventArgs());
            }
        }

        private void MsJanelaAberta_FecharTudoEsquerda(object sender, EventArgs e)
        {
            List<string> containersRemover = new List<string>();

            for (int i = 0; i < MenuJanelaAberta.Controls.Count; i++)
            {
                if (MenuJanelaAberta.Controls[i].Name != ((Control)sender).Name)
                    containersRemover.Add(MenuJanelaAberta.Controls[i].Name);
                else
                    break;
            }

            foreach (var item in containersRemover)
            {
                object ctrl = MenuJanelaAberta.Controls[item];
                MsJanelaAberta_FecharContainerForms(ctrl, new EventArgs());
            }
        }

        private void MsJanelaAberta_FecharTudoDireita(object sender, EventArgs e)
        {
            List<string> containersRemover = new List<string>();

            var adicionando = false;
            for (int i = 0; i < MenuJanelaAberta.Controls.Count; i++)
            {
                if (adicionando)
                    containersRemover.Add(MenuJanelaAberta.Controls[i].Name);
                else if (MenuJanelaAberta.Controls[i].Name == ((Control)sender).Name)
                    adicionando = true;
            }

            foreach (var item in containersRemover)
            {
                object ctrl = MenuJanelaAberta.Controls[item];
                MsJanelaAberta_FecharContainerForms(ctrl, new EventArgs());
            }
        }

        private void PnlMain_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void PnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control.Name.StartsWith("frmContainer"))
            {
                ((LmMenuJanelaAberta)MenuJanelaAberta.Parent).Removejanela(e.Control.Name);
            }

            if (MenuJanelaAberta.Controls.Count > 0 && MenuJanelaAberta.Controls[0] != null && !((LmJanelaAberta)MenuJanelaAberta.Controls[0]).IsSelected)
            {
                System.Threading.Thread t = new System.Threading.Thread(() => { ((LmMenuJanelaAberta)MenuJanelaAberta.Parent).FocarContainer(PnlMain.Controls[0].Name); }) { IsBackground = true };
                t.Start();
            }
            else if (PnlMain.Controls.Count == 0)
            {
                ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslFormAberto"]).Text = "";
                ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslModo"]).Text = "";
            }

            this.Refresh();
        }

        #endregion

        #region Metodos Privados

        public void InvertMenuImageColor(LmTheme ThemeNovo, LmTheme ThemeAtual)
        {
            var corHeaderNovo = LmPaint.BackColor.FormHeader(ThemeNovo);
            var corHeaderAtual = LmPaint.BackColor.FormHeader(ThemeAtual);

            var novoIsDark = LmCores.IsDarkColor(corHeaderNovo.R, corHeaderNovo.G, corHeaderNovo.B);
            var AtualIsDark = LmCores.IsDarkColor(corHeaderAtual.R, corHeaderAtual.G, corHeaderAtual.B);

            if (novoIsDark != AtualIsDark)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is LmMenuStrip menuStrip)
                    {
                        foreach (ToolStripMenuItem item in menuStrip.Items)
                        {
                            if (item.Tag != null && item.Tag.ToString().ToLower() == "protegidocor")
                                continue;

                            item.MouseEnter += Item_MouseEnter;
                            item.MouseLeave += Item_MouseLeave;

                            item.DropDownClosed += Item_DropDownClosed;

                            if (item.Image != null)
                                item.Image = Metodos.Controles.ApplyInvert(item.Image);

                            item.ForeColor = novoIsDark ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;
                        }
                    }
                    if (ctrl is PictureBox ptb)
                    {
                        if (ptb.Image != null)
                            ptb.Image = Metodos.Controles.ApplyInvert(ptb.Image);
                    }
                }
            }
        }

        private void Item_DropDownClosed(object sender, EventArgs e)
        {
            Item_MouseLeave(sender, new EventArgs());
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Pressed) return;

            var corHead = LmPaint.BackColor.FormHeader(this.Theme);
            var corForm = LmPaint.BackColor.Form(this.Theme);

            var headIsDark = LmCores.IsDarkColor(corHead.R, corHead.G, corHead.B);
            var formIsDark = LmCores.IsDarkColor(corForm.R, corForm.G, corForm.B);

            if (headIsDark != formIsDark)
            {
                if (((ToolStripMenuItem)sender).Image != null)
                    ((ToolStripMenuItem)sender).Image = LMControls.Metodos.Controles.ApplyInvert(((ToolStripMenuItem)sender).Image);

                ((ToolStripMenuItem)sender).ForeColor = formIsDark ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;
            }
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Pressed || ((ToolStripMenuItem)sender).Selected) return;

            var corHead = LmPaint.BackColor.FormHeader(this.Theme);
            var corForm = LmPaint.BackColor.Form(this.Theme);

            var headIsDark = LmCores.IsDarkColor(corHead.R, corHead.G, corHead.B);
            var formIsDark = LmCores.IsDarkColor(corForm.R, corForm.G, corForm.B);

            if (headIsDark != formIsDark)
            {
                if (((ToolStripMenuItem)sender).Image != null)
                    ((ToolStripMenuItem)sender).Image = Metodos.Controles.ApplyInvert(((ToolStripMenuItem)sender).Image);

                ((ToolStripMenuItem)sender).ForeColor = headIsDark ? LmCores.Fr_Claro_Normal : LmCores.Fr_Escuro_Normal;
            }
        }

        private void SaveStyle()
        {
            Estilo.Theme = lmTema;

            InfoDefaultUI.DefaultStyle = Theme;
        }

        private void SaveTipoMessage()
        {
            Estilo.TipoMensagem = tipoMensagem;
            InfoDefaultUI.DefaultMsgType = TipoMensagem;
        }

        private void SaveIdUsuario()
        {
            Estilo.IdUsuarioLogado = idUsuarioLogado;
            InfoDefaultUI.UsuarioLogado_ID = IdUsuarioLogado;
        }

        #endregion

    }
}
