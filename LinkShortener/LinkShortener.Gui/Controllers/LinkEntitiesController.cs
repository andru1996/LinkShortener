﻿using LinkShortener.Data;
using LinkShortener.Gui.Helpers;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Net;
using System.Web.Mvc;

namespace LinkShortener.Gui.Controllers
{
    [Authorize]
    public class LinkEntitiesController : Controller
    {
        ILinkRepository _linkRepository = RepositoriesFactory.GetLinkRepository();

        // GET: Links       
        public ActionResult Index()
        {
            var userId = new Guid(User.Identity.GetUserId());
            var models = _linkRepository.GetLinksByCreatorId(userId);
            foreach (var model in models)
            {
                model.StringId = Helper.GetFullPathForLinkStringId(Request, model.StringId);
            }
            return View(models);
        }

        // GET: Links/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = _linkRepository.GetLink(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: LinkEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LinkEntities/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Url,Status")] Link model)
        {            
            if (ModelState.IsValid)
            {
                var userId = new Guid(User.Identity.GetUserId());
                model.CreatorId = userId;
                model.PublishedAt = DateTimeOffset.Now;
                model.UpdateAt = DateTimeOffset.Now;
                model.StringId = "a";
                model = _linkRepository.AddLink(model);
                model.StringId = Helper.ConvertLinkIdToChars(model.Id);
                model = _linkRepository.UpdateLink(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: LinkEntities/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = _linkRepository.GetLink(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: LinkEntities/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StringId,Url,CreatorId,Status,PublishedAt,UpdateAt")] Link model)
        {
            if (ModelState.IsValid)
            {
                model = _linkRepository.UpdateLink(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: LinkEntities/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = _linkRepository.GetLink(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: LinkEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            _linkRepository.DeleteLink(id);
            return RedirectToAction("Index");
        }
    }
}