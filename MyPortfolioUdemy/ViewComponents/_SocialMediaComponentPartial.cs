
using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SocialMediaComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;

        public _SocialMediaComponentPartial()
        {
            _context = new MyPortfolioContext();
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }
    }
}
