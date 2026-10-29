using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;

        public _ContactComponentPartial()
        {
            _context = new MyPortfolioContext();
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.ToList();
            ViewBag.Description = _context.Contacts
            .Select(x => x.Descrition)
            .FirstOrDefault();

            return View(values);
        }
    }
}