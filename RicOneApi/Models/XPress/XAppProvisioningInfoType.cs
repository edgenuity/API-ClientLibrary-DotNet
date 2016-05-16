using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XAppProvisioningInfoType
    /// </summary>
    public class XAppProvisioningInfoType
    {
        public XAppProvisioningInfoType()
        {
            loginId = null;
            tempPassword = null;
            tempPasswordExpiryDate = null;
        }

        public string loginId { get; set; }
        public string tempPassword { get; set; }
        public string tempPasswordExpiryDate { get; set; }
    }
}
