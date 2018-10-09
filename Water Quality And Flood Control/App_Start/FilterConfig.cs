using System.Web;
using System.Web.Mvc;

namespace Water_Quality_And_Flood_Control
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
