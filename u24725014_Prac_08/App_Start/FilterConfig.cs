using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
