using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> allStylists = _db.Stylists.ToList();
      ViewBag.AllStylistsList = allStylists;

      List<Client> allClients = _db.Clients.ToList();
      return View(allClients);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();

      List<Stylist> allStylists = _db.Stylists.ToList();
      ViewBag.AllStylistsList = allStylists;
      
      return RedirectToAction("Index");
    }
  }
}