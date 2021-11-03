using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace LMControls.LmControls.Design
{
    internal class LmButtonDesign : ControlDesigner
    {
        protected override void PreFilterProperties(IDictionary properties)
        {
            properties.Remove("BackColor");
            properties.Remove("ForeColor");

            base.PreFilterProperties(properties);
        }
    }
}
