using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LMControls.LmControls.Design
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class LmFormDesign : DocumentDesigner 
    {
        public LmFormDesign()
        {
            Trace.WriteLine("LmFormDesign ctor");// Para Fins de Depuração
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            IComponentChangeService cs =
                GetService(typeof(IComponentChangeService))
                as IComponentChangeService;

            if (cs != null)
            {
                cs.ComponentChanged +=
                    new ComponentChangedEventHandler(OnComponentChanged);
            }
        }

        private void OnComponentChanged(object sender, ComponentChangedEventArgs e)
        {

        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);
        }

    }
}
