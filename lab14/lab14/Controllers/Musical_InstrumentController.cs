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
    public class Musical_InstrumentController : Controller
    {
        private dotNetEntities db = new dotNetEntities();

        // GET: Musical_Instrument
        public async Task<ActionResult> Index()
        {
            var musical_Instrument = db.Musical_Instrument.Include(m => m.Musical_Instrument_Type);
            return View(await musical_Instrument.ToListAsync());
        }

        // GET: Musical_Instrument/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            if (musical_Instrument == null)
            {
                return HttpNotFound();
            }
            return View(musical_Instrument);
        }

        // GET: Musical_Instrument/Create
        public ActionResult Create()
        {
            ViewBag.typeId = new SelectList(db.Musical_Instrument_Type, "typeId", "title");
            return View();
        }

        // POST: Musical_Instrument/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,names,typeId,brand,photo")] Musical_Instrument musical_Instrument)
        {
            if (ModelState.IsValid)
            {
                db.Musical_Instrument.Add(musical_Instrument);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.typeId = new SelectList(db.Musical_Instrument_Type, "typeId", "title", musical_Instrument.typeId);
            return View(musical_Instrument);
        }

        // GET: Musical_Instrument/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            if (musical_Instrument == null)
            {
                return HttpNotFound();
            }
            ViewBag.typeId = new SelectList(db.Musical_Instrument_Type, "typeId", "title", musical_Instrument.typeId);
            return View(musical_Instrument);
        }

        // POST: Musical_Instrument/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,names,typeId,brand,photo")] Musical_Instrument musical_Instrument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musical_Instrument).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.typeId = new SelectList(db.Musical_Instrument_Type, "typeId", "title", musical_Instrument.typeId);
            return View(musical_Instrument);
        }

        // GET: Musical_Instrument/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            if (musical_Instrument == null)
            {
                return HttpNotFound();
            }
            return View(musical_Instrument);
        }

        // POST: Musical_Instrument/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            db.Musical_Instrument.Remove(musical_Instrument);
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
