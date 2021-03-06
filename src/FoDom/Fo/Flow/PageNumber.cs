﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Flow
{
    using Fonet.DataTypes;
    using Fonet.Fo.Properties;
    using Fonet.Layout;

    internal class PageNumber : FObj
    {
        public static FObjMaker<PageNumber> GetMaker()
        {
            return new FObjMaker<PageNumber>((parent, propertyList) => new PageNumber(parent, propertyList));
        }


        private float red;
        private float green;
        private float blue;
        private WrapOption wrapOption;
        private int whiteSpaceCollapse;
        private TextState ts;

        public PageNumber(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {

        }
        public override string ElementName { get { return "fo:page-number"; } }
        public override Status Layout(Area area)
        {
            if (!(area is BlockArea))
            {
                FonetDriver.ActiveDriver.FireFonetWarning(
                    "Page-number outside block area");
                return new Status(Status.OK);
            }
            if (this.marker == MarkerStart)
            {
                AccessibilityProps mAccProps = propMgr.GetAccessibilityProps();
                AuralProps mAurProps = propMgr.GetAuralProps();
                BorderAndPadding bap = propMgr.GetBorderAndPadding();
                BackgroundProps bProps = propMgr.GetBackgroundProps();
                MarginInlineProps mProps = propMgr.GetMarginInlineProps();
                RelativePositionProps mRelProps = propMgr.GetRelativePositionProps();

                ColorType c = this.properties.GetProperty("color").GetColorType();
                this.red = c.Red;
                this.green = c.Green;
                this.blue = c.Blue;

                this.wrapOption = (WrapOption)this.properties.GetProperty("wrap-option").GetEnum();
                this.whiteSpaceCollapse =
                    this.properties.GetProperty("white-space-collapse").GetEnum();
                ts = new TextState();
                this.marker = 0;


                area.GetMyRefs().InitializeID(this.properties.GetId(), area);
            }

            string p = area.getPage().getFormattedNumber();
            this.marker = FOText.addText((BlockArea)area,
                                         propMgr.GetFontState(area.getFontInfo()),
                                         red, green, blue, wrapOption, null,
                                         whiteSpaceCollapse, p.ToCharArray(), 0,
                                         p.Length, ts, VerticalAlign.BASELINE);
            return new Status(Status.OK);
        }
    }
}