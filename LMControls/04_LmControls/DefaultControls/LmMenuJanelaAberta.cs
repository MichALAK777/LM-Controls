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

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaintBackground;
        protected virtual void OnCustomPaintBackground(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaintBackground != null)
            {
                CustomPaintBackground(this, e);
            }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaint;
        protected virtual void OnCustomPaint(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaint != null)
            {
                CustomPaint(this, e);
            }
        }

        [Category(LmDefault.PropertyCategory.LmUI)]
        public event EventHandler<LmPaintEventArgs> CustomPaintForeground;
        protected virtual void OnCustomPaintForeground(LmPaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint) && CustomPaintForeground != null)
            {
                CustomPaintForeground(this, e);
            }
        }

        private LmTheme cmxTheme = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(LmTheme.Padrao)]
        public LmTheme Theme
        {
            get
            {
                if (DesignMode || cmxTheme != LmTheme.Padrao)
                {
                    return cmxTheme;
                }

                if (StyleManager != null && cmxTheme == LmTheme.Padrao)
                {
                    return StyleManager.Theme;
                }
                if (StyleManager == null && cmxTheme == LmTheme.Padrao)
                {
                    return LmDefault.Theme;
                }

                return cmxTheme;
            }
            set
            {
                cmxTheme = value;
            }
        }

        private LmStyleManager cmxStyleManager = null;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LmStyleManager StyleManager
        {
            get { return cmxStyleManager; }
            set
            {
                cmxStyleManager = value;

                this.Theme = cmxStyleManager.Theme;

            }
        }

        private bool useCustomBackColor = false;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseCustomBackColor
        {
            get { return useCustomBackColor; }
            set { useCustomBackColor = value; }
        }

        private bool useCustomForeColor = false;
        [DefaultValue(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        public bool UseCustomForeColor
        {
            get { return useCustomForeColor; }
            set { useCustomForeColor = value; }
        }

        [Browsable(false)]
        [Category(LmDefault.PropertyCategory.LmUI)]
        [DefaultValue(false)]
        public bool UseSelectable
        {
            get { return GetStyle(ControlStyles.Selectable); }
            set { SetStyle(ControlStyles.Selectable, value); }
        }

        #endregion

        #region Paint Method

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            this.BackColor = LmPaint.BackColor.MenuJanelaAberta.JanelaAberta(this.Theme);
        }

        #endregion

        #region Eventos

        public delegate void ClickControl(object sender, EventArgs e);

        public event ClickControl FecharTudo;

        #endregion

        #region Metodos Publicos

        public void Removejanela(string name)
        {
            this.flpMain.Controls.RemoveByKey(name);
        }

        public void FocarContainer(string name)
        {
            /*
             * comentado temporariamente
             * 
             * 
             * 
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

                            if (frm.Controls.ContainsKey("pnlTransparent"))
                                frm.Controls["pnlTransparent"]?.Focus();
                            else
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

            */
        }

        #endregion

    }
}
