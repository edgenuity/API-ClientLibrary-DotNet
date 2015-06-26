using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneAPI.Models.SIFxPress
{
    /// <summary>
    /// Root Object
    /// </summary>
    public class XStudentsRoot
    {
        public XStudentsRoot()
        {
            xStudents = null;
        }
        public XStudents xStudents { get; set; }
    }
}
