using System;
using RestSharp.Deserializers;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-05-14
 * Filename    XCalendarType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XCalendarType
    /// </summary>
    public class XCalendarType
    {
        public XCalendarType()
        {
            refId = null;
            schoolRefId = null;
            schoolYear = null;
            sessions = new XSessionListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public string schoolRefId { get; set; }
        public string schoolYear { get; set; }
        public XSessionListType sessions { get; set; }

        public XCalendarCollectionType GetObjects { get; set; }
        public XCalendarType GetObject
        {
            get { return this; }
            set { throw new NotImplementedException(); }
        }
    }
}
