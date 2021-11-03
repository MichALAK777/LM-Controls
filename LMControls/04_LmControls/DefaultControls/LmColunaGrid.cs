using LMControls.LmDesign;
using LMControls.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    public partial class LmColunaGrid : UserControl
    {
        public delegate void MouseEventArgsCtrl(object sender, MouseEventArgs e);
        public delegate void Click(object sender, EventArgs e);
        public event Click MoverParaOculto;
        public event Click MoverParaVisivel;
        public event MouseEventArgsCtrl MouseDownCtrl;

        public LmColunaGrid(LmTheme Tema, bool colunaVisivel)
        {
            InitializeComponent();

            if (colunaVisivel)
            {
                this.Anchor = AnchorStyles.None;

                this.toolTip1.SetToolTip(this.lnkExcluir, "Mover para Colunas Ocultas");
                lnkExcluir.Dock = DockStyle.Right;
                lnkExcluir.Image = Properties.Resources.seta_cheia_frente_15px;
                lnkExcluir.Click += LnkMoverParaOculto_Click;
            }
            else
            {
                this.Anchor = AnchorStyles.None;

                this.toolTip1.SetToolTip(this.lnkExcluir, "Mover para Colunas Visíveis");
                lnkExcluir.Dock = DockStyle.Left;
                lnkExcluir.Image = Properties.Resources.seta_cheia_traz_15px;
                lnkExcluir.Click += LnkMoverParaVisivel_Click;
            }

            Thread t = new Thread(() => { AplicarTema(Tema); }) { IsBackground = true };
            t.Start();
        }

        private void AplicarTema(LmTheme Tema)
        {
            Color bcColor = LmPaint.BackColor.Button.Normal(Tema);

            lblDescricao.BackColor = bcColor;
            this.Tag = bcColor;
            this.lblDescricao.ForeColor = bcColor.IsDarkColor() ? Color.FromArgb(244, 242, 240) : Color.FromArgb(44, 42, 40);
            if (bcColor.IsDarkColor())
                lnkExcluir.Image = Metodos.Controles.ApplyInvert(lnkExcluir.Image);
        }

        private void UcPratosDoDia_Load(object sender, EventArgs e)
        {
        }

        private void LnkExcluir_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void LnkMoverParaOculto_Click(object sender, EventArgs e)
        {
            MoverParaOculto?.Invoke(this, new EventArgs());
        }

        private void LnkMoverParaVisivel_Click(object sender, EventArgs e)
        {
            MoverParaVisivel?.Invoke(this, new EventArgs());
        }

        private void LblDescricao_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownCtrl?.Invoke(this, e);
        }

        private void UcColunaGrid_MouseEnter(object sender, EventArgs e)
        {
            lblDescricao.Font = new Font(lblDescricao.Font, FontStyle.Bold);

            Color bcColor = lblDescricao.BackColor;

            if (bcColor.IsDarkColor())
                lblDescricao.BackColor = Color.FromArgb(bcColor.R + 30, bcColor.G + 30, bcColor.B + 30);
            else
                lblDescricao.BackColor = Color.FromArgb(bcColor.R - 30, bcColor.G - 30, bcColor.B - 30);
        }

        private void UcColunaGrid_MouseLeave(object sender, EventArgs e)
        {
            lblDescricao.Font = new Font(lblDescricao.Font, FontStyle.Regular);

            lblDescricao.BackColor = (Color)this.Tag;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

    }
}
