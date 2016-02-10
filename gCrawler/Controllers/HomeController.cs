using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gCrawler.Models;
using System.Reflection;
using System.Data;
using System.Net;

namespace gCrawler.Controllers
{
    public class HomeController : Controller
    {
        private DBPolyCrawlerEntities1 db = new DBPolyCrawlerEntities1();
        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }
        public ActionResult Details(string id)
        {
            return View(db.KeyWords.Where(k => k.project == id));
        }
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }
        //post create
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string nameProject, List<string> keyWords)
        {
            if (nameProject != "" &&  keyWords.Count()> 0) {
                Project pr = new Project();
                pr.IdProject = nameProject;
                db.Projects.Add(pr);
                db.SaveChanges();
                foreach (string k in keyWords) {
                    if (k != "")
                    {
                        KeyWord keys = new KeyWord();
                        keys.project = nameProject;
                        keys.idKeyWord = k;
                        db.KeyWords.Add(keys);
                        db.SaveChanges();
                    }
                   
                }
            }
            return RedirectToAction("Index");
           // return RedirectToAction("CreateKeywords",new {id = projetToCreate.IdProject});
        }
        

        [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult AddRowsKeyWord()
        {
            return View();
        }
       
        public ActionResult Occurrence(string id)
        {
            return View(db.Results.Where(k => k.project == id));
        }
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}