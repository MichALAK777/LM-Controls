using LMControls.LmDesign;
using LMControls.LmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls
{
    public partial class LmImputBox : LmSingleForm
    {
        public LmImputBox(string message, string titulo, string texto, LmValueType cmxValueType, bool textoLongo, bool Centralizar)
        {
            InitializeComponent();
            this.Text = titulo;

            if (cmxValueType == LmValueType.Senha)
                this.txt.UseSystemPasswordChar = true;
            else
                this.txt.Valor = cmxValueType;

            lblTitulo.Text = titulo;
            lblDesc.Text = message;
            txt.Text = texto;

            if (string.IsNullOrEmpty(titulo))
            {
                Height -= 20;
                lblDesc.Top -= 20;
                txt.Top -= 20;
                btnConfirmar.Top = btnCancelar.Top -= 20;
            }
            if (string.IsNullOrEmpty(message))
            {
                txt.Top -= 6;
                btnConfirmar.Top = btnCancelar.Top -= 6;
            }

            if (textoLongo)
            {
                this.txt.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);

                this.Width += 150;
                this.Height += 128;
                txt.Height += 98;

                btnConfirmar.Top = btnCancelar.Top = txt.Top + txt.Height + 5;

                txt.Multiline = true;

                txt.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

                txt.ShowButtonF7 = txt.ShowButtonF8 = false;

                btnConfirmar.Visible = btnCancelar.Visible = true;

                this.txt.ScrollBars = ScrollBars.Both;
                this.Resizable = true;
            }

            if (!Centralizar)
            {
                Rectangle areaTrabalho = Screen.GetWorkingArea(this);
                Point p = Cursor.Position;
                if (p.Y > Height + 100)
                    p.Y -= Height;
                if (p.X > areaTrabalho.Width - Width)
                    p.X -= Width;
                Location = p;
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void Txt_ButtonClickF7(object sender, EventArgs e)
        {
            if (txt.CampoObrigatorio && string.IsNullOrEmpty(txt.Text))
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Txt_ButtonClickF8(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Txt_ButtonClickF7(txt, new EventArgs());
        }

        private void LmImputBox_SizeChanged(object sender, EventArgs e)
        {
            txt.Refresh();
        }
    }
}
