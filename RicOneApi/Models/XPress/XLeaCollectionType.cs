using System.Collections.Generic;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-14
 * Filename    XLeaCollectionType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XLeaCollectionType
    /// </summary>
    public class XLeaCollectionType : ICollectionType<XLeaType, XLeaCollectionType>
    {
        public XLeaCollectionType()
        {
            xLeas = null;
            xLea = new List<XLeaType>();
        }

        public XLeaCollectionType xLeas { get; set; }
        public List<XLeaType> xLea { get; set; }

        public XLeaCollectionType GetObjects
        {
            get { return xLeas; }
            set { xLeas = value; }
        }

        public List<XLeaType> GetObject
        {
            get { return xLea; }
            set { xLea = value; }
        }
    }
}