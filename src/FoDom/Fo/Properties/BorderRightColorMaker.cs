﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Text;

namespace Fonet.Fo.Properties
{
    internal class BorderRightColorMaker : GenericColor
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new BorderRightColorMaker(propName);
        }

        protected BorderRightColorMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }


        public override Property Compute(PropertyList propertyList)
        {
            FObj parentFO = propertyList.getParentFObj();
            StringBuilder sbExpr = new StringBuilder();
            Property p = null;
            sbExpr.Append("border-");
            sbExpr.Append(propertyList.wmAbsToRel(PropertyList.RIGHT));
            sbExpr.Append("-color");
            p = propertyList.GetExplicitOrShorthandProperty(sbExpr.ToString());

            if (p != null)
            {
                p = ConvertProperty(p, propertyList, parentFO);
            }

            return p;
        }

        public override Property GetShorthand(PropertyList propertyList)
        {
            Property p = null;
            ListProperty listprop;

            if (p == null)
            {
                listprop = (ListProperty)propertyList.GetExplicitProperty("border-right");
                if (listprop != null)
                {
                    IShorthandParser shparser = new GenericShorthandParser(listprop);
                    p = shparser.GetValueForProperty(PropName, this, propertyList);
                }
            }

            if (p == null)
            {
                listprop = (ListProperty)propertyList.GetExplicitProperty("border-color");
                if (listprop != null)
                {
                    IShorthandParser shparser = new BoxPropShorthandParser(listprop);
                    p = shparser.GetValueForProperty(PropName, this, propertyList);
                }
            }

            if (p == null)
            {
                listprop = (ListProperty)propertyList.GetExplicitProperty("border");
                if (listprop != null)
                {
                    IShorthandParser shparser = new GenericShorthandParser(listprop);
                    p = shparser.GetValueForProperty(PropName, this, propertyList);
                }
            }

            return p;
        }

        private Property m_defaultProp = null;

        public override Property Make(PropertyList propertyList)
        {
            if (m_defaultProp == null)
            {
                m_defaultProp = Make(propertyList, "black", propertyList.getParentFObj());
            }
            return m_defaultProp;

        }

    }
}