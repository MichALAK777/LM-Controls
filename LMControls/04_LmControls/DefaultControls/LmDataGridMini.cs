using LMControls.Components;
using LMControls.Interfaces;
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

namespace LMControls.LmControls
{
    public class LmDataGridMini : DataGridView, ILmControl
    {
        #region Construtor

        public LmDataGridMini()
        {
            StyleGrid();

            this.DoubleBuffered = true;
            this.MouseDown += LmDataGridMini_MouseDown;
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
            set { lmTheme = value; }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set { lmStyleManager = value; StyleGrid(); }
        }

        #endregion

        #region Eventos

        private void LmDataGridMini_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = this.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    this[hit.ColumnIndex, hit.RowIndex].Selected = true;
                }
            }
        }

        /// <summary>
        /// Inserir Highlight
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            if (this.RectangleToScreen(e.RowBounds).Contains(MousePosition))
            {
                using (var b = new SolidBrush(Color.FromArgb(50, LmPaint.BackColor.GridView.CellSelected(Theme))))
                {
                    var r = e.RowBounds; r.Width -= 1; r.Height -= 1;
                    e.Graphics.FillRectangle(b, r);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e); this.Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e); this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e); this.Invalidate();
        }
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e); this.Invalidate();
        }

        #endregion

        #region Private Metodos

        private void StyleGrid()
        {
            Font fRow = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            this.EnableHeadersVisualStyles = false;
            //this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.BackgroundColor = LmPaint.BackColor.Form(Theme);
            this.GridColor = LmPaint.BackColor.Form(Theme);
            this.ForeColor = BackgroundColor.GetForeColor(LmControlStatus.Normal);
            this.Font = fRow;

            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            this.RowHeadersVisible = false;
            this.MultiSelect = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeRows = false;

            // Estilo do Cabeçalho Coluna
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Outset;
            //this.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Inset;
            this.ColumnHeadersDefaultCellStyle.Font = fHeader;
            this.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle.BackColor = LmPaint.BackColor.GridView.Header(Theme);
            this.ColumnHeadersDefaultCellStyle.ForeColor = this.ColumnHeadersDefaultCellStyle.BackColor.GetForeColor(LmControlStatus.Normal);
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = LmPaint.BackColor.GridView.Header(Theme);
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = this.ColumnHeadersDefaultCellStyle.SelectionBackColor.GetForeColor(LmControlStatus.Normal);

            // Estilo do Cabeçalho Linha
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.RowHeadersDefaultCellStyle.BackColor = LmPaint.BackColor.GridView.Header(Theme);
            this.RowHeadersDefaultCellStyle.ForeColor = this.RowHeadersDefaultCellStyle.BackColor.GetForeColor(LmControlStatus.Normal);
            this.RowHeadersDefaultCellStyle.SelectionBackColor = LmPaint.BackColor.GridView.Header(Theme);
            this.RowHeadersDefaultCellStyle.SelectionForeColor = this.RowHeadersDefaultCellStyle.SelectionBackColor.GetForeColor(LmControlStatus.Normal);

            // Estilo da Celula
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle.BackColor = LmPaint.BackColor.GridView.CellNormal(Theme);
            this.DefaultCellStyle.ForeColor = this.DefaultCellStyle.BackColor.GetForeColor(LmControlStatus.Normal);
            this.DefaultCellStyle.SelectionBackColor = LmPaint.BackColor.GridView.CellSelected(Theme);
            this.DefaultCellStyle.SelectionForeColor = this.DefaultCellStyle.SelectionBackColor.GetForeColor(LmControlStatus.Selected);
        }

        #endregion
    }
}
