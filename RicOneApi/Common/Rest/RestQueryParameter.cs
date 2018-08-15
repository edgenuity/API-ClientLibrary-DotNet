/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.3
 * Since       2018-08-14
 */
namespace RicOneApi.Common.Rest
{
    /// <summary>
    /// Accessor class for request query parameters. This includes opaque marker, and account user passwrod provisioning.
    /// </summary>
    class RestQueryParameter
    {
        private string opaqueMarker;
        private AUPPEnum aupp;

        public RestQueryParameter()
        {
        }

        public RestQueryParameter(string opaqueMarker)
        {
            this.opaqueMarker = opaqueMarker;
        }

        public RestQueryParameter(AUPPEnum aupp)
        {
            this.aupp = aupp;
        }

        public string OpaqueMarker { get => opaqueMarker; set => opaqueMarker = value; }
        internal AUPPEnum Aupp { get => aupp; set => aupp = value; }

        public bool HasOpaqueMarker() => !string.IsNullOrEmpty(opaqueMarker);

        internal bool HasAUPP()
        {
            if(aupp != null)
            {
                return true;
            }
            return false;
        }

        public bool IsCreateUsers()
        {
            if(aupp != null)
            {
              return aupp.Equals(AUPPEnum.CREATE);
            }
            return false;
        }

        public bool IsDeleteUsers()
        {
            if (aupp != null)
            {
                return aupp.Equals(AUPPEnum.DELETE);
            }
            return false;
        }

        public bool IsDeletePasswords()
        {
            if(aupp != null)
            {
                return aupp.Equals(AUPPEnum.DELETEPASSWORDS);
            }
            return false;
        }

        public bool IsDeleteUsernames()
        {
            if(aupp != null)
            {
                return aupp.Equals(AUPPEnum.DELETEUSERNAMES);
            }
            return false;
        }

        public bool IsGetUsers()
        {
            if (aupp != null)
            {
                return aupp.Equals(AUPPEnum.GET);
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
