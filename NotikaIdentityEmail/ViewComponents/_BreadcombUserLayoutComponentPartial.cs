using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents
{
    public class _BreadcombUserLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
