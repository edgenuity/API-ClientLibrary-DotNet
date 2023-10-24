using System;

namespace RicOneApi.Models.XPress
{
    public class XAssignmentType
    {

        public string leaRefId { get; set; }
        public string schoolRefId { get; set; }
        public string type { get; set; }
        public string department { get; set; }
        public string positionTitle { get; set; }
        public XManagerType manager { get; set; }
        public string hireDate { get; set; }
        public string terminationDate { get; set; }
        public bool active { get; set; }
        public bool removeEmployee { get; set; }
        public XAssignmentCollectionType assignments { get; set; }

        public XAssignmentType()
        {
            leaRefId = null;
            schoolRefId = null;
            type = null;
            department = null;
            positionTitle = null;
            manager = new XManagerType();
            hireDate = null;
            terminationDate = null;
            active = false;
            removeEmployee = false;
            assignments = new XAssignmentCollectionType();
        }

        public XAssignmentCollectionType GetObjects { get; set; }
        public XAssignmentType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }

    }
}
