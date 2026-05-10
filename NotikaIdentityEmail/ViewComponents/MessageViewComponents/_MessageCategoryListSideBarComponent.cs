using Microsoft.AspNetCore.Mvc;
using NotikaIdentityEmail.Context;

namespace NotikaIdentityEmail.ViewComponents.MessageViewComponents
{
    public class _MessageCategoryListSideBarComponent:ViewComponent
    {
        private readonly EmailContext _emailContext;

        public _MessageCategoryListSideBarComponent(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        public IViewComponentResult Invoke()
        {
            var values=_emailContext.Categories.ToList();
            return View(values);
        }

    }
}
