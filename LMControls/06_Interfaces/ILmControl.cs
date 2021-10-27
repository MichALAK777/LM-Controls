using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.Interfaces 
{
   public interface ILmControl
    {
        event EventHandler<LmPaintEventArgs> CustomPaintBackground;
        event EventHandler<LmPaintEventArgs> CustomPaint;
        event EventHandler<LmPaintEventArgs> CustomPaintForeground;

        bool UseCustomBackColor { get; set; }
        bool UseCustomForeColor { get; set; }
        bool UseSelectable { get; set; }
    }
}
