using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> allStylists = _db.Stylists.ToList();
      return View(allStylists);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist foundStylist = _db.Stylists.Include(stylist => stylist.Clients)
                                          .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(foundStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist foundStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId ==id);
      return View(foundStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Stylists.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist foundStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId ==id);
      return View(foundStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist foundStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId ==id);
      _db.Stylists.Remove(foundStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}