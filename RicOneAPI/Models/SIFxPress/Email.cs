using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// XEmailType
    /// </summary>
    public class Email
    {
        public Email()
        {
            emailType = null;
            emailAddress = null;
        }
        public string emailType { get; set; }
        public string emailAddress { get; set; }
    }
}
