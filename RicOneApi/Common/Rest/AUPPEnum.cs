/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.3
 * Since       2018-08-14
 */
namespace RicOneApi.Common.Rest
{
    /// <summary>
    /// Class that mimics an enumerator that stores a text value.
    /// </summary>
    class AUPPEnum
    {
        internal static readonly AUPPEnum CREATE = new AUPPEnum("create");
        internal static readonly AUPPEnum DELETE = new AUPPEnum("delete");
        internal static readonly AUPPEnum DELETEPASSWORDS = new AUPPEnum("deletePasswords");
        internal static readonly AUPPEnum DELETEUSERNAMES = new AUPPEnum("deleteUsernames");
        internal static readonly AUPPEnum GET = new AUPPEnum("get");

        private AUPPEnum(string value)
        {
            Value = value;
        }

        internal string Value { get; private set; }
    }
}
