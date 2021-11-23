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
    [DefaultEvent("SelectedIndexChanged")]
    public partial class LmListBox : ListBox, ILmControl
    {
        #region Construtor

        public LmListBox()
        {
            StyleList();

            this.DoubleBuffered = true;
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
            set { lmStyleManager = value; StyleList(); }
        }

        #endregion

        #region Paint Metodos

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen p = new Pen(LmPaint.BackColor.FormHeader(Theme)))
            {
                p.Width = 3;
                e.Graphics.DrawRectangle(p, new Rectangle(0, 0, Width - 2, Height - 2));
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            //e.BackColor = Color.AliceBlue;

        }

        #endregion

        #region Private Metodos

        private void StyleList()
        {
            Font fRow = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.Font = fRow;

            this.BackColor = LmPaint.BackColor.GridView.CellNormal(Theme);
            this.ForeColor = BackColor.GetForeColor(LmControlStatus.Normal);

            this.BorderStyle = BorderStyle.FixedSingle;
        }

        #endregion
    }
}
