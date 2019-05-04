using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CommentsWebService.Models;

namespace CommentsWebService.Controllers
{
    public class commentsController : Controller
    {
        private DBModel db = new DBModel();

        //The number of items per page
        int page_size = 5;
        // GET: comments
        public async Task<ActionResult> Index(int page = 0)
        {
            var comments = db.comments.OrderBy(y => y.commentID)
                .Skip(page * page_size)
                .Take(page_size);

            return View(await comments.ToListAsync());
        }

        // GET: comments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: comments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "commentID,commentDescription")] comment comment)
        {
            if (ModelState.IsValid)
                try
                {
                    {
                        db.comments.Add(comment);
                        await db.SaveChangesAsync();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception e)
                {
                    return RedirectToAction("Error");
                }

            return View(comment);
        }

        // GET: comments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comment comment = await db.comments.FindAsync(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: comments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "commentID,commentDescription")] comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        // GET: comments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comment comment = await db.comments.FindAsync(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            comment comment = await db.comments.FindAsync(id);
            db.comments.Remove(comment);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Error()
        {
            return View("UserError");
        }
    }
}
