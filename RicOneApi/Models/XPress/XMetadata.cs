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
            CustomClassName = null;
            LastModified = new DateTime();
            Password = null;
            SchoolYear = null;
            Username = null;
        }

        public string CustomClassName { get; set; }
        public DateTime LastModified { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string SchoolYear { get; set; }
    }
}
