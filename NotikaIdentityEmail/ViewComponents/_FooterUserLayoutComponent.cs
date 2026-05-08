using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents
{
    public class _FooterUserLayoutComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
