using System.Collections.Generic;

namespace RicOneApi.Models.XPress
{
    public class XEmploymentCollectionType : ICollectionType<XEmploymentType, XEmploymentCollectionType>
    {
        public XEmploymentCollectionType()
        {
            xEmployments = null;
            xEmployment = new List<XEmploymentType>();
        }

        public XEmploymentCollectionType xEmployments { get; set; }
        public List<XEmploymentType> xEmployment { get; set; }
        public XEmploymentCollectionType GetObjects 
        { 
            get { return xEmployments; }
            set { xEmployments = value; }
        }
        public List<XEmploymentType> GetObject 
        {
            get { return xEmployment; }
            set { xEmployment = value; } 
        }
    }
}
