using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XContactCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XContactCollectionType
    /// </summary>
    public class XContactCollectionType : ICollectionType<XContactType, XContactCollectionType>
    {
        public XContactCollectionType()
        {
            xContacts = null;
            xContact = new List<XContactType>();
        }
        public XContactCollectionType xContacts { get; set; }
        public List<XContactType> xContact { get; set; }

        public XContactCollectionType GetObjects
        {
            get { return xContacts; }
            set { xContacts = value; }
        }

        public List<XContactType> GetObject
        {
            get { return xContact; }
            set { xContact = value; }
        }
    }
}
