using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XEmailListType
    /// </summary>
    public class OtherEmails
    {
        public OtherEmails()
        {
            email = new List<Email>();
        }
        public List<Email> email { get; set; }
    }
}
