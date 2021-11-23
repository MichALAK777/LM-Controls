using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    public partial class LmMenuJanelaAberta : UserControl, ILmControl
    {
        #region Construtor

        public LmMenuJanelaAberta()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
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

                this.Theme = lmStyleManager.Theme;
                this.BackColor = LmPaint.BackColor.MenuJanelaAberta.JanelaAberta(this.Theme);
            }
        }

        #endregion

        #region Paint Method

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            this.BackColor = LmPaint.BackColor.MenuJanelaAberta.JanelaAberta(this.Theme);
        }

        #endregion

        #region Metodos Publicos

        public void Removejanela(string name)
        {
            this.flpMain.Controls.RemoveByKey(name);
        }

        public void FocarContainer(string name)
        {
            foreach (var ctrl in flpMain.Controls)
            {
                if (ctrl is LmJanelaAberta)
                {
                    var container = this.Parent.Controls["pnlMain"].Controls[((LmJanelaAberta)ctrl).Name] as LmForms.LmContainerForm;

                    Invoke(new MethodInvoker(delegate ()
                    {
                        if (((LmJanelaAberta)ctrl).Name == name)
                        {
                            container.BringToFront();
                            ((LmJanelaAberta)ctrl).IsSelected = true;

                            var frm = container.Controls[0] as LmForms.LmChildForm;

                            frm._lastFocusedControl?.Focus();
                        }
                        else
                        {
                            ((LmJanelaAberta)ctrl).IsSelected = false;
                            container.SendToBack();
                        }

                        ((LmJanelaAberta)ctrl).Refresh();
                    }));

                }
            }
        }

        #endregion

        private void FlpMain_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control.Location.Y > 60)
                this.Height = 4 * 22;
            else if (e.Control.Location.Y > 40)
                this.Height = 3 * 22;
            else if (e.Control.Location.Y > 20)
                this.Height = 2 * 22;
            else
                this.Height = 22;

            ((LmJanelaAberta)e.Control).ClickJanela += LmMenuJanelaAberta_ClickJanela;
        }

        private void LmMenuJanelaAberta_ClickJanela(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(() => { this.FocarContainer(((Control)sender).Name); }) { IsBackground = true };
            t.Start();
        }

        private void FlpMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (this.Height == 22) return;

            var maxY = 0;

            foreach (Control ctrl in flpMain.Controls)
                if (ctrl.Location.Y > maxY)
                    maxY = ctrl.Location.Y;

            if (maxY > 60)
                this.Height = 4 * 22;
            else if (maxY > 40)
                this.Height = 3 * 22;
            else if (maxY > 20)
                this.Height = 2 * 22;
            else
                this.Height = 22;
        }
    }
}
