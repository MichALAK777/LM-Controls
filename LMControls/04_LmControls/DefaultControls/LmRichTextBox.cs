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
    [DefaultEvent("TextChanged")]
    public partial class LmRichTextBox : RichTextBox, ILmControl
    {
        #region Construtor

        public LmRichTextBox()
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

        #region Private Metodos

        private void StyleList()
        {
            Font fRow = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.Font = fRow;

            this.BackColor = LmPaint.BackColor.GridView.CellNormal(Theme);
            this.ForeColor =this.BackColor.GetForeColor(LmControlStatus.Normal) ;
        }

        #endregion

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (this.Enabled)
            {
                this.BackColor = LmPaint.BackColor.GridView.CellNormal(Theme);
                this.ForeColor = this.BackColor.GetForeColor(LmControlStatus.Normal);
                //  MessageBox.Show("Aberto");
            }
            else
            {
                this.BackColor = LmPaint.BackColor.TextBox.Disabled(Theme);
                this.ForeColor = this.BackColor.GetForeColor(LmControlStatus.Disabled);
                // MessageBox.Show("Fechado");
            }
            Refresh();

        }

    }
}
