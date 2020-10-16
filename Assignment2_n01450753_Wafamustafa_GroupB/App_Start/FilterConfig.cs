using System.Web;
using System.Web.Mvc;

namespace Assignment2_n01450753_Wafamustafa_GroupB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
