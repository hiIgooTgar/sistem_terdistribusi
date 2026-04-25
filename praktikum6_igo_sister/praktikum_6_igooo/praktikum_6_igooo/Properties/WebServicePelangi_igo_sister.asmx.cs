using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace praktikum_6_igooo.Properties
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Pelangi(int angka)
        {
            if (angka == 1)
            {
                return "Merah";
            }
            else if (angka == 2)
            {
                return "Jingga";
            }
            else if (angka == 3)
            {
                return "Kuning";
            }
            else if (angka == 4)
            {
                return "Hijau";
            }
            else if (angka == 5)
            {
                return "Biru";
            }
            else if (angka == 6)
            {
                return "Nila";
            }
            else if (angka == 7)
            {
                return "Ungu";
            }
            else
            {
                return "Nomor antara 1 - 7";
            }
        }
    }
}
