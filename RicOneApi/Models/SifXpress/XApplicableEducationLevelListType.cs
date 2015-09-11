/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XApplicableEducationLevelListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.SifXpress
{
    /// <summary>
    /// XApplicableEducationLevelListType
    /// </summary>
    public class XApplicableEducationLevelListType
    {
        public XApplicableEducationLevelListType()
        {
            applicableEducationLevel = new List<String>();
        }
        public List<String> applicableEducationLevel { get; set; }
    }
}
