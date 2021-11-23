using LMControls.Interfaces;
using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.Components
{
    [Designer(typeof(LmControls.Design.LmStyleManagerDesign))]
    public sealed class LmStyleManager : Component, ISupportInitialize
    {
        #region Campos

        private readonly IContainer parentContainer;

        private LmTheme lmTheme = LmDefault.Theme;
        [DefaultValue(LmDefault.Theme)]
        public LmTheme Theme
        {
            get { return lmTheme; }
            set
            {
                if (value == LmTheme.Padrao)
                {
                    value = LmDefault.Theme;
                }

                lmTheme = value;

                if (!isInitializing)
                {
                    Update();
                }
            }
        }

        private LmMessageType lmMessageType = LmDefault.TipoMensagem;
        [DefaultValue(LmDefault.Theme)]
        public LmMessageType TipoMensagem
        {
            get { return lmMessageType; }
            set
            {
                if (value == LmMessageType.Padrao)
                {
                    value = LmDefault.TipoMensagem;
                }

                lmMessageType = value;

                if (!isInitializing)
                {
                    Update();
                }
            }
        }

        private int idUsuarioLogado = 0;
        [DefaultValue(0)]
        public int IdUsuarioLogado
        {
            get { return idUsuarioLogado; }
            set
            {
                idUsuarioLogado = value;

                if (!isInitializing)
                {
                    Update();
                }
            }
        }

        private ContainerControl owner;
        public ContainerControl Owner
        {
            get { return owner; }
            set
            {
                if (owner != null)
                {
                    owner.ControlAdded -= ControlAdded;
                }

                owner = value;

                if (value != null)
                {
                    owner.ControlAdded += ControlAdded;

                    if (!isInitializing)
                    {
                        UpdateControl(value);
                    }
                }
            }
        }

        #endregion

        #region Constructor

        public LmStyleManager()
        {

        }

        public LmStyleManager(IContainer parentContainer)
            : this()
        {
            if (parentContainer != null)
            {
                this.parentContainer = parentContainer;
                this.parentContainer.Add(this);
            }
        }

        #endregion

        #region ICloneable

        public object Clone()
        {
            LmStyleManager newStyleManager = new LmStyleManager();
            newStyleManager.lmTheme = Theme;
            return newStyleManager;
        }

        public object Clone(ContainerControl owner)
        {
            LmStyleManager clonedManager = Clone() as LmStyleManager;

            if (owner is ILmForm)
            {
                clonedManager.Owner = owner;
                ((ILmForm)owner).StyleManager = clonedManager;

                Type parentForm = owner.GetType();
                FieldInfo fieldInfo = parentForm.GetField("components",
                BindingFlags.Instance |
                     BindingFlags.NonPublic);

                if (fieldInfo == null) return clonedManager;

                IContainer mother = (IContainer)fieldInfo.GetValue(owner);
                if (mother == null) return clonedManager;

                // Check for a helper component
                foreach (Component obj in mother.Components)
                {
                    if (obj is ILmComponent)
                    {
                        ApplyTheme((ILmComponent)obj);
                    }

                    //if (obj.GetType() == typeof(LmContextMenu))
                    //{
                    //    ApplyTheme((LmContextMenu)obj);
                    //}
                }
            }

            return clonedManager;
        }

        #endregion

        #region ISupportInitialize

        private bool isInitializing;

        void ISupportInitialize.BeginInit()
        {
            isInitializing = true;
        }

        void ISupportInitialize.EndInit()
        {
            isInitializing = false;
            Update();
        }

        #endregion

        #region Management Methods

        private void ControlAdded(object sender, ControlEventArgs e)
        {
            if (!isInitializing)
            {
                UpdateControl(e.Control);
            }
        }

        public void Update()
        {
            if (owner != null)
            {
                UpdateControl(owner);
            }

            if (parentContainer == null || parentContainer.Components == null)
            {
                return;
            }

            foreach (Object obj in parentContainer.Components)
            {
                if (obj is ILmComponent)
                {
                    ApplyTheme((ILmComponent)obj);
                }

                //if (obj.GetType() == typeof(LmContextMenu))
                //{
                //    ApplyTheme((LmContextMenu)obj);
                //}
            }
        }

        private void UpdateControl(Control ctrl)
        {
            if (ctrl == null)
            {
                return;
            }

            ILmControl lmControl = ctrl as ILmControl;
            if (lmControl != null)
            {
                ApplyTheme(lmControl);
            }

            ILmComponent lmComponent = ctrl as ILmComponent;
            if (lmComponent != null)
            {
                ApplyTheme(lmComponent);
            }

            TabControl tabControl = ctrl as TabControl;
            if (tabControl != null)
            {
                foreach (TabPage tp in ((TabControl)ctrl).TabPages)
                {
                    UpdateControl(tp);
                }
            }

            if (ctrl.Controls != null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    UpdateControl(child);
                }
            }

            if (ctrl.ContextMenuStrip != null)
            {
                UpdateControl(ctrl.ContextMenuStrip);
            }

            ctrl.Refresh();
        }

        private void ApplyTheme(ILmControl control)
        {
            control.StyleManager = this;
        }

        private void ApplyTheme(ILmComponent component)
        {
            component.StyleManager = this;
        }

        #endregion
    }
}
