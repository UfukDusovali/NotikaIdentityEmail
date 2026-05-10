using Microsoft.AspNetCore.Mvc;
using NotikaIdentityEmail.Context;

namespace NotikaIdentityEmail.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _context;

        public MessageController(EmailContext context)
        {
            _context = context;
        }

        public IActionResult Inbox()
        {
            var values = _context.Messages.Where(x=>x.ReceiverEmail=="ufuk@ufuk.com").ToList();
            return View(values);
        }

        public IActionResult Sendbox()
        {
            var values = _context.Messages.Where(x => x.SenderEmail == "ufuk@ufuk.com").ToList();
            return View(values);
        }

        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Where(x => x.MessageId == id).FirstOrDefault();
            return View(value);
        }
    }
}
