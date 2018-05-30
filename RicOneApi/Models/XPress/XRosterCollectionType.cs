using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-14
 * Filename    XRosterCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XRosterCollectionType
    /// </summary>
    public class XRosterCollectionType : ICollectionType<XRosterType, XRosterCollectionType>
    {
        public XRosterCollectionType()
        {
            xRosters = null;
            xRoster = new List<XRosterType>();
        }
        public XRosterCollectionType xRosters { get; set; }
        public List<XRosterType> xRoster { get; set; }

        public XRosterCollectionType GetObjects
        {
            get { return xRosters; }
            set { xRosters = value; }
        }

        public List<XRosterType> GetObject
        {
            get { return xRoster; }
            set { xRoster = value; }
        }
    }
}
