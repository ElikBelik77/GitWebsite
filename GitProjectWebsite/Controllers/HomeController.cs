using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GitProjectWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GitPuller puller = new GitPuller();
            List<Repository> repos = puller.GetAllRepositories();
            ViewBag.Repositories = repos;
            Repeater r = new Repeater();
            r.DataSource = repos;
            r.DataBind();
            Table t = new Table();
            t.Rows.Add(new TableRow());
            ViewBag.Repositories = repos;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}