/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XOtherCourseIdListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XOtherCourseIdListType
    /// </summary>
    public class XOtherCourseIdListType
    {
        public XOtherCourseIdListType()
        {
            otherId = new List<XOtherCourseIdType>();
        }
        public List<XOtherCourseIdType> otherId { get; set; }
    }
}
