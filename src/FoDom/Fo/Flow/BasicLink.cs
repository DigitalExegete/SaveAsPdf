﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Flow
{
    using Fonet.Fo.Properties;
    using Fonet.Layout;

    internal class BasicLink : Inline
    {

        public new static FObjMaker<BasicLink> GetMaker()
        {
            return new FObjMaker<BasicLink>((parent, propertyList) => new BasicLink(parent, propertyList));
        }


        public BasicLink(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {
            
        }
        public override string ElementName { get { return "fo:basic-link"; } }
        public override Status Layout(Area area)
        {
            string destination;
            Fonet.Pdf.LinkKind linkType;
             
            AccessibilityProps mAccProps = propMgr.GetAccessibilityProps();
            AuralProps mAurProps = propMgr.GetAuralProps();
            BorderAndPadding bap = propMgr.GetBorderAndPadding();
            BackgroundProps bProps = propMgr.GetBackgroundProps();
            MarginInlineProps mProps = propMgr.GetMarginInlineProps();
            RelativePositionProps mRelProps = propMgr.GetRelativePositionProps();

            if (!(destination =
                this.properties.GetProperty("internal-destination").GetString()).Equals(""))
            {
                linkType = Pdf.LinkKind.Internal;
            }
            else if (!(destination =
                this.properties.GetProperty("external-destination").GetString()).Equals(""))
            {
                linkType = Pdf.LinkKind.External;
            }
            else
            {
                throw new FonetException("internal-destination or external-destination must be specified in basic-link");
            }

            if (this.marker == MarkerStart)
            {
                string id = this.properties.GetProperty("id").GetString();
                MyIDRefs refs = (MyIDRefs)area.getIDReferences();

                refs.InitializeID(id, area);
                this.marker = 0;
            }

            LinkSet ls = new LinkSet(destination, area, linkType);

            AreaContainer ac = area.getNearestAncestorAreaContainer();
            while (ac != null && ac.getPosition() != Position.ABSOLUTE)
            {
                ac = ac.getNearestAncestorAreaContainer();
            }
            if (ac == null)
            {
                ac = area.getPage().getBody().getCurrentColumnArea();
            }

            int numChildren = this.children.Count;
            for (int i = this.marker; i < numChildren; i++)
            {
                FONode fo = (FONode)children[i];
                fo.SetLinkSet(ls);

                Status status;
                if ((status = fo.Layout(area)).isIncomplete())
                {
                    this.marker = i;
                    return status;
                }
            }

            ls.applyAreaContainerOffsets(ac, area);
            area.getPage().addLinkSet(ls);

            return new Status(Status.OK);
        }
    }
}