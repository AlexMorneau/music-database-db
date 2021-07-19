using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Controllers
{
    [Authorize]
    public class ArtistsController : Controller
    {
        private Manager m = new Manager();


        // GET: Artists
        public ActionResult Index()
        {
            return View(m.ArtistGetAll());
        }

        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            var artistFound = m.ArtistWithMediaInfoGetById(id.GetValueOrDefault());

            if (artistFound != null)
            {
                return View(artistFound);
            }
            else
            {
                return HttpNotFound();
            }
            
        }

        // GET: Artists/Create
        [Authorize(Roles = "Executive")]
        public ActionResult Create()
        {
            var form = new ArtistAddFormViewModel();

            form.GenreList = new SelectList(m.GenreGetAll(),
                dataValueField: "Id",
                dataTextField: "Name");

            return View(form);
        }

        // POST: Artists/Create
        [Authorize(Roles = "Executive")]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(ArtistAddViewModel newArtist)
        {

           if (!ModelState.IsValid)
            {
                return View(newArtist);
            }

            var addedArtist = m.ArtistAdd(newArtist);

            if (addedArtist != null)
            {
                return RedirectToAction("Details", new { id = addedArtist.Id });
            }

            return View(newArtist);


        }


        // GET: Artists/5/AddAlbum
        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddAlbum")]
        public ActionResult AddAlbum(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault()); // find related artist

            if (artist != null)
            {
                var form = new AlbumAddFormViewModel();
                form.ArtistId = artist.Id; // id not required?
                form.ArtistName = artist.Name;

                form.GenreList = new SelectList(m.GenreGetAll(),
                    dataValueField: "Id",
                    dataTextField: "Name");

                return View(form);
            }

            return HttpNotFound();
        }

        //POST: Artists/5/AddAlbum
        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddAlbum")]
        [HttpPost]
        [ValidateInput(false)] // rich text
        public ActionResult AddAlbum(AlbumAddViewModel newAlbum)
        {
            if (!ModelState.IsValid)
            {
                return View(newAlbum);
            }

            var addedAlbum = m.AlbumAdd(newAlbum);

            if (addedAlbum == null)
            {
                return View(newAlbum);
            }

            return RedirectToAction("Details", "Albums", new { id = addedAlbum.Id }); // success
        }


        // AM92: coordinator role here

        // GET: Artists/5/AddArtistMediaItem
        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddArtistMediaItem")]
        public ActionResult AddArtistMediaItem(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if (artist != null)
            {
                var form = new ArtistMediaItemAddFormViewModel();
                form.ArtistId = artist.Id;
                form.ArtistName = artist.Name;

                return View(form);
            }

            return HttpNotFound();
        }


        // POST: Artists/5/AddArtistMediaItem
        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddArtistMediaItem")]
        [HttpPost]
        public ActionResult AddArtistMediaItem(int? id, ArtistMediaItemAddViewModel newArtistMediaItem)
        {
            if (!ModelState.IsValid)
            {
                return View(newArtistMediaItem);
            }

            var addedArtistMediaItem = m.AddArtistMediaItem(newArtistMediaItem);

            if (addedArtistMediaItem != null)
            {
                return RedirectToAction("Details", new { id = addedArtistMediaItem.Id });
            }

            return View(newArtistMediaItem);
        }




        // GET: Artists/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Artists/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Artists/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Artists/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
