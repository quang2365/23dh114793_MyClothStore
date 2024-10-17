using System.Web;
using System.Web.Mvc;

namespace _23dh114793_MyClothStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
