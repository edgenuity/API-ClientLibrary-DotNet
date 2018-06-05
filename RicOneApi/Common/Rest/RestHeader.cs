/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6
 * Since       2018-05-14
 */
namespace RicOneApi.Common.Rest
{
    /// <summary>
    /// Accessor class for request headers. This includes paging, id, and shcool year. 
    /// </summary>
    class RestHeader
    {
        private int? navigationPage;
        private int? navigationPageSize;
        private string idType;
        // TODO - Should have declared this in RestProperties.... ¯\_(ツ)_/¯
        private string id;
        private int? schoolYear;

        public RestHeader()
        {
        }

        public RestHeader(int? schoolYear)
        {
            this.schoolYear = schoolYear;
        }

        public RestHeader(int? navigationPage, int? navigationPageSize)
        {
            this.navigationPage = navigationPage;
            this.navigationPageSize = navigationPageSize;
        }

        public RestHeader(string idType, string id)
        {
            this.idType = idType;
            this.id = id;
        }

        public RestHeader(int? navigationPage, int? navigationPageSize, int? schoolYear)
        {
            this.navigationPage = navigationPage;
            this.navigationPageSize = navigationPageSize;
            this.schoolYear = schoolYear;
        }

        public RestHeader(string idType, string id, int? schoolYear)
        {
            this.idType = idType;
            this.id = id;
            this.schoolYear = schoolYear;
        }

        public RestHeader(int? navigationPage, int? navigationPageSize, string idType, string id)
        {
            this.navigationPage = navigationPage;
            this.navigationPageSize = navigationPageSize;
            this.idType = idType;
            this.id = id;
        }

        public RestHeader(int? navigationPage, int? navigationPageSize, string idType, string id, int? schoolYear)
        {
            this.navigationPage = navigationPage;
            this.navigationPageSize = navigationPageSize;
            this.idType = idType;
            this.id = id;
            this.schoolYear = schoolYear;
        }

        public string GetNavigationPage()
        {
            return navigationPage.ToString();
        }

        public void SetNavigationPage(int? navigationPage)
        {
            this.navigationPage = navigationPage;
        }

        public string GetNavigationPageSize()
        {
             return navigationPageSize.ToString();
        }

        public void SetNavigationPageSize(int? navigationPageSize)
        {
            this.navigationPageSize = navigationPageSize;
        }

        public string IdType { get => idType; set => idType = value; }

        public string Id { get => id; set => id = value; }

        public string GetSchoolYear()
        {
            return schoolYear.ToString();
        }

        public void SetSchoolYear(int? schoolYear)
        {
            this.schoolYear = schoolYear;
        }

        public bool HasPaging() => navigationPage != null && navigationPageSize != null;
        public bool HasIdType() => !string.IsNullOrEmpty(idType) && !string.IsNullOrEmpty(id);
        public bool HasSchoolYear() => schoolYear != null;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
