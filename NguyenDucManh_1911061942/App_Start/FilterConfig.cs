using System.Web;
using System.Web.Mvc;

namespace NguyenDucManh_1911061942
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
