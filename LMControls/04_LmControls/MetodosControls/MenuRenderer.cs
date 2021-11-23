using LMControls.LmDesign;
using LMControls.Metodos;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        LmTheme _theme = new LmTheme();

        //Constructor
        public MenuRenderer(LmTheme theme)
            : base(new MenuColorTable(theme))
        {
            _theme = theme;
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.Font = new Font("Segoe UI", 9.75F);
            e.Item.ForeColor = e.Item.Selected
                ? LmPaint.BackColor.MenuStrip.MenuSubItemSelected(_theme).GetForeColor(LmControlStatus.Selected)
                : LmPaint.BackColor.MenuStrip.MenuSubItemNormal(_theme).GetForeColor(LmControlStatus.Normal);

            if (e.Item.Image == null) return;

            bool inverterCor = e.Item.Image.IsDarkColor() != e.Item.ForeColor.IsDarkColor();

            if (inverterCor)
                e.Item.Image = Controles.ApplyInvert(e.Item.Image);

        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);

            var arrowColor = e.Item.Selected
                ? LmPaint.BackColor.MenuStrip.MenuSubItemSelected(_theme).GetForeColor(LmControlStatus.Selected)
                : LmPaint.BackColor.MenuStrip.MenuSubItemNormal(_theme).GetForeColor(LmControlStatus.Normal);

            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, 2))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}