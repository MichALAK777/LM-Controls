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
    [DefaultEvent("ItemClicked")]
    public partial class LmStatusStrip : StatusStrip, ILmControl
    {
        #region Construtor/Inicializacao

        public LmStatusStrip()
        {
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 8.25F);
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
            set
            {
                lmTheme = value;
                Invalidate();
            }
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

                foreach (var item in this.Items)
                {
                    if (item is ToolStripStatusLabel)
                    {
                        if (Convert.ToString(((ToolStripStatusLabel)item).Tag) != "MsgRodape")
                        {
                            var corHead = LmPaint.BackColor.FormHeader(Theme);

                            ((ToolStripStatusLabel)item).ForeColor = corHead.GetForeColor(LmControlStatus.Normal);
                        }
                    }
                }


            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var corHead = LmPaint.BackColor.FormHeader(Theme);
            this.BackColor = corHead;
            this.ForeColor = corHead.GetForeColor(LmControlStatus.Normal);
        }
    }
}
