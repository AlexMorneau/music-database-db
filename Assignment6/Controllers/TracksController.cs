using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Controllers
{
    [Authorize]
    public class TracksController : Controller
    {
        private Manager m = new Manager();

        // GET: Tracks
        public ActionResult Index()
        {
            return View(m.TrackGetAll());
        }

        // GET: Tracks/Details/5
        public ActionResult Details(int? id)
        {
            var trackFound = m.TrackGetById(id.GetValueOrDefault());

            if (trackFound != null)
            {
                return View(trackFound);
            }

            return HttpNotFound();
        }

        // GET: Tracks/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Tracks/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Tracks/Edit/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());

            if (track != null)
            {
                var form = new TrackEditFormViewModel();
                form.Name = track.Name;

                return View(form);
            }

            return HttpNotFound();
        }

        // POST: Tracks/Edit/5
        [Authorize(Roles = "Clerk")]
        [HttpPost]
        public ActionResult Edit(int? id, TrackEditViewModel track)
        {
            if (!ModelState.IsValid)
            {
                return View(track);
            }

            var editedTrack = m.TrackEdit(track);

            if (editedTrack != null)
            {
                return RedirectToAction("Details", new { id = editedTrack.Id });
            }

            return View(track);
        }

        // GET: Tracks/Delete/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id)
        {
            var trackToDelete = m.TrackGetById(id.GetValueOrDefault());

            if (trackToDelete != null)
            {
                return View(trackToDelete);
            }

            return RedirectToAction("Index");
        }

        // POST: Tracks/Delete/5
        [Authorize(Roles = "Clerk")]
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            var deletedTrack = m.TrackDelete(id.GetValueOrDefault());

            return RedirectToAction("Index");
        }
    }
}
