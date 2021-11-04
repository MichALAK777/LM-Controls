using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    //[ToolboxBitmap(typeof(TextBox))]
    [DefaultEvent("TextChanged")]
    [Designer("LMControls.LmControls.Design.LmTextBoxDesign")]
    public partial class LmTextBox : UserControl, ILmControl
    {
        #region Construtor

        public LmTextBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
            this.GotFocus += LmTextBox_GotFocus;

            CmbDados.DataSourceChanged += CmbDados_DataSourceChanged;
        }

        private void CmbDados_DataSourceChanged(object sender, EventArgs e)
        {
            DefinirAutoComplete();
        }

        #endregion

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

        private LmTheme lmTema = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
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
            set
            {
                lmStyleManager = value;
                //CustomButtonF7.Theme = CustomButtonF8.Theme = this.Theme;
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

        #region Campos

        private Image textBoxIcon = null;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(null)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public Image Icon
        {
            get { return textBoxIcon; }
            set
            {
                textBoxIcon = value;

                ptbIcon.Image = textBoxIcon;

                Refresh();
            }
        }

        private bool textBoxIconRight = false;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool IconRight
        {
            get { return textBoxIconRight; }
            set
            {
                textBoxIconRight = value;
                if (textBoxIconRight)
                    ptbIcon.Dock = DockStyle.Right;
                else
                    ptbIcon.Dock = DockStyle.Left;
                Refresh();
            }
        }

        private bool iconShow = false;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool IconShow
        {
            get { return iconShow; }
            set
            {
                iconShow = value;

                ptbIcon.Visible = iconShow;

                Refresh();
            }
        }

        private bool _showbuttonF7 = false;
        private bool _showbuttonF8 = false;

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool ShowButtonF7
        {
            get { return _showbuttonF7; }
            set
            {
                _showbuttonF7 = value;

                if (_showbuttonF7)
                    ptbF7.Visible = true;
                else
                    ptbF7.Visible = false;

                Refresh();
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool ShowButtonF8
        {
            get { return _showbuttonF8; }
            set
            {
                _showbuttonF8 = value;

                if (_showbuttonF7)
                    ptbF7.Visible = true;
                else
                    ptbF7.Visible = false;

                Refresh();
            }
        }

        private Image iconF7 = null;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(null)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public Image IconF7
        {
            get { return iconF7; }
            set
            {
                iconF7 = value;

                ptbF7.Image = iconF7;

                Refresh();
            }
        }

        private Image iconF8 = null;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(null)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public Image IconF8
        {
            get { return iconF8; }
            set
            {
                iconF8 = value;

                ptbF8.Image = iconF8;

                Refresh();
            }
        }

        private bool _showclear = false;

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool ShowClearButton
        {
            get { return _showclear; }
            set
            {
                _showclear = value;
                ptbClearButton.Visible = !string.IsNullOrEmpty(this.Text) && _showclear;
                Refresh();
            }
        }

        private bool campoObrigatorio;
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(false)]
        public bool CampoObrigatorio
        {
            get { return campoObrigatorio; }
            set { campoObrigatorio = value; }
        }

        private LmValueType valor;
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(LmValueType.Alfanumerico)]
        public LmValueType Valor
        {
            get { return valor; }
            set
            {
                valor = value;
            }
        }

        private short valor_Decimais;
        [Browsable(true)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(0)]
        public short Valor_Decimais
        {
            get { return valor_Decimais; }
            set { valor_Decimais = value; }
        }

        private bool isPrimaryKey = false;
        [DefaultValue(false)]
        [Browsable(true)]
        public bool IsPrimaryKey
        {
            get { return isPrimaryKey; }
            set { isPrimaryKey = value; }
        }

        private bool supressAutoLeaveEvent = false;
        [DefaultValue(false)]
        [Browsable(false)]
        public bool SupressAutoLeaveEvent
        {
            get { return supressAutoLeaveEvent; }
            set { supressAutoLeaveEvent = value; }
        }

        private bool supressCloseOnEscapePress = false;
        [DefaultValue(false)]
        [Browsable(false)]
        public bool SupressCloseOnEscapePress
        {
            get { return supressCloseOnEscapePress; }
            set { supressCloseOnEscapePress = value; }
        }

        [DefaultValue(null)]
        [Browsable(false)]
        public BindingSource CmbDados { get; set; } = new BindingSource();

        private object selectedValue;
        [DefaultValue(null)]
        [Browsable(false)]
        public object SelectedValue
        {
            get { return selectedValue; }
            set
            {
                if (Convert.ToString(selectedValue) != Convert.ToString(value))
                {
                    selectedValue = value;
                    UpdateCmbItem();
                    SelectedValueChanched?.Invoke(this, new EventArgs());
                }
            }
        }

        private object selectedItem;
        [DefaultValue(null)]
        [Browsable(false)]
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                UpdateCmbValue();
            }
        }

        private string propriedade;
        [DefaultValue("")]
        [Browsable(true)]
        public string Propriedade
        {
            get { return propriedade; }
            set { propriedade = value; }
        }

        private Color borderColor = Color.MediumSlateBlue;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        private Color borderFocusColor = Color.HotPink;
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        private int borderSize = 2;
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        private bool underlinedStyle = false;
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        private int borderRadius = 0;
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    if (value > Height / 2)
                        value = Height / 2;

                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        private string textPrompt = string.Empty;
        public string TextPrompt
        {
            get { return textPrompt; }
            set
            {
                textPrompt = value;
                baseTextBox.PlaceholderText = value;
                this.Invalidate();
            }
        }

        private bool isHovered = false;
        private bool isFocused = false;

        #endregion

        #region Routing Fields

        [DefaultValue(false)]
        public bool Multiline
        {
            get { return baseTextBox.Multiline; }
            set { baseTextBox.Multiline = value; }
        }

        [Browsable (true)]
        public override string Text
        {
            get { return baseTextBox.Text; }
            set { baseTextBox.Text = value;  }
        }

        public string[] Lines
        {
            get { return baseTextBox.Lines; }
            set { baseTextBox.Lines = value; }
        }

        [Browsable(false)]
        public string SelectedText
        {
            get { return baseTextBox.SelectedText; }
            set { baseTextBox.Text = value; }
        }

        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return baseTextBox.ReadOnly; }
            set { baseTextBox.ReadOnly = value; }
        }

        public char PasswordChar
        {
            get { return baseTextBox.PasswordChar; }
            set { baseTextBox.PasswordChar = value; }
        }

        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get { return baseTextBox.UseSystemPasswordChar; }
            set { baseTextBox.UseSystemPasswordChar = value; }
        }

        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign
        {
            get { return baseTextBox.TextAlign; }
            set { baseTextBox.TextAlign = value; }
        }

        public int SelectionStart
        {
            get { return baseTextBox.SelectionStart; }
            set { baseTextBox.SelectionStart = value; }
        }

        public int SelectionLength
        {
            get { return baseTextBox.SelectionLength; }
            set { baseTextBox.SelectionLength = value; }
        }

        public int MaxLength
        {
            get { return baseTextBox.MaxLength; }
            set { baseTextBox.MaxLength = value; }
        }

        public ScrollBars ScrollBars
        {
            get { return baseTextBox.ScrollBars; }
            set { baseTextBox.ScrollBars = value; }
        }

        [DefaultValue(AutoCompleteMode.None)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return baseTextBox.AutoCompleteMode; }
            set { baseTextBox.AutoCompleteMode = value; }
        }

        [DefaultValue(AutoCompleteSource.None)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return baseTextBox.AutoCompleteSource; }
            set { baseTextBox.AutoCompleteSource = value; }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return baseTextBox.AutoCompleteCustomSource; }
            set { baseTextBox.AutoCompleteCustomSource = value; }
        }

        public bool ShortcutsEnabled
        {
            get { return baseTextBox.ShortcutsEnabled; }
            set { baseTextBox.ShortcutsEnabled = value; }
        }

        #endregion

        #region Routing Methods

        public event EventHandler AcceptsTabChanged;
        private void BaseTextBoxAcceptsTabChanged(object sender, EventArgs e)
        {
            //if (AcceptsTabChanged != null)
            //    AcceptsTabChanged(this, e);
            AcceptsTabChanged?.Invoke(this, e);
        }

        private void BaseTextBoxSizeChanged(object sender, EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        private void BaseTextBoxCursorChanged(object sender, EventArgs e)
        {
            base.OnCursorChanged(e);
            Refresh();
        }

        private void BaseTextBoxContextMenuStripChanged(object sender, EventArgs e)
        {
            base.OnContextMenuStripChanged(e);
        }

        //private void BaseTextBoxContextMenuChanged(object sender, EventArgs e)
        //{
        //    base.OnContextMenuChanged(e);
        //}

        private void BaseTextBoxClientSizeChanged(object sender, EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }

        private void BaseTextBoxClick(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (Valor == LmValueType.Hora || Valor == LmValueType.Num_Inteiro || Valor == LmValueType.Num_Real)
            {
                baseTextBox.SelectAll();
            }
        }

        private void BaseTextBoxChangeUiCues(object sender, UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
        }

        private void BaseTextBoxCausesValidationChanged(object sender, EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }

        private void BaseTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        private void BaseTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            switch (Valor)
            {
                /*
                 *      (char)8     backaspace 
                 *      (char)72    H
                 *      (char)104   h
                 *      (char)43    +
                 *      (char)45    -
                 *      (char)44    ,
                 *      (char)46    .
                 *      (char)1     ctrl+A
                 *      (char)3     ctrl+C
                 *      (char)22    ctrl+V
                 *      (char)24    ctrl+X
                 */
                case LmValueType.Data:
                    if ((this.Text.ToLower().StartsWith("h") && this.Text.Length > 5 && e.KeyChar != (char)8) ||
                        (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)72 && e.KeyChar != (char)104 &&
                        e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24 &&
                        e.KeyChar != (char)43 && e.KeyChar != (char)45))
                    {
                        e.Handled = true;
                    };
                    break;
                case LmValueType.Hora:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)3 && e.KeyChar != (char)1
                        && e.KeyChar != (char)72 && e.KeyChar != (char)104 && e.KeyChar != (char)22 && e.KeyChar != (char)24) { e.Handled = true; };
                    break;
                case LmValueType.Num_Inteiro:
                    if (e.KeyChar == (char)45 &&
                       (this.Text.Contains("-") || !string.IsNullOrEmpty(this.Text)) &&
                       this.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)45 && e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24)
                    {
                        e.Handled = true;
                    };

                    break;
                case LmValueType.Num_Real:
                    if (e.KeyChar == (char)46) { e.KeyChar = (char)44; }
                    if (e.KeyChar == (char)44 && this.Text.Contains(",")) { e.Handled = true; }
                    if (e.KeyChar == (char)45 &&
                        (this.Text.Contains("-") | !string.IsNullOrEmpty(this.Text)) &&
                        this.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)45 && e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24)
                    {
                        e.Handled = true;
                    }
                    break;
                case LmValueType.Monetario:
                    if (e.KeyChar == (char)46) { e.KeyChar = (char)44; }
                    if (e.KeyChar == (char)44 && this.Text.Contains(",")) { e.Handled = true; }
                    if (e.KeyChar == (char)45 &&
                        (this.Text.Contains("-") | !string.IsNullOrEmpty(this.Text)) &&
                        this.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)45 && e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24)
                    {
                        e.Handled = true;
                    }
                    break;
                case LmValueType.Fone:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24)
                    {
                        e.Handled = true;
                    };
                    break;
                case LmValueType.Cpf_Cnpj:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)3 && e.KeyChar != (char)1 && e.KeyChar != (char)22 && e.KeyChar != (char)24)
                    {
                        e.Handled = true;
                    };
                    break;

                default:
                    break;
            }

        }

        private void BaseTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);

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

            if (/*!ReadOnly &&*/ e.KeyCode == Keys.Down && ShowButtonF7 && (Valor == LmValueType.ComboBox || Valor == LmValueType.ComboBox_Enum))
            {
                if (!ShowButtonF7) return;

                e.SuppressKeyPress = true;

                _buttonF7_Click(sender, new EventArgs());
            }
            else if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && this.Multiline == false)
            {
                e.SuppressKeyPress = true;
                if (SupressAutoLeaveEvent) return;

                ((Form)frm).SelectNextControl(((Form)frm).ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up && this.Multiline == false)
            {
                e.SuppressKeyPress = true;
                if (SupressAutoLeaveEvent) return;

                ((Form)frm).SelectNextControl(((Form)frm).ActiveControl, false, true, true, true);
            }
            else if (e.KeyCode == Keys.F7 && _showbuttonF7)
            {
                //if (!ReadOnly)
                _buttonF7_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8 && _showbuttonF8)
            {
                //if (!ReadOnly)
                _buttonF8_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (supressCloseOnEscapePress) return;
                ((Form)frm).Close();
            }
        }

        private void BaseTextBox_MouseHover(object sender, EventArgs e)
        {
            base.OnMouseHover(e);
        }

        private void BaseTextBox_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);

            isHovered = true;

            Invalidate();
        }

        private void BaseTextBox_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);

            isHovered = false;

            Invalidate();
        }

        bool _cleared = false;
        bool _withtext = false;

        private void BaseTextBoxTextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);

            ptbClearButton.Visible = !string.IsNullOrEmpty(this.Text) && _showclear;

            if (baseTextBox.Text != "" && !_withtext)
            {
                _withtext = true;
                _cleared = false;
                Invalidate();
            }

            if (baseTextBox.Text == "" && !_cleared)
            {
                _withtext = false;
                _cleared = true;

                if (Valor == LmValueType.ComboBox || Valor == LmValueType.ComboBox_Enum)
                    SelectedValue = null;

                Invalidate();
            }

            if (!_withtext)
            {
                selectedItem = null;
                selectedValue = null;
            }

            if (baseTextBox.Text == "")
            {
                if (Valor == LmValueType.ComboBox || Valor == LmValueType.ComboBox_Enum)
                {
                    SelectedValue = null;
                }
            }

            if (this.isPrimaryKey)
                this.Text = this.Text.SomenteNumeros();

            TextChanged.Invoke(sender, e);
        }

        public void Clear()
        {
            baseTextBox.Clear();
        }

        void LmTextBox_GotFocus(object sender, EventArgs e)
        {
            baseTextBox.Focus();
        }

        #endregion

        #region -> Private methods

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(baseTextBox.ClientRectangle, borderRadius - borderSize);
                baseTextBox.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(baseTextBox.ClientRectangle, borderSize * 2);
                baseTextBox.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (baseTextBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                baseTextBox.Multiline = true;
                baseTextBox.MinimumSize = new Size(txtHeight, txtHeight);
                baseTextBox.Multiline = false;

                this.Height = baseTextBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region -> Overridden methods

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                   
                    if (isFocused || isHovered) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        private void baseTextBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }
        private void baseTextBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }


        #region Private Methods

        public delegate void ButClick(object sender, EventArgs e);
        public delegate void ValChange(object sender, EventArgs e);

        public event ButClick ButtonClickF7;
        public event ButClick ButtonClickF8;

        [Browsable(true)]
        public event EventHandler TextChanged;

        public event ValChange SelectedValueChanched;
        //public event ValChange SelectedItemChanched;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        void _buttonF7_Click(object sender, EventArgs e)
        {
            //if (ButtonClick != null) ButtonClick(this, e);
            ButtonClickF7?.Invoke(this, e);

            var ctrl = ((Control)sender).Parent;
            if (ctrl is LmTextBox && ((LmTextBox)ctrl).valor == LmValueType.Data)
            {
                DateTime dateTime;
                if (!DateTime.TryParse(((LmTextBox)ctrl).Text.FormatarData(), out dateTime))
                    dateTime = DateTime.Now;

                FrmMontCalendar frm = new FrmMontCalendar(dateTime);
                Rectangle areaTrabalho = Screen.GetWorkingArea(this);

                var ptScreen = ctrl.PointToScreen(Point.Empty);

                int locX = ptScreen.X;
                int locY = ptScreen.Y + Height;

                if (locX > areaTrabalho.Right - frm.Width && locY > areaTrabalho.Bottom - frm.Height)
                {
                    locX = ptScreen.X - (frm.Width - ((LmTextBox)ctrl).Width);
                    locY = ptScreen.Y - frm.Height;
                }
                else if (locX > areaTrabalho.Right - frm.Width)
                {
                    locX = ptScreen.X - (frm.Width - ((LmTextBox)ctrl).Width);
                }
                else if (locY > areaTrabalho.Bottom - frm.Height)
                {
                    locY = ptScreen.Y - frm.Height;
                }

                frm.Location = new Point(locX, locY);
                if (frm.ShowDialog() == DialogResult.OK)
                    ((LmTextBox)ctrl).Text = frm.date.ToShortDateString();
            }
            else if (ctrl is LmTextBox && (((LmTextBox)ctrl).valor == LmValueType.ComboBox || ((LmTextBox)ctrl).valor == LmValueType.ComboBox_Enum))
            {
                FrmCaixaComboBox frm = new FrmCaixaComboBox(CmbDados, SelectedItem, SelectedValue, ((LmTextBox)ctrl).valor);
                Rectangle areaTrabalho = Screen.GetWorkingArea(this);

                var ptScreen = ctrl.PointToScreen(Point.Empty);
                ptScreen.Y += ((LmTextBox)ctrl).Height;

                bool paraBaixo = areaTrabalho.Bottom - ptScreen.Y < ptScreen.Y ? false : true;

                int ladoMaior = (areaTrabalho.Bottom - ptScreen.Y) < ptScreen.Y ? ptScreen.Y : areaTrabalho.Bottom - ptScreen.Y;
                int ladoMenor = ladoMaior == ptScreen.Y ? areaTrabalho.Bottom - ptScreen.Y : ptScreen.Y;

                ladoMaior -= 50;

                int cmbHeight = frm.txt.Height + 4;
                foreach (DataGridViewRow r in frm.dgv.Rows)
                    if (cmbHeight < ladoMaior)
                        cmbHeight += r.Height;
                    else break;

                frm.Height = cmbHeight;
                frm.Width = ((LmTextBox)ctrl).Width;

                int posX = ptScreen.X;
                int posY = ptScreen.Y;

                if (paraBaixo || (!paraBaixo && ladoMenor > frm.Height))
                {
                    posY = ptScreen.Y - ((LmTextBox)ctrl).Height;
                }
                else if (!paraBaixo)
                {
                    posY = ptScreen.Y - frm.Height;

                    frm.dgv.Top = 1;
                    frm.txt.Top = frm.Height - ((LmTextBox)ctrl).Height;
                }

                frm.Location = new Point(posX, posY);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (((LmTextBox)ctrl).selectedItem != frm._selectedItem)
                        ((LmTextBox)ctrl).selectedItem = this.SelectedItem = frm._selectedItem;

                    if (((LmTextBox)ctrl).selectedValue != frm._selectedValue)
                        ((LmTextBox)ctrl).selectedValue = this.SelectedValue = frm._selectedValue;

                    ((LmTextBox)ctrl).Text = frm._displayText;
                }
            }

            this.Focus();
        }

        void _buttonF8_Click(object sender, EventArgs e)
        {
            //if (ButtonClick != null) ButtonClick(this, e);
            ButtonClickF8?.Invoke(this, e);
        }

        //void _button_MouseLeave(object sender, EventArgs e)
        //{
        //    //  UseStyleColors = baseTextBox.Focused;
        //    ((LmButton)sender).BackgroundImage = Controles.ApplyInvert(((LmButton)sender).BackgroundImage);
        //    Invalidate();
        //}

        //void _button_MouseEnter(object sender, EventArgs e)
        //{
        //    //  UseStyleColors = true;
        //    ((LmButton)sender).BackgroundImage = Controles.ApplyInvert(((LmButton)sender).BackgroundImage);
        //    Invalidate();
        //}

        void baseTextBox_LostFocus(object sender, EventArgs e)
        {
            // UseStyleColors = false;
            Invalidate();
            this.InvokeLostFocus(this, e);
        }

        void baseTextBox_GotFocus(object sender, EventArgs e)
        {
            //  UseStyleColors = true;
            Invalidate();
            this.InvokeGotFocus(this, e);
        }

        private void UpdateCmbValue()
        {
            //  SelectedValueChanched?.Invoke(baseTextBox, new EventArgs());

            if (SelectedItem == null)
                this.Text = string.Empty;
            else
            {
                if (Valor == LmValueType.ComboBox)
                {
                    foreach (PropertyInfo pro in SelectedItem.GetType().GetProperties().ToList()
                       .Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                    {
                        DataObjectFieldAttribute atb = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                        if (atb != null && atb.IsIdentity == true)
                            this.Text = pro.GetValue(SelectedItem).ToString();
                    }

                    foreach (PropertyInfo pro in SelectedItem.GetType().GetProperties().ToList()
                       .Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                    {
                        DataObjectFieldAttribute atb = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                        if (atb != null && atb.PrimaryKey == true)
                        {
                            var val = pro.GetValue(SelectedItem);

                            if (val is System.Int32 && Convert.ToInt32(SelectedValue) != (int)val)
                                SelectedValue = (int)val;
                            else if (val is System.String && Convert.ToString(SelectedValue) != (string)val)
                                SelectedValue = (string)val;
                        }
                    }
                }
                else if (Valor == LmValueType.ComboBox_Enum)
                {
                    if (Text.RemoverCaracteresEspeciais().ToLower() == ((KeyValuePair<Enum, string>)SelectedItem).Value.RemoverCaracteresEspeciais().ToLower())
                    {
                        this.Text = ((KeyValuePair<Enum, string>)SelectedItem).Value;

                        if (SelectedValue == null || SelectedValue.ToString() != ((KeyValuePair<Enum, string>)SelectedItem).Key.ToString())
                            SelectedValue = ((KeyValuePair<Enum, string>)SelectedItem).Key;
                    }
                }
            }
        }

        private void UpdateCmbItem()
        {
            //  SelectedItemChanched?.Invoke(baseTextBox, new EventArgs());

            if (CmbDados != null)
            {
                if (SelectedValue == null)
                    SelectedItem = null;
                else
                {
                    foreach (var item in CmbDados)
                    {
                        if (Valor == LmValueType.ComboBox)
                        {
                            foreach (PropertyInfo pro in item.GetType().GetProperties().ToList()
                            .Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                            {
                                DataObjectFieldAttribute atb = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                                var val = pro.GetValue(item);
                                if ((atb.PrimaryKey && val is System.Int32 && Convert.ToInt32(SelectedValue).Equals((int)val)) ||
                                    (atb.PrimaryKey && val is System.String && Convert.ToString(SelectedValue).Equals((string)val)))
                                {
                                    if (selectedItem != item)
                                        SelectedItem = item;

                                    GC.Collect();
                                    return;
                                }
                            }
                        }
                        else if (Valor == LmValueType.ComboBox_Enum)
                        {
                            if (SelectedValue.ToString() == ((KeyValuePair<Enum, string>)item).Key.ToString())
                            {
                                Text = ((KeyValuePair<Enum, string>)item).Value;
                                if (SelectedItem != item)
                                    SelectedItem = item;

                                return;
                            }
                        }
                    }
                }
            }
        }

        private void UpdateItemValueByText()
        {
            try
            {
                foreach (var item in CmbDados)
                {
                    if (Valor == LmValueType.ComboBox)
                    {
                        foreach (PropertyInfo pro in item.GetType().GetProperties().ToList().Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                        {
                            DataObjectFieldAttribute atb = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                            if (atb != null && atb.PrimaryKey == true)
                            {
                                if (Int32.TryParse(Text, out int cmbValue))
                                    if (Convert.ToInt32(pro.GetValue(item)) == cmbValue)
                                    {
                                        SelectedValue = cmbValue;
                                        return;
                                    }
                            }
                            else if (atb != null && atb.IsIdentity == true)
                            {
                                if (Text.RemoverCaracteresEspeciais().ToUpper() == pro.GetValue(item).ToString().RemoverCaracteresEspeciais().ToUpper())
                                {
                                    SelectedItem = item;
                                    return;
                                }
                            }
                        }
                    }
                    else if (Valor == LmValueType.ComboBox_Enum)
                    {
                        if (Text.RemoverCaracteresEspeciais().ToLower() == ((KeyValuePair<Enum, string>)item).Value.ToString().RemoverCaracteresEspeciais().ToLower())
                        {
                            //if (SelectedItem != item)
                            SelectedItem = item;

                            return;
                        }
                    }
                }
                MsgBox.ShowToolTip(this, "Digite Código, Texto ou Selecione Item.", "Valor Inválido.");
                this.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.ShowToolTip(this, "Erro... " + ex.Message);
                this.Focus();
            }
        }

        private void DefinirAutoComplete()
        {
            if (!DesignMode)
                if (Valor == LmValueType.ComboBox || Valor == LmValueType.ComboBox_Enum)
                {
                    this.AutoCompleteCustomSource = null;
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
                    foreach (var item in CmbDados)
                    {
                        if (Valor == LmValueType.ComboBox)
                        {
                            foreach (PropertyInfo pro in item.GetType().GetProperties().ToList()
                             .Where(p => p.GetCustomAttribute(typeof(DataObjectFieldAttribute)) != null))
                            {
                                DataObjectFieldAttribute atb = (DataObjectFieldAttribute)pro.GetCustomAttribute(typeof(DataObjectFieldAttribute));
                                if (atb != null && atb.IsIdentity == true)
                                {
                                    ac.Add(Convert.ToString(pro.GetValue(item)));
                                }
                            }
                        }
                        else if (Valor == LmValueType.ComboBox_Enum)
                        {
                            ac.Add(((KeyValuePair<Enum, string>)item).Value);
                        }
                    }

                    this.AutoCompleteCustomSource = ac;
                    this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    this.AutoCompleteCustomSource = null;
                    this.AutoCompleteMode = AutoCompleteMode.None;
                    this.AutoCompleteSource = AutoCompleteSource.None;
                }
        }

        #endregion


    }
}
