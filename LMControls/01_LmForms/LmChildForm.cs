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
    public partial class LmChildForm : Form, ILmForm, IDisposable
    {
        internal Control _lastFocusedControl = null;

        #region Constructor

        public LmStyleManager Estilo = new LmStyleManager();
        public LmChildForm()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.UserPaint, true);

            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoScroll = true;
            this.Name = "LmChildForm";
            this.TransparencyKey = Color.Magenta;

            StyleManager = Estilo;
            Estilo.Owner = this;
            Estilo.Theme = InfoDefaultUI.DefaultStyle;
            Estilo.TipoMensagem = InfoDefaultUI.DefaultMsgType;

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(150, 150);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void PnlTransparent_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Formulário bloqueado para edição", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
        [DefaultValue(true)]
        [Browsable(true)]
        public bool CloseOnEscape { get; set; } = true;

        [Browsable(false)]
        public string MenuStripName { get; set; } = null;

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
            get { return new Padding(3, 3, 3, 3); }
        }

        private Modo _modo = Modo.Padrao;
        [Browsable(false)]
        public Modo Modo
        {
            get { return _modo; }
            set
            {
                _modo = value;

                if (_modo == Modo.Novo)
                {
                    AtualizarPrimaria(tornarSomenteLeitura: false);
                    MensagemRodape = "Inserindo Novo Registro";
                }
                else if (_modo == Modo.Alteracao)
                {
                    AtualizarPrimaria(tornarSomenteLeitura: true);
                    MensagemRodape = "Alterando Registro";
                }
                else if (_modo == Modo.EmLock)
                {
                    AtualizarPrimaria(tornarSomenteLeitura: true);
                    MensagemRodape = "Em Lock";
                }
                else if (_modo == Modo.Bloqueado)
                {
                    AtualizarPrimaria(tornarSomenteLeitura: true);
                    MensagemRodape = "Bloqueado";
                }
                else
                {
                    MensagemRodape = "";
                }

                //this.AtualizarStatusLabel?.Invoke(this, new EventArgs());

                Invalidate();
            }
        }

        /// <summary>
        /// Nome do controle usado como Chave primaria
        /// </summary>
        [Browsable(true)]
        public LmTextBox ChavePrimaria { get; set; } = null;

        private string mensagemRodape;

        [DefaultValue(Modo.Padrao)]
        [Browsable(false)]
        public string MensagemRodape
        {
            get { return mensagemRodape; }
            set
            {
                mensagemRodape = value;
                Invalidate();
            }
        }

        [DefaultValue(false)]
        [Browsable(false)]
        public bool IsClosing { get; set; } = false;

        [DefaultValue(false)]
        [Browsable(false)]
        private bool isSelected;

        [DefaultValue(false)]
        [Browsable(false)]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;

                if (IsClosing) return;

                if (IsSelected && this.Parent != null && this.Name != "LmChildForm")
                {
                    foreach (Control ctrl in this.Parent?.Controls)
                    {
                        if (ctrl is LmChildForm form && form.Name != this.Name && form.IsSelected)
                            form.IsSelected = false;
                    }

                    if (this.AguardandoAtualizacaoDados)
                    {
                        this.AtualizarDados.Invoke(this, new EventArgs());
                        this.AguardandoAtualizacaoDados = false;
                    }
                   if (_lastFocusedControl != null)
                        _lastFocusedControl.Focus();

                }
            }
        }

        [DefaultValue(false)]
        [Browsable(false)]
        public bool aguardandoAtualizacaoDados = false;

        public bool AguardandoAtualizacaoDados
        {
            get { return aguardandoAtualizacaoDados; }
            set
            {
                aguardandoAtualizacaoDados = value;

                if (this.AguardandoAtualizacaoDados)
                {
                    if (IsSelected)
                    {
                        this.AtualizarDados.Invoke(this, new EventArgs());
                        this.AguardandoAtualizacaoDados = false;
                    }
                }
                Refresh();
            }
        }

        #endregion

        #region Eventos

        public delegate void FormSelect(object sender, EventArgs e);
        public delegate void FormLoad(object sender, EventArgs e);

        public event FormSelect AtualizarDados;
        public event FormLoad Loaded;
        public event FormLoad Loading;

        #endregion

        #region Paint Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            BackColor = LmPaint.BackColor.Form(this.Theme);
        }

        #endregion

        #region Metodos de Gestão

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            IsSelected = true;

            try
            {


            }
            catch (Exception)
            {
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape && CloseOnEscape)
            {
                try
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                AguardandoAtualizacaoDados = false;
                IsClosing = true;
            }
            catch (Exception)
            {
            }
        }

        internal void OnLoading()
        {
            Loading?.Invoke(this, new EventArgs());
        }

        internal void OnLoaded()
        {
            System.Threading.Thread.Sleep(300);

            try
            {
                System.Threading.Thread.Sleep(200);

                if (this.IsClosing) return;

                if (ChavePrimaria != null)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        ChavePrimaria.Focus();
                        ChavePrimaria.Refresh();
                    }));
                }

                Loaded?.Invoke(this, new EventArgs());

                //Invoke(new MethodInvoker(delegate ()
                //{
                //    _lastFocusControl = this.ActiveControl;
                //}));
            }
            catch (InvalidOperationException ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                MsgBox.Show("Evento Load deve manipular Objetos com 'Invoke', informar Desenvolvedores",
                    "Erro ao Carregar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodos Públicos

        /// <summary>
        /// Metodo Para Abrir Formulario LmForm Como Irmao
        /// </summary>
        /// <param name="form">Deve ser do Tipo LmForm</param>
        public void OpenFormBrother(LmChildForm form)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var frmContainer = this.Parent as LmContainerForm;

                if (frmContainer != null)
                {
                    if (frmContainer.Controls.ContainsKey(form.Name))
                    {
                        var frmPrincipal = this.TopLevelControl as LmMainForm;

                        frmPrincipal.OpenFormChild(form);
                    }

                    if (!frmContainer.Controls.ContainsKey(form.Name))
                    {
                        if (frmContainer.Controls.Count > 12)
                        {
                            MsgBox.Show("O Lizard Permite trabalhar com no máximo Doze(12) Janelas ao mesmo tempo.\nFeche algumas janelas para continuar.",
                                "Limite de janelas atingido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cursor = Cursors.Default;
                            return;
                        }

                        this.IsSelected = false;
                        form.IsSelected = true;

                        form.Dock = DockStyle.Fill;

                        form.Modo = Modo.Novo;
                        form.OnLoading();
                        form.TopLevel = false;
                        form.Parent = frmContainer;

                        form.BringToFront();

                        frmContainer.Controls.Add(form);
                        frmContainer.Controls[form.Name].BringToFront();

                        System.Threading.Thread t2 = new System.Threading.Thread(() => { form.OnLoaded(); }) { IsBackground = true };
                        t2.Start();

                        form.Show();
                    }
                }
                else
                {
                    MsgBox.Show("Container do Formulário não encontrado.\nContate administrador do sistema.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Erro: " + ex.Message);
                MsgBox.Show($"Não foi possível abrir o formulário \"{form.Text}\"", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        public bool PodeExcluir()
        {
            bool podeExcluir = this.Modo == Modo.Novo ? false :
             MsgBox.Show("Deseja Realmente Excluir Este Registro?", "Excluir",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? true : false;

            if (podeExcluir)
                this.Modo = Modo.Exclusao;

            return podeExcluir;
        }

        #endregion

        #region Metodos Privados

        public void AtualizarPrimaria(bool tornarSomenteLeitura, string texto = "")
        {
            if (ChavePrimaria != null)
            {
                ChavePrimaria.ReadOnly = tornarSomenteLeitura;

                if (!string.IsNullOrEmpty(texto))
                    ChavePrimaria.Text = texto;

                ChavePrimaria.Refresh();
            }
            else
                Controles.UpdatePrimaryKeyControl(this, tornarSomenteLeitura);
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LmChildForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "LmChildForm";
            this.ResumeLayout(false);

        }
    }
}
