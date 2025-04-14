using System.Web;
using System.Web.Mvc;

namespace u23641178_INF272_Practical5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
