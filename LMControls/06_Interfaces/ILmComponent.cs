using LMControls.Components;
using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.Interfaces
{
    public interface ILmComponent
    {
        LmTheme Theme { get; set; }

        LmStyleManager StyleManager { get; set; }
    }
}
