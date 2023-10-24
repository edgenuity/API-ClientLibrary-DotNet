using RestSharp.Deserializers;
using System;

namespace RicOneApi.Models.XPress
{
    public class XEmploymentType
    {
        public XEmploymentType()
        {
            refId = null;
            type = null;
            manager = new XManagerType();
            hireDate = null;
            terminationDate = null;
            active = false;
            removeEmployee = false;
            assignments = new XAssignmentCollectionType();
            Metadata = new XMetadata();
        }

        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string type {get; set;}
        public XManagerType manager {get; set;}
        public string hireDate {get; set;}
        public string terminationDate {get; set;}
        public bool active {get; set;}
        public bool removeEmployee {get; set;}
        public XAssignmentCollectionType assignments {get; set;}
        public XMetadata Metadata {get; set;}

        public XEmploymentCollectionType GetObjects { get; set; }
        public XEmploymentType GetObject 
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
