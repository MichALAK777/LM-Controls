using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace LMControls.LmControls.Design
{
    class LmStyleManagerDesign : ComponentDesigner
    {
        DesignerVerbCollection designerVerbs;

        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (designerVerbs != null)
                {
                    return designerVerbs;
                }

                designerVerbs = new DesignerVerbCollection();
                designerVerbs.Add(new DesignerVerb("Reset Styles to Default", OnResetStyles));

                return designerVerbs;
            }
        }

        private IDesignerHost designerHost;
        public IDesignerHost DesignerHost
        {
            get
            {
                if (designerHost != null)
                {
                    return designerHost;
                }

                designerHost = (IDesignerHost)(GetService(typeof(IDesignerHost)));

                return designerHost;
            }
        }

        private IComponentChangeService componentChangeService;
        public IComponentChangeService ComponentChangeService
        {
            get
            {
                if (componentChangeService != null)
                {
                    return componentChangeService;
                }

                componentChangeService = (IComponentChangeService)(GetService(typeof(IComponentChangeService)));

                return componentChangeService;
            }
        }

        private void OnResetStyles(object sender, EventArgs args)
        {
            LmStyleManager styleManager = Component as LmStyleManager;
            if (styleManager != null)
            {
                if (styleManager.Owner == null)
                {
                    MessageBox.Show("StyleManager do Framework da LM Precisa assinatura de Proprietário!", 
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ResetStyles(styleManager, styleManager.Owner as Control);
        }

        private void ResetStyles(LmStyleManager styleManager, Control control)
        {
            ILmForm container = control as ILmForm;
            if (container != null && !ReferenceEquals(styleManager, container.StyleManager))
            {
                return;
            }

            if (control is ILmControl)
            {
                ResetProperty(control, "Theme", LmTheme.Padrao);
            }
            else if (control is ILmComponent)
            {
                ResetProperty(control, "Theme", LmTheme.Padrao);
            }

            if (control.ContextMenuStrip != null)
            {
                ResetStyles(styleManager, control.ContextMenuStrip);
            }

            TabControl tabControl = control as TabControl;
            if (tabControl != null)
            {
                foreach (TabPage tp in tabControl.TabPages)
                {
                    ResetStyles(styleManager, tp);
                }
            }

            if (control.Controls != null)
            {
                foreach (Control child in control.Controls)
                {
                    ResetStyles(styleManager, child);
                }
            }
        }

        private void ResetProperty(Control control, string name, object newValue)
        {
            var typeDescriptor = TypeDescriptor.GetProperties(control)[name];
            if (typeDescriptor == null)
            {
                return;
            }

            object oldValue = typeDescriptor.GetValue(control);

            if (newValue.Equals(oldValue))
            {
                return;
            }

            ComponentChangeService.OnComponentChanging(control, typeDescriptor);
            typeDescriptor.SetValue(control, newValue);
            ComponentChangeService.OnComponentChanged(control, typeDescriptor, oldValue, newValue);
        }
    }
}
