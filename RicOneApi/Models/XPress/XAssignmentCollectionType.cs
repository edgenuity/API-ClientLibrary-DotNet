using System.Collections.Generic;

namespace RicOneApi.Models.XPress
{
    public class XAssignmentCollectionType
    {
        public List<XAssignmentType> assignment { get; set; }

        public List<XAssignmentType> GetObject { get; set; }

        public XAssignmentCollectionType()
        {
            assignment = new List<XAssignmentType>();
        }
    }
}
