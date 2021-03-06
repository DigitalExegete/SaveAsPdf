﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Flow
{
    using Fonet.DataTypes;
    using Fonet.Fo.Properties;
    using Fonet.Layout;

    internal class Character : FObj
    {
        public static FObjMaker<Character> GetMaker()
        {
            return new FObjMaker<Character>((parent, propertyList) => new Character(parent, propertyList));
        } 

        public const int OK = 0; 
        public const int DOESNOT_FIT = 1;

        public Character(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {

        }
        public override string ElementName { get { return "fo:character"; } } 

        public override Status Layout(Area area)
        {
            BlockArea blockArea;
            if (!(area is BlockArea))
            {
                FonetDriver.ActiveDriver.FireFonetWarning(
                    "Currently Character can only be in a BlockArea");
                return new Status(Status.OK);
            }
            blockArea = (BlockArea)area;
            bool textDecoration;

            AuralProps mAurProps = propMgr.GetAuralProps();
            BorderAndPadding bap = propMgr.GetBorderAndPadding();
            BackgroundProps bProps = propMgr.GetBackgroundProps();
            HyphenationProps mHyphProps = propMgr.GetHyphenationProps();
            MarginInlineProps mProps = propMgr.GetMarginInlineProps();
            RelativePositionProps mRelProps = propMgr.GetRelativePositionProps();
            ColorType c = properties.GetColorType();
            float red = c.Red;
            float green = c.Green;
            float blue = c.Blue;

            int whiteSpaceCollapse = properties.GetWhiteSpaceCollapse();
            WrapOption wrapOption = this.parent.properties.GetWrapOption();

            TextDecoration tmp = properties.GetTextDecoration();
            if (tmp == TextDecoration.UNDERLINE)
            {
                textDecoration = true;
            }
            else
            {
                textDecoration = false;
            }

            char characterValue = this.properties.GetChar();
            string id = this.properties.GetId();
            blockArea.GetMyRefs().InitializeID(id, blockArea);

            LineArea la = blockArea.getCurrentLineArea();
            if (la == null)
            {
                return new Status(Status.AREA_FULL_NONE);
            }
            la.changeFont(propMgr.GetFontState(area.getFontInfo()));
            la.changeColor(red, green, blue);
            la.changeWrapOption(wrapOption);
            la.changeWhiteSpaceCollapse(whiteSpaceCollapse);
            blockArea.setupLinkSet(this.GetLinkSet());
            int result = la.addCharacter(characterValue, this.GetLinkSet(),
                                         textDecoration);
            if (result == Character.DOESNOT_FIT)
            {
                la = blockArea.createNextLineArea();
                if (la == null)
                {
                    return new Status(Status.AREA_FULL_NONE);
                }
                la.changeFont(propMgr.GetFontState(area.getFontInfo()));
                la.changeColor(red, green, blue);
                la.changeWrapOption(wrapOption);
                la.changeWhiteSpaceCollapse(whiteSpaceCollapse);
                blockArea.setupLinkSet(this.GetLinkSet());
                la.addCharacter(characterValue, this.GetLinkSet(),
                                textDecoration);
            }
            return new Status(Status.OK);
        }
    }
}