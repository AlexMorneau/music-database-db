using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {
        private Manager m = new Manager();

        // GET: Albums
        public ActionResult Index()
        {
            return View(m.AlbumGetAll());
        }

        // GET: Albums/Details/5
        public ActionResult Details(int? id)
        {
            var albumFound = m.AlbumGetById(id.GetValueOrDefault());

            if (albumFound != null)
            {
                return View(albumFound);
            }

            return HttpNotFound();
        }

        // GET: AddTrack (prompted from Album Details view)
        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        public ActionResult AddTrack(int? id)
        {
            var album = m.AlbumGetById(id.GetValueOrDefault());

            if (album != null)
            {
                var trackForm = new TrackAddFormViewModel();
                trackForm.AlbumId = album.Id;
                trackForm.AlbumName = album.Name;

                trackForm.GenreList = new SelectList(m.GenreGetAll(),
                    dataValueField: "Id",
                    dataTextField: "Name");

                return View(trackForm);
            }

            return HttpNotFound();
        }



        // POST: Albums/5/AddTrack
        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        [HttpPost]
        public ActionResult AddTrack(TrackAddViewModel newTrack)
        {
            if (!ModelState.IsValid)
            {
                return View(newTrack);
            }

            var addedTrack = m.TrackAdd(newTrack);

            if (addedTrack != null)
            {
                return RedirectToAction("Details", "Tracks", new { id = addedTrack.Id });
            }

            return RedirectToAction("Albums", "Index");
        }


        // GET: Albums/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Albums/Create
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

        // GET: Albums/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Albums/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Albums/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Albums/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
