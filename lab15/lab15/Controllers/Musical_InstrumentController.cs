using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using lab15.Models;

namespace lab15.Controllers
{
    public class Musical_InstrumentController : ApiController
    {
        private dotNetEntities db = new dotNetEntities();

        // GET: api/Musical_Instrument
        public IQueryable<Musical_Instrument> GetMusical_Instrument()
        {
            return db.Musical_Instrument;
        }

        // GET: api/Musical_Instrument/5
        [ResponseType(typeof(Musical_Instrument))]
        public async Task<IHttpActionResult> GetMusical_Instrument(int id)
        {
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            if (musical_Instrument == null)
            {
                return NotFound();
            }

            return Ok(musical_Instrument);
        }

        // PUT: api/Musical_Instrument/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMusical_Instrument(int id, Musical_Instrument musical_Instrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != musical_Instrument.id)
            {
                return BadRequest();
            }

            db.Entry(musical_Instrument).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Musical_InstrumentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Musical_Instrument
        [ResponseType(typeof(Musical_Instrument))]
        public async Task<IHttpActionResult> PostMusical_Instrument(Musical_Instrument musical_Instrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Musical_Instrument.Add(musical_Instrument);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = musical_Instrument.id }, musical_Instrument);
        }

        // DELETE: api/Musical_Instrument/5
        [ResponseType(typeof(Musical_Instrument))]
        public async Task<IHttpActionResult> DeleteMusical_Instrument(int id)
        {
            Musical_Instrument musical_Instrument = await db.Musical_Instrument.FindAsync(id);
            if (musical_Instrument == null)
            {
                return NotFound();
            }

            db.Musical_Instrument.Remove(musical_Instrument);
            await db.SaveChangesAsync();

            return Ok(musical_Instrument);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Musical_InstrumentExists(int id)
        {
            return db.Musical_Instrument.Count(e => e.id == id) > 0;
        }
    }
}