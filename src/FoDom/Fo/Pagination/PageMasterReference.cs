﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Pagination
{
    internal abstract class PageMasterReference : FObj, SubSequenceSpecifier
    {
        private string _masterName;

        private PageSequenceMaster _pageSequenceMaster;

        public PageMasterReference(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {

            if (GetProperty("master-reference") != null)
            {
                SetMasterName(GetProperty("master-reference").GetString());
            }
            validateParent(parent);
        }

        protected void SetMasterName(string masterName)
        {
            _masterName = masterName;
        }

        public string MasterName
        {
            get { return _masterName; }
        }

        protected PageSequenceMaster PageSequenceMaster
        {
            get { return _pageSequenceMaster; }
            set { _pageSequenceMaster = value; }
        }

        public abstract string GetNextPageMaster(int currentPageNumber,
                                                 bool thisIsFirstPage,
                                                 bool isEmptyPage);



        protected void validateParent(FObj parent)
        {
            if (parent.ElementName.Equals("fo:page-sequence-master"))
            {
                _pageSequenceMaster = (PageSequenceMaster)parent;

                if (MasterName == null)
                {
                    FonetDriver.ActiveDriver.FireFonetWarning(
                        ElementName + " does not have a master-reference and so is being ignored");
                }
                else
                {
                    _pageSequenceMaster.AddSubsequenceSpecifier(this);
                }
            }
            else
            {
                throw new FonetException(ElementName + " must be"
                    + "child of fo:page-sequence-master, not "
                    + parent.ElementName);
            }
        }

        public abstract void Reset();
    }
}