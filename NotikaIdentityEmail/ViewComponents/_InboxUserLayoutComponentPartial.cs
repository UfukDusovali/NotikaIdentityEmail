using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents
{
    public class _InboxUserLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
