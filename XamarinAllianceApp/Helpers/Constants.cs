using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAllianceApp.Helpers
{
    public class Constants
    {
        /// <summary>
        /// File name for the embedded characters JSON file
        /// </summary>
        public static readonly string CharactersFilename = "XamarinAllianceApp.characters.json";
        public static readonly string MobileServiceURL = "http://xamarinalliancebackend.azurewebsites.net";
        public static readonly string MobileServiceAuthenticationURL= "https://xamarinalliancesecurebackend.azurewebsites.net";
        public static readonly string StorageAccountURL = "https://xamarinalliance.blob.core.windows.net";
        public static readonly string XamarinAllianceLogoURL = "https://xamarinalliance.blob.core.windows.net/images/XAMARIN-Alliance-logo.png";
    }
}
