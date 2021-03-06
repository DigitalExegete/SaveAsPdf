﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Flow
{
    using System.Collections;
    using Fonet.Fo.Pagination;
    using Fonet.Fo.Properties;
    using Fonet.Layout;

    internal class RetrieveMarker : FObjMixed
    {
        private string retrieveClassName;

        private int retrievePosition;

        private int retrieveBoundary;

        private Marker bestMarker;
        public static FObjMaker<RetrieveMarker> GetMaker()
        {
            return new FObjMaker<RetrieveMarker>((parent, propertyList) => new RetrieveMarker(parent, propertyList));
        }
        

        public RetrieveMarker(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {
            

            this.retrieveClassName =
                this.properties.GetProperty("retrieve-class-name").GetString();
            this.retrievePosition =
                this.properties.GetProperty("retrieve-position").GetEnum();
            this.retrieveBoundary =
                this.properties.GetProperty("retrieve-boundary").GetEnum();
        }
        public override string ElementName { get { return "fo:retrieve-marker"; } }
        public override Status Layout(Area area)
        {
            if (marker == MarkerStart)
            {
                marker = 0;
                Page containingPage = area.getPage();
                bestMarker = SearchPage(containingPage);

                if (bestMarker != null)
                {
                    bestMarker.resetMarkerContent();
                    return bestMarker.LayoutMarker(area);
                }

                AreaTree areaTree = containingPage.getAreaTree();
                if (retrieveBoundary == RetrieveBoundary.PAGE_SEQUENCE)
                {
                    PageSequence pageSequence = areaTree.GetCurrentPageSequence();
                    if (pageSequence == containingPage.getPageSequence())
                    {
                        return LayoutBestMarker(areaTree.GetCurrentPageSequenceMarkers(), area);
                    }

                }
                else if (retrieveBoundary == RetrieveBoundary.DOCUMENT)
                {
                    return LayoutBestMarker(areaTree.GetDocumentMarkers(), area);

                }
                else if (retrieveBoundary != RetrieveBoundary.PAGE)
                {
                    throw new FonetException("Illegal 'retrieve-boundary' value");
                }

            }
            else if (bestMarker != null)
            {
                return bestMarker.LayoutMarker(area);
            }

            return new Status(Status.OK);

        }

        private Status LayoutBestMarker(ArrayList markers, Area area)
        {
            if (markers != null)
            {
                for (int i = markers.Count - 1; i >= 0; i--)
                {
                    Marker currentMarker = (Marker)markers[i];
                    if (currentMarker.GetMarkerClassName().Equals(retrieveClassName))
                    {
                        bestMarker = currentMarker;
                        bestMarker.resetMarkerContent();
                        return bestMarker.LayoutMarker(area);
                    }
                }
            }
            return new Status(Status.OK);
        }

        private Marker SearchPage(Page page)
        {
            ArrayList pageMarkers = page.getMarkers();
            if (pageMarkers.Count == 0)
            {
                return null;
            }

            if (retrievePosition == RetrievePosition.FIC)
            {
                for (int i = 0; i < pageMarkers.Count; i++)
                {
                    Marker currentMarker = (Marker)pageMarkers[i];
                    if (currentMarker.GetMarkerClassName().Equals(retrieveClassName))
                    {
                        return currentMarker;
                    }
                }
            }
            else if (retrievePosition == RetrievePosition.FSWP)
            {
                for (int c = 0; c < pageMarkers.Count; c++)
                {
                    Marker currentMarker = (Marker)pageMarkers[c];
                    if (currentMarker.GetMarkerClassName().Equals(retrieveClassName))
                    {
                        if (currentMarker.GetRegistryArea().isFirst())
                        {
                            return currentMarker;
                        }
                    }
                }
            }
            else if (retrievePosition == RetrievePosition.LSWP)
            {
                for (int c = pageMarkers.Count - 1; c >= 0; c--)
                {
                    Marker currentMarker = (Marker)pageMarkers[c];
                    if (currentMarker.GetMarkerClassName().Equals(retrieveClassName))
                    {
                        if (currentMarker.GetRegistryArea().isFirst())
                        {
                            return currentMarker;
                        }
                    }
                }

            }
            else if (retrievePosition == RetrievePosition.LEWP)
            {
                for (int c = pageMarkers.Count - 1; c >= 0; c--)
                {
                    Marker currentMarker = (Marker)pageMarkers[c];
                    if (currentMarker.GetMarkerClassName().Equals(retrieveClassName))
                    {
                        if (currentMarker.GetRegistryArea().isLast())
                        {
                            return currentMarker;
                        }
                    }
                }
            }
            else
            {
                throw new FonetException("Illegal 'retrieve-position' value");
            }
            return null;
        }
    }
}