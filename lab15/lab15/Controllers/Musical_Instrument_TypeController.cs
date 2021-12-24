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
    public class Musical_Instrument_TypeController : ApiController
    {
        private dotNetEntities db = new dotNetEntities();

        // GET: api/Musical_Instrument_Type
        public IQueryable<Musical_Instrument_Type> GetMusical_Instrument_Type()
        {
            return db.Musical_Instrument_Type;
        }

        // GET: api/Musical_Instrument_Type/5
        [ResponseType(typeof(Musical_Instrument_Type))]
        public async Task<IHttpActionResult> GetMusical_Instrument_Type(int id)
        {
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            if (musical_Instrument_Type == null)
            {
                return NotFound();
            }

            return Ok(musical_Instrument_Type);
        }

        // PUT: api/Musical_Instrument_Type/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMusical_Instrument_Type(int id, Musical_Instrument_Type musical_Instrument_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != musical_Instrument_Type.typeId)
            {
                return BadRequest();
            }

            db.Entry(musical_Instrument_Type).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Musical_Instrument_TypeExists(id))
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

        // POST: api/Musical_Instrument_Type
        [ResponseType(typeof(Musical_Instrument_Type))]
        public async Task<IHttpActionResult> PostMusical_Instrument_Type(Musical_Instrument_Type musical_Instrument_Type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Musical_Instrument_Type.Add(musical_Instrument_Type);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = musical_Instrument_Type.typeId }, musical_Instrument_Type);
        }

        // DELETE: api/Musical_Instrument_Type/5
        [ResponseType(typeof(Musical_Instrument_Type))]
        public async Task<IHttpActionResult> DeleteMusical_Instrument_Type(int id)
        {
            Musical_Instrument_Type musical_Instrument_Type = await db.Musical_Instrument_Type.FindAsync(id);
            if (musical_Instrument_Type == null)
            {
                return NotFound();
            }

            db.Musical_Instrument_Type.Remove(musical_Instrument_Type);
            await db.SaveChangesAsync();

            return Ok(musical_Instrument_Type);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Musical_Instrument_TypeExists(int id)
        {
            return db.Musical_Instrument_Type.Count(e => e.typeId == id) > 0;
        }
    }
}