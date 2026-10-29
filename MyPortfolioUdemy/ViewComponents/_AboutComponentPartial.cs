using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubTitle = portfolioContext.Abouts.Select(x => x.SubTitle).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Detail).FirstOrDefault();
            return View();
        }
    }
}

