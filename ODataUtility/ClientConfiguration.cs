using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataUtility
{
    public partial class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        //https://aih-dev-15c249eca061db62ddevaos.cloud.retail.dynamics.com/api/services/UserSessionService/AifUserSessionService/GetUserSessionInfo
        public static ClientConfiguration OneBox = new ClientConfiguration()
        {

            UriString = "https://icerobo-dev-34e4bae11287ed7d1devaos.cloudax.dynamics.com/",//"usnconeboxax1aos.cloud.onebox.dynamics.com",
            ActiveDirectoryResource = "https://icerobo-dev-34e4bae11287ed7d1devaos.cloudax.dynamics.com",//"usnconeboxax1aos.cloud.onebox.dynamics.com",
            ActiveDirectoryTenant = "https://login.windows.net/icerobo.com",//"login.windows.net/xxx.com",
            ActiveDirectoryClientAppId = "042e2a04-312d-4f78-8efd-562b1c658e53",//"applicationID",
            ActiveDirectoryClientAppSecret = "-Zp0WGYy697bUJDRpvMa@=X:ckf-arFs"//"12345646=",
        };

        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
    }
}
