/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XLeaCollectionType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XLeaCollectionType
    /// </summary>
    public class XLeaCollectionType : ICollectionType<XLeaCollectionType, XLeaType>
    {
        public XLeaCollectionType()
        {
            xLeas = null;
            xLea = new List<XLeaType>();
        }
        public XLeaCollectionType xLeas { get; set; }
        public List<XLeaType> xLea { get; set; }


        public XLeaCollectionType GetCollectionType
        {
            get
            {
                return xLeas;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<XLeaType> GetObject
        {
            get
            {
                return xLea;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}