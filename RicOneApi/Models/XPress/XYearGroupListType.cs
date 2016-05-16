/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XGradeLevelListType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XGradeLevelListType
    /// </summary>
    public class XGradeLevelListType
    {
        public XGradeLevelListType()
        {
            gradeLevel = new List<String>();
        }
        public List<String> gradeLevel { get; set; }
    }
}
