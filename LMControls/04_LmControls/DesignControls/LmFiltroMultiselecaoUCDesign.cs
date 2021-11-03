using System.Collections;
using System.Windows.Forms.Design;

namespace LMControls.LmControls.Design
{
    class LmFiltroMultiselecaoUCDesign : ParentControlDesigner //: ControlDesigner
    {
        protected override void PreFilterProperties(IDictionary properties)
        {
            properties.Remove("BorderStyle");
            properties.Remove("BackColor");

            base.PreFilterProperties(properties);
        }
    }
}
