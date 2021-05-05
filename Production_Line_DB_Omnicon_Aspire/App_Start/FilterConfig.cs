using System.Web;
using System.Web.Mvc;

namespace Production_Line_DB_Omnicon_Aspire
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
