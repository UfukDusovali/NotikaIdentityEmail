using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.ViewComponents
{
    public class _MainMenuUserLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
