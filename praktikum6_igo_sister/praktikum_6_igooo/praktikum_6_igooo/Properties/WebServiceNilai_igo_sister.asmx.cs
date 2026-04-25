using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace praktikum_6_igooo.Properties
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string nilai(int angka)
        {
            if (angka >= 80 && angka <= 100)
            {
                return "Excelent"; 
            }
            else if (angka >= 70)
            {
                return "Good Job";
            }
            else if (angka >= 60)
            {
                return "Not Bad"; 
            }
            else
            {
                return "Remidial"; 
            }
        }
    }
}
