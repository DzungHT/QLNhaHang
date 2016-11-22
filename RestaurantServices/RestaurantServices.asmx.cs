using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using RestaurantServices.Business;
namespace RestaurantServices
{
    /// <summary>
    /// Summary description for RestaurantServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RestaurantServices : System.Web.Services.WebService
    {
        #region HuyNQ
        [WebMethod]
        public DataTable Login(String username, String password)
        {
            AccountDAO acc = new AccountDAO();
            return acc.Login(username, password);
        }
        #endregion
        #region  DoanVD

        #endregion
        #region DzungHT
        #endregion
    }
}
