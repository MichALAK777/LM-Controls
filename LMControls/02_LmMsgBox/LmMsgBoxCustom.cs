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
    public partial class LmMsgBoxCustom : LmSingleForm
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
        MessageBoxIcon _icon = MessageBoxIcon.None;

        string _textoBotao1 = string.Empty;
        string _textoBotao2 = string.Empty;
        string _textoBotao3 = string.Empty;
        FontAwesome.Sharp.IconChar _iconButton1 = FontAwesome.Sharp.IconChar.None;
        FontAwesome.Sharp.IconChar _iconButton2 = FontAwesome.Sharp.IconChar.None;
        FontAwesome.Sharp.IconChar _iconButton3 = FontAwesome.Sharp.IconChar.None;

        public LmMsgBoxCustom(string Texto, string Titulo, MessageBoxIcon msgBoxIcon,
            string textoBotao1, string textoBotao2, string textoBotao3,
            FontAwesome.Sharp.IconChar iconButton1, FontAwesome.Sharp.IconChar iconButton2, FontAwesome.Sharp.IconChar iconButton3)
        {
            InitializeComponent();

            Text = Titulo;// Texto;

            _textoBotao1 = textoBotao1;
            _textoBotao2 = textoBotao2;
            _textoBotao3 = textoBotao3;
            _iconButton1 = iconButton1;
            _iconButton2 = iconButton2;
            _iconButton3 = iconButton3;

            textoMensagem = Texto;
            textoTitulo = Titulo;
            _icon = msgBoxIcon;
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

                FormatarBotoes();
                PosicionarRedimencionarForm();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void FormatarBotoes()
        {
            if (string.IsNullOrEmpty(_textoBotao2))
                btnOpcao2.Visible = false;
            if (string.IsNullOrEmpty(_textoBotao3))
                btnOpcao3.Visible = false;

            var tamanhoTexto = _textoBotao1.Length;

            if (tamanhoTexto < _textoBotao2.Length)
                tamanhoTexto = _textoBotao2.Length;
            if (tamanhoTexto < _textoBotao3.Length)
                tamanhoTexto = _textoBotao3.Length;

            if (tamanhoTexto > 20)
                btnOpcao1.Width = btnOpcao2.Width = btnOpcao3.Width = 190;
            else if (tamanhoTexto > 15)
                btnOpcao1.Width = btnOpcao2.Width = btnOpcao3.Width = 160;
            else if (tamanhoTexto > 10)
                btnOpcao1.Width = btnOpcao2.Width = btnOpcao3.Width = 130;
            else
                btnOpcao1.Width = btnOpcao2.Width = btnOpcao3.Width = 100;

            btnOpcao1.Text = " " + _textoBotao1;
            btnOpcao2.Text = " " + _textoBotao2;
            btnOpcao3.Text = " " + _textoBotao3;

            if (_iconButton1 != FontAwesome.Sharp.IconChar.None)
                btnOpcao1.IconChar = _iconButton1;
            else
                btnOpcao1.ImageAlign = ContentAlignment.MiddleCenter;

            if (_iconButton2 != FontAwesome.Sharp.IconChar.None)
                btnOpcao2.IconChar = _iconButton2;
            else
                btnOpcao2.ImageAlign = ContentAlignment.MiddleCenter;

            if (_iconButton3 != FontAwesome.Sharp.IconChar.None)
                btnOpcao3.IconChar = _iconButton3;
            else
                btnOpcao3.ImageAlign = ContentAlignment.MiddleCenter;
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

            }
            catch (Exception)
            {
            }
        }

        private void LmMsgBoxCustom_KeyDown(object sender, KeyEventArgs e)
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
