using LMControls.LmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls
{
    public partial class LmMsgBox : LmSingleForm
    {
        Color clrDeft = Color.FromArgb(241, 241, 241);
        Color clrInfo = Color.FromArgb(221, 242, 249);
        Color clrQues = Color.FromArgb(209, 236, 242);
        Color clrWarn = Color.FromArgb(255, 243, 205);
        Color clrErro = Color.FromArgb(248, 215, 218);

        Color clrDeftBC = Color.FromArgb(143, 143, 143);
        Color clrInfoBC = Color.FromArgb(29, 166, 211);
        Color clrQuesBC = Color.FromArgb(60, 176, 118);
        Color clrWarnBC = Color.FromArgb(217, 171, 13);
        Color clrErroBC = Color.FromArgb(230, 66, 79);

        Color clrDeftFC = Color.FromArgb(82, 87, 90);
        Color clrInfoFC = Color.FromArgb(63, 115, 171);
        Color clrQuesFC = Color.FromArgb(73, 128, 86);
        Color clrWarnFC = Color.FromArgb(144, 114, 38);
        Color clrErroFC = Color.FromArgb(139, 62, 69);


        Color clrDeftBorder = Color.FromArgb(82, 87, 90);

        string textoMensagem = "", textoTitulo = "";
        MessageBoxButtons _buton = MessageBoxButtons.OK;
        MessageBoxIcon _icon = MessageBoxIcon.None;
        string _textoBotao1;
        string _textoBotao2;
        string _textoBotao3;

        public LmMsgBox(string Texto, string Titulo, MessageBoxButtons MessageBoxButtons, MessageBoxIcon msgBoxIcon,
            ContentAlignment alinhamentoTitulo, ContentAlignment alinhamentoCorpo,
            string textoBotao1, string textoBotao2, string textoBotao3)
        {
            InitializeComponent();

            Text = Titulo;

            lblTitulo.TextAlign = alinhamentoTitulo;
            lblTexto.TextAlign = alinhamentoCorpo;
            _textoBotao1 = textoBotao1;
            _textoBotao2 = textoBotao2;
            _textoBotao3 = textoBotao3;

            textoMensagem = Texto;
            textoTitulo = Titulo;
            _icon = msgBoxIcon;
            _buton = MessageBoxButtons;
            AtribuirValores();
        }

        private void AtribuirValores()
        {
            try
            {
                lblTitulo.Text = textoTitulo;

                lblTexto.Text = textoMensagem.Replace("\t", "        ");

                switch (_icon)
                {
                    case MessageBoxIcon.Information:
                        ptbIcone.IconChar = FontAwesome.Sharp.IconChar.Info;
                        clrDeftBorder = clrInfoBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrInfo;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrInfoFC;
                        this.StyleManager.Theme = LmDesign.LmTheme.Azul;
                        break;
                    case MessageBoxIcon.Warning:
                        ptbIcone.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
                        clrDeftBorder = clrWarnBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrWarn;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrWarnFC;
                        this.StyleManager.Theme = LmDesign.LmTheme.Amarelo;
                        break;
                    case MessageBoxIcon.Question:
                        ptbIcone.IconChar = FontAwesome.Sharp.IconChar.Question;
                        clrDeftBorder = clrQuesBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrQues;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrQuesFC;
                        this.StyleManager.Theme = LmDesign.LmTheme.Verde;
                        break;
                    case MessageBoxIcon.Error:
                        ptbIcone.IconChar = FontAwesome.Sharp.IconChar.Bug;
                        clrDeftBorder = clrErroBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrErro;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrErroFC;
                        this.StyleManager.Theme = LmDesign.LmTheme.Vermelho;
                        break;
                    case MessageBoxIcon.None:
                        clrDeftBorder = clrDeftBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrDeft;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrDeftFC;
                        pnlPrincipal.Controls.RemoveByKey(ptbIcone.Name);
                        this.StyleManager.Theme = LmDesign.LmTheme.Cinza;
                        break;
                    default:
                        clrDeftBorder = clrDeftBC;
                        pnlPrincipal.BackColor = lblTexto.BackColor = clrDeft;
                        lblTexto.ForeColor = lblTitulo.ForeColor = clrDeftFC;
                        pnlPrincipal.Controls.RemoveByKey(ptbIcone.Name);
                        this.StyleManager.Theme = LmDesign.LmTheme.Cinza;
                        break;
                }

                flpBotoes.BackColor = Color.FromArgb(
                    pnlPrincipal.BackColor.R - 5, pnlPrincipal.BackColor.G - 5, pnlPrincipal.BackColor.B - 5);

                var sep = pnlPrincipal.Controls.ContainsKey(ptbIcone.Name)
                    ? Environment.NewLine + string.Empty.PadRight(70, '_') + Environment.NewLine
                    : Environment.NewLine + string.Empty.PadRight(80, '_') + Environment.NewLine;

                lblTexto.Text = lblTexto.Text
                    .Replace("<sep>", "<SEP>")
                    .Replace("<sEp>", "<SEP>")
                    .Replace("<seP>", "<SEP>")
                    .Replace("<sEP>", "<SEP>")
                    .Replace("<Sep>", "<SEP>")
                    .Replace("<SEp>", "<SEP>")
                    .Replace("<SeP>", "<SEP>")
                    .Replace("<SEP>", sep);

                PosicionarRedimencionarForm();

                switch (_buton)
                {
                    case MessageBoxButtons.OK:
                        btnOk.Visible = true;
                        //PosicionarButtons(btnOk);
                        btnOk.Text = !string.IsNullOrEmpty(_textoBotao1) ? _textoBotao1 : btnOk.Text;
                        break;
                    case MessageBoxButtons.OKCancel:
                        btnOk.Visible = true;
                        btnCancel.Visible = true;
                        btnOk.Text = !string.IsNullOrEmpty(_textoBotao1) ? _textoBotao1 : btnOk.Text;
                        btnCancel.Text = !string.IsNullOrEmpty(_textoBotao2) ? _textoBotao2 : btnCancel.Text;
                        //PosicionarButtons(btnOk, btnCancel);
                        btnCancel.Select();
                        break;
                    case MessageBoxButtons.YesNo:
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                        btnYes.Text = !string.IsNullOrEmpty(_textoBotao1) ? _textoBotao1 : btnYes.Text;
                        btnNo.Text = !string.IsNullOrEmpty(_textoBotao2) ? _textoBotao2 : btnNo.Text;
                        //PosicionarButtons(btnYes, btnNo);
                        btnNo.Select();
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                        btnCancel.Visible = true;
                        btnYes.Text = !string.IsNullOrEmpty(_textoBotao1) ? _textoBotao1 : btnYes.Text;
                        btnNo.Text = !string.IsNullOrEmpty(_textoBotao2) ? _textoBotao2 : btnNo.Text;
                        btnCancel.Text = !string.IsNullOrEmpty(_textoBotao3) ? _textoBotao3 : btnCancel.Text;
                        //PosicionarButtons(btnYes, btnNo, btnCancel);
                        btnCancel.Select();
                        break;
                    case MessageBoxButtons.RetryCancel:
                        btnRetry.Visible = true;
                        btnCancel.Visible = true;
                        btnRetry.Text = !string.IsNullOrEmpty(_textoBotao1) ? _textoBotao1 : btnRetry.Text;
                        btnCancel.Text = !string.IsNullOrEmpty(_textoBotao2) ? _textoBotao2 : btnCancel.Text;
                        //PosicionarButtons(btnRetry, btnCancel);
                        btnCancel.Select();
                        break;
                    case MessageBoxButtons.AbortRetryIgnore:
                        btnRetry.Visible = true;
                        btnIgnore.Visible = true;
                        btnRetry.Text = !string.IsNullOrEmpty(_textoBotao2) ? _textoBotao2 : btnRetry.Text;
                        btnIgnore.Text = !string.IsNullOrEmpty(_textoBotao3) ? _textoBotao3 : btnIgnore.Text;
                        //PosicionarButtons(btnAbort, btnRetry, btnIgnore);
                        btnIgnore.Select();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void PosicionarRedimencionarForm()
        {
            try
            {
                lblTexto.MaximumSize = new Size(lblTitulo.Width, 2000);
                lblTexto.MinimumSize = new Size(lblTitulo.Width, 10);

                Height = lblTitulo.Height + flpBotoes.Height + lblTexto.Height + 2;

                if (Height > 700)
                {
                    System.Diagnostics.Debug.Print($"Scroll Ativado, tamanho calculado: {Height} - alterado para: 700");

                    Height = 700;
                }

                Rectangle areaTrabalho = Screen.GetWorkingArea(this);

                if (InfoDefaultUI.DefaultMsgType == LmDesign.LmMessageType.InTaskBar)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    Location = new Point(areaTrabalho.Right - Size.Width, areaTrabalho.Bottom - Size.Height);
                }
            }
            catch (Exception)
            {
            }
        }

        private void LmMsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.None;
                Close();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(lblTexto.Text);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, (int)Native.WinApi.Messages.WM_NCLBUTTONDOWN, (int)Native.WinApi.Messages.WM_DESTROY, 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.BackColor = ptbIcone.IconColor = clrDeftBorder;

            using (Pen p = new Pen(clrDeftBorder))
            {
                p.Width = 1;
                e.Graphics.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
    }
}
