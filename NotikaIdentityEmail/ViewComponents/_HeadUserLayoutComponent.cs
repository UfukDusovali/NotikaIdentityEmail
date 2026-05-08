using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents
{
    public class _HeadUserLayoutComponent:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
