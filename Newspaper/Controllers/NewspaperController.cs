using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newspaper.Models;

namespace Newspaper.Controllers
{
    public class NewspaperController : Controller
    {
        abs_miscellaneousEntities db = new abs_miscellaneousEntities();
        // GET: Newspaper
        public ActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contries(int continentid)
        {
            List<country> list = db.country.ToList();
            var clist = from e in list where e.continentid == continentid select e;
            List<country> lists = clist.ToList();
            return View(lists);
        }
        [HttpGet]
        public ActionResult Newspapers(string CountryID)
        {
            List<content> paperslist = new List<content>();
            List<language> languagelist = db.language.ToList();

            var list2 = db.content.Where(e => e.countrycode == "" + CountryID).ToList();

            var res = list2.Join(languagelist, a => a.languageid, b => b.languageid, (a, b) => new { a, b.name }).ToList();

            foreach (var item in res)
            {
                content objpaper = new content();
                objpaper.metakeywords = item.a.title.Substring(0, 1);
                objpaper.id = item.a.id;
                objpaper.title = item.a.title;
                objpaper.url = item.a.url;
                objpaper.logo = item.a.logo;
                objpaper.id = item.a.id;
                objpaper.languageid = item.a.languageid;
                objpaper.continentid = item.a.continentid;
                objpaper.metadescription = item.a.metadescription;
                objpaper.logo = item.name;
                paperslist.Add(objpaper);
            }

            paperslist = paperslist.OrderBy(e => e.metakeywords).ToList();
            return View(paperslist);
        }


        public class Group<T, K>
        {
            public K Key;
            public IEnumerable<T> Values;
        }
    }
}