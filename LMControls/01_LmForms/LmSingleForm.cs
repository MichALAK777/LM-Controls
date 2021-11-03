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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmForms
{
    public partial class LmSingleForm : Form, ILmForm, IDisposable
    {
        #region Constructor

        private ToolTip toolTip1;
        public LmStyleManager Estilo = new LmStyleManager();
        public LmSingleForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);

            this.Name = "LmSingleForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TransparencyKey = Color.Magenta;

            this.Padding = new Padding(borderSize);//Border size

            StyleManager = Estilo;
            Estilo.Owner = this;
            Estilo.Theme = InfoDefaultUI.DefaultStyle;
            Estilo.TipoMensagem = InfoDefaultUI.DefaultMsgType;

            this.toolTip1 = new ToolTip();
            this.SuspendLayout();
            // 
            // LmForm
            // 
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.Name = "LmForm";
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
                lmTema = value;
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
        private int borderSize = 2;
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

        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool Resizable { get; set; } = true;

        /// <summary>
        /// Nome do controle usado como Chave primaria
        /// </summary>
        [Browsable(true)]
        public LmTextBox ChavePrimaria { get; set; } = null;

        private Modo _modo = Modo.Padrao;

        [DefaultValue(Modo.Padrao)]
        [Browsable(false)]
        public Modo Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        #endregion

        #region Paint Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            Color foreColor = LmPaint.BackColor.FormHeader(Theme).IsDarkColor() ?LmCores.Fr_Claro_Normal  : LmCores.Fr_Escuro_Normal;

            // Pintar Cabeçalho
            if (ControlBox)
            {
                using (SolidBrush b = new SolidBrush(LmPaint.BackColor.FormHeader(Theme)))
                {
                    Rectangle topRect = new Rectangle(0, 0, Width, 30);
                    e.Graphics.FillRectangle(b, topRect);
                }

                // Imprimir Texto
                Rectangle bounds = new Rectangle(15, 5, ClientRectangle.Width - 2 * 30, 45);
                TextFormatFlags flags = TextFormatFlags.EndEllipsis | GetTextFormatFlags();
                TextRenderer.DrawText(e.Graphics, Text, LmFonts.TitleForm, bounds, foreColor, flags);
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            //if (!DesignMode)
            //{
            switch (StartPosition)
            {
                case FormStartPosition.CenterParent:
                    CenterToParent();
                    break;
                case FormStartPosition.CenterScreen:
                    CenterToScreen();

                    break;
            }
            //}

            if (ControlBox)
            {
                AddWindowButton(WindowButtons.Close);

                if (MaximizeBox)
                    AddWindowButton(WindowButtons.Maximize);

                if (MinimizeBox)
                    AddWindowButton(WindowButtons.Minimize);

                if (HelpButton)
                    AddWindowButton(WindowButtons.Help);

                //System.Threading.Thread t = new System.Threading.Thread(() => { UpdateWindowButtonPosition(); }) { IsBackground = true };
                //t.Start();
                UpdateWindowButtonPosition();
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
                //ReleaseCapture();
                //SendMessage(Handle, (int)WinApi.Messages.WM_NCLBUTTONDOWN, (int)WinApi.Messages.WM_DESTROY, 0);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
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
            Help,
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
            var fntArial = new Font("Arial", 14f);

            if (button == WindowButtons.Close)
            {
                this.toolTip1.SetToolTip(newButton, "Fechar");
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
            else if (button == WindowButtons.Help)
            {
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
                else if (btnFlag == WindowButtons.Help)
                {
                    ClickHelp?.Invoke(btn, e);
                }
            }
        }

        private void UpdateWindowButtonPosition()
        {
            if (!ControlBox) return;

            System.Threading.Thread.Sleep(100);
            Dictionary<int, WindowButtons> priorityOrder = new Dictionary<int, WindowButtons>(3) {
                { 0, WindowButtons.Close }, { 1, WindowButtons.Maximize }, { 2, WindowButtons.Minimize },
                { 3, WindowButtons.Help }};

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

                    if (isDarkHead)
                        foreColor = LmCores.Fr_Claro_Normal;
                    else
                        foreColor = LmCores.Fr_Escuro_Normal;

                    backColor = corHead;

                    if (isHovered && !isPressed && Enabled)
                    {
                        if (!isCloseBtn)
                        {
                            if (isDarkHead)
                                foreColor = LmCores.Fr_Claro_Selected;
                            else
                                foreColor = LmCores.Fr_Escuro_Selected;

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
                        if (isDarkHead)
                            foreColor = LmCores.Fr_Claro_Selected;
                        else
                            foreColor = LmCores.Fr_Escuro_Selected;

                        backColor = LmPaint.BackColor.GridView.CellNormal(_Tema);
                    }
                    else if (!Enabled)
                    {
                        if (isDarkHead)
                            foreColor = LmCores.Fr_Claro_Disabled;
                        else
                            foreColor = LmCores.Fr_Escuro_Disabled;

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
                //Top -= 3;
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
                //Top += 3;

                base.OnMouseLeave(e);
            }

            #endregion
        }

        #endregion

    }
}
