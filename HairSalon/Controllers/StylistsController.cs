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
      Dictionary <int, string> SpecialtyOptions = new Dictionary<int, string> {
        {1, "Color"},
        {2, "Buzz cuts"},
        {3, "Long cuts"},
        {4, "Bowl cuts"},
        {5, "Waxing"}
      };
      ViewBag.Specialty = new SelectList(SpecialtyOptions, "Value", "Value");
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
      Stylist foundStylist = _db.Stylists.Include(stylist => stylist.Clients).FirstOrDefault(stylist => stylist.StylistId == id);
      return View(foundStylist);
    }
  }
}