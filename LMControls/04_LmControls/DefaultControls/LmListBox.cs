﻿using LMControls.Components;
using LMControls.Interfaces;
using LMControls.LmDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMControls.LmControls
{
    [DefaultEvent("SelectedIndexChanged")]
    public partial class LmListBox : ListBox, ILmControl
    {
        #region Construtor

        public LmListBox()
        {
            StyleList();

            this.DoubleBuffered = true;
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

        private LmTheme lmTheme = LmTheme.Padrao;
        [Category(LmDefault.PropertyCategory.LmUI)]
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
            set { lmTheme = value; }
        }

        private LmStyleManager lmStyleManager = null;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LmStyleManager StyleManager
        {
            get { return lmStyleManager; }
            set { lmStyleManager = value; StyleList(); }
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

        #region Paint Metodos

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen p = new Pen(LmPaint.BackColor.FormHeader(Theme)))
            {
                p.Width = 3;
                e.Graphics.DrawRectangle(p, new Rectangle(0, 0, Width - 2, Height - 2));
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            //e.BackColor = Color.AliceBlue;

        }

        #endregion

        #region Private Metodos

        private void StyleList()
        {
            Font fRow = new Font("Arial", 9F, FontStyle.Regular);
            Font fHeader = new Font("Arial", 9F, FontStyle.Regular);

            this.Font = fRow;

            this.BackColor = LmPaint.BackColor.GridView.CellNormal(Theme);
            this.ForeColor = LmPaint.ForeColor.GridView.CellNormal(Theme);

            this.BorderStyle = BorderStyle.FixedSingle;
        }

        #endregion
    }
}