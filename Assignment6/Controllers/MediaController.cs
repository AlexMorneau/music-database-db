using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Controllers
{
    public class MediaController : Controller
    {
        Manager m = new Manager();

        //// GET: Media
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: audio (for track details)
        [Route("audio/{id}")]
        public ActionResult Details(int? id)
        {
            var trackAudio = m.TrackAudioGetById(id.GetValueOrDefault());

            if (trackAudio != null)
            {
                return File(trackAudio.Audio, trackAudio.AudioContentType);
            }

            return HttpNotFound();
        }

        // GET: media (for artist with details)
        [Route("media/{stringId}")]
        public ActionResult Details(string stringId = "")
        {
            var mediaContent = m.ArtistMediaContentGetById(stringId);

            if (mediaContent != null)
            {
                return File(mediaContent.Content, mediaContent.ContentType);
            }

            return HttpNotFound();
        }


        //// GET: Media/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Media/Create
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

        //// GET: Media/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Media/Edit/5
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

        //// GET: Media/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Media/Delete/5
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
