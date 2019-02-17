using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RavenDB_DotNetCore_App.Components
{
    [ViewComponent]
    public class Search : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string search = Request.Query["search"];

            return View((object)search);
        }
    }
}