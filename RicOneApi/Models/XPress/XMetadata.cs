using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-12-20
 * Filename    XStudentType.cs
 */
namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XMetadata
    /// </summary>
    public class XMetadata
    {
        public XMetadata()
        {
            SchoolYear = null;
            LastModified = new DateTime();
        }

        public string SchoolYear { get; set; }
        public DateTime LastModified { get; set; }
    }
}
