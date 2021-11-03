using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMControls.LmDesign
{
    #region Enumns

    public enum LmLabelSize
    {
        Tiny = 0,
        Small = 1,
        Medium = 2,
        Tall = 3,
        Huge = 4,
    }

    public enum LmLabelWeight
    {
        Regular,
        Bold
    }

    public enum LmWaterMarkWeight
    {
        Regular,
        Bold,
        Italic
    }

    public enum LmTextBoxSize
    {
        Small,
        Medium,
        Tall
    }

    public enum LmTextBoxWeight
    {
        Regular,
        Bold
    }

    public enum LmTabControlSize
    {
        Small,
        Medium,
        Tall
    }

    public enum LmTabControlWeight
    {
        Regular,
        Bold
    }

    public enum LmCheckBoxSize
    {
        Small,
        Medium,
        Tall
    }

    public enum LmCheckBoxWeight
    {
        Regular,
        Bold
    }

    #endregion

    public static class LmFonts
    {
        #region DefaultFonts

        public static Font DefaultLight(float size, bool isLink = false)
        {
            return isLink
                ? new Font("Segoe UI Light", size, FontStyle.Regular | FontStyle.Underline, GraphicsUnit.Pixel)
                : new Font("Segoe UI Light", size, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        public static Font Default(float size, bool isLink = false)
        {
            return isLink
                ? new Font("Segoe UI", size, FontStyle.Regular | FontStyle.Underline, GraphicsUnit.Pixel)
                : new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        public static Font DefaultBold(float size, bool isLink = false)
        {
            return isLink
                ? new Font("Segoe UI", size, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel)
                : new Font("Segoe UI", size, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public static Font DefaultItalic(float size, bool isLink = false)
        {
            return isLink
                ? new Font("Segoe UI", size, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Pixel)
                : new Font("Segoe UI", size, FontStyle.Italic, GraphicsUnit.Pixel);
        }

        #endregion


        public static Font TitleForm
        {
            get { return Default(15f); }
        }

        public static Font TitleMainForm
        {
            get { return Default(14f); }
        }

        public static Font Label(LmLabelSize labelSize, LmLabelWeight labelWeight, bool isLink = false)
        {
            if (labelSize == LmLabelSize.Tiny)
            {
                if (labelWeight == LmLabelWeight.Regular)
                    return Default(10f, isLink);
                if (labelWeight == LmLabelWeight.Bold)
                    return DefaultBold(10f, isLink);
            }
            else if (labelSize == LmLabelSize.Small)
            {
                if (labelWeight == LmLabelWeight.Regular)
                    return Default(12f, isLink);
                if (labelWeight == LmLabelWeight.Bold)
                    return DefaultBold(12f, isLink);
            }
            else if (labelSize == LmLabelSize.Medium)
            {
                if (labelWeight == LmLabelWeight.Regular)
                    return Default(14f, isLink);
                if (labelWeight == LmLabelWeight.Bold)
                    return DefaultBold(14f, isLink);
            }
            else if (labelSize == LmLabelSize.Tall)
            {
                if (labelWeight == LmLabelWeight.Regular)
                    return Default(18f, isLink);
                if (labelWeight == LmLabelWeight.Bold)
                    return DefaultBold(18f, isLink);
            }
            else if (labelSize == LmLabelSize.Huge)
            {
                if (labelWeight == LmLabelWeight.Regular)
                    return Default(28f, isLink);
                if (labelWeight == LmLabelWeight.Bold)
                    return DefaultBold(28f, isLink);
            }

            return DefaultLight(14f);
        }

        public static Font TextBox(LmTextBoxSize linkSize, LmTextBoxWeight linkWeight)
        {
            if (linkSize == LmTextBoxSize.Small)
            {
                if (linkWeight == LmTextBoxWeight.Regular)
                    return Default(12f);
                if (linkWeight == LmTextBoxWeight.Bold)
                    return DefaultBold(12f);
            }
            else if (linkSize == LmTextBoxSize.Medium)
            {
                if (linkWeight == LmTextBoxWeight.Regular)
                    return Default(14f);
                if (linkWeight == LmTextBoxWeight.Bold)
                    return DefaultBold(14f);
            }
            else if (linkSize == LmTextBoxSize.Tall)
            {
                if (linkWeight == LmTextBoxWeight.Regular)
                    return Default(18f);
                if (linkWeight == LmTextBoxWeight.Bold)
                    return DefaultBold(18f);
            }

            return Default(12f);
        }

        public static Font TabControl(LmTabControlSize labelSize, LmTabControlWeight labelWeight)
        {
            if (labelSize == LmTabControlSize.Small)
            {
                if (labelWeight == LmTabControlWeight.Regular)
                    return Default(12f);
                if (labelWeight == LmTabControlWeight.Bold)
                    return DefaultBold(12f);
            }
            else if (labelSize == LmTabControlSize.Medium)
            {
                if (labelWeight == LmTabControlWeight.Regular)
                    return Default(14f);
                if (labelWeight == LmTabControlWeight.Bold)
                    return DefaultBold(14f);
            }
            else if (labelSize == LmTabControlSize.Tall)
            {
                if (labelWeight == LmTabControlWeight.Regular)
                    return Default(18f);
                if (labelWeight == LmTabControlWeight.Bold)
                    return DefaultBold(18f);
            }

            return DefaultLight(14f);
        }

        public static Font CheckBox(LmCheckBoxSize linkSize, LmCheckBoxWeight linkWeight)
        {
            if (linkSize == LmCheckBoxSize.Small)
            {
                if (linkWeight == LmCheckBoxWeight.Regular)
                    return Default(12f);
                if (linkWeight == LmCheckBoxWeight.Bold)
                    return DefaultBold(12f);
            }
            else if (linkSize == LmCheckBoxSize.Medium)
            {
                if (linkWeight == LmCheckBoxWeight.Regular)
                    return Default(14f);
                if (linkWeight == LmCheckBoxWeight.Bold)
                    return DefaultBold(14f);
            }
            else if (linkSize == LmCheckBoxSize.Tall)
            {
                if (linkWeight == LmCheckBoxWeight.Regular)
                    return Default(18f);
                if (linkWeight == LmCheckBoxWeight.Bold)
                    return DefaultBold(18f);
            }

            return Default(12f);
        }

        public static Font WaterMark(LmLabelSize labelSize, LmWaterMarkWeight labelWeight)
        {
            if (labelSize == LmLabelSize.Small)
            {
                if (labelWeight == LmWaterMarkWeight.Regular)
                    return Default(12f);
                if (labelWeight == LmWaterMarkWeight.Bold)
                    return DefaultBold(12f);
                if (labelWeight == LmWaterMarkWeight.Italic)
                    return DefaultItalic(12f);
            }
            else if (labelSize == LmLabelSize.Medium)
            {
                if (labelWeight == LmWaterMarkWeight.Regular)
                    return Default(14f);
                if (labelWeight == LmWaterMarkWeight.Bold)
                    return DefaultBold(14f);
                if (labelWeight == LmWaterMarkWeight.Italic)
                    return DefaultItalic(14f);
            }
            else if (labelSize == LmLabelSize.Tall)
            {
                if (labelWeight == LmWaterMarkWeight.Regular)
                    return Default(18f);
                if (labelWeight == LmWaterMarkWeight.Bold)
                    return DefaultBold(18f);
                if (labelWeight == LmWaterMarkWeight.Italic)
                    return DefaultItalic(18f);
            }

            return DefaultLight(14f);
        }

    }
}
