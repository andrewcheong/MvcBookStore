using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBookStore.Web.Domain;
using MvcBookStore.Web.Database;

namespace MvcBookStore.Web.Areas.Admin.Controllers
{ 
    public class AuthorController : Controller
    {
        private MvcBookStoreDbContext db = new MvcBookStoreDbContext();

        //
        // GET: /Admin/Author/

        public ViewResult Index()
        {
            return View(db.Authors.ToList());
        }

        //
        // GET: /Admin/Author/Details/5

        public ViewResult Details(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // GET: /Admin/Author/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Author/Create

        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(author);
        }
        
        //
        // GET: /Admin/Author/Edit/5
 
        public ActionResult Edit(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // POST: /Admin/Author/Edit/5

        [HttpPost]
        public ActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                db.Entry(author).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(author);
        }

        //
        // GET: /Admin/Author/Delete/5
 
        public ActionResult Delete(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // POST: /Admin/Author/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Author author = db.Authors.Find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}