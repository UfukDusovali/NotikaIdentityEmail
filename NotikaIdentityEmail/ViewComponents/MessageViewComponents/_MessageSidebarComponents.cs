using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents.MessageViewComponents
{
    public class _MessageSidebarComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
