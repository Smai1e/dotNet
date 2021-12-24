using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab14.Models;

namespace lab14.Controllers
{
    public class Musical_Instrument_TypeController : Controller
    {
        private dotNetEntities db = new dotNetEntities();

        // GET: Musical_Instrument_Type
        public async Task<ActionResult> Index()
        {
            return View(await db.Musical_Instrument_Type.ToListAsync());
        }

        // GET: Musical_Instrument_Type/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            if (musical_Instrument_Type == null)
            {
                return HttpNotFound();
            }
            return View(musical_Instrument_Type);
        }

        // GET: Musical_Instrument_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musical_Instrument_Type/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "typeId,title,description")] Musical_Instrument_Type musical_Instrument_Type)
        {
            if (ModelState.IsValid)
            {
                db.Musical_Instrument_Type.Add(musical_Instrument_Type);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(musical_Instrument_Type);
        }

        // GET: Musical_Instrument_Type/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            if (musical_Instrument_Type == null)
            {
                return HttpNotFound();
            }
            return View(musical_Instrument_Type);
        }

        // POST: Musical_Instrument_Type/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "typeId,title,description")] Musical_Instrument_Type musical_Instrument_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musical_Instrument_Type).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(musical_Instrument_Type);
        }

        // GET: Musical_Instrument_Type/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            if (musical_Instrument_Type == null)
            {
                return HttpNotFound();
            }
            return View(musical_Instrument_Type);
        }

        // POST: Musical_Instrument_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            db.Musical_Instrument_Type.Remove(musical_Instrument_Type);
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
    }
}
