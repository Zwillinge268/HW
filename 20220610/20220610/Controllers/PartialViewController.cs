using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20220610.Models;

namespace _20220610.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SimpleCard()
        {
            return View();
        }

        public ActionResult ManCard()
        {
            List<Card> cards = new List<Card>
            {
                new Card{ Name = "Elon Musk", Brief = "特斯拉創辦人 伊隆-馬斯克", Photo = "ElonMusk.jpg", WikiUrl = "https://en.wikipedia.org/wiki/Elon_Musk"},
                new Card{ Name = "Mark Zuckerberg", Brief = "Fackbook創辦人 馬克-祖伯克", Photo = "MarkZuckerberg.jpg", WikiUrl = "https://en.wikipedia.org/wiki/Mark_Zuckerberg"},
                new Card{ Name = "Steve Jobs", Brief = "蘋果創辦人 史提夫-賈伯斯", Photo = "SteveJobs.jpg", WikiUrl = "https://en.wikipedia.org/wiki/Steve_Jobs"},
                new Card{ Name = "Vader", Brief = "帝國元帥 維達", Photo = "Vader.jpg", WikiUrl = "https://en.wikipedia.org/wiki/Darth_Vader"},
                new Card{ Name = "Darth Mual", Brief = "星際大戰 達斯摩", Photo = "DarthMual.jpg", WikiUrl = "https://en.wikipedia.org/wiki/Darth_Maul"},
                new Card{ Name = "White Twilek", Brief = "星際大戰 女絕地武士", Photo = "WhiteTwilek.jpg", WikiUrl = "https://starwars.fandom.com/wiki/Twi%27lek/Legends"},
            };
            return View(cards);
        }
    }
}