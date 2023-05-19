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

    public ActionResult Details(int id)
    {
      Client foundClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
      return View(foundClient);
    }

    public ActionResult Edit(int id)
    {
      Client foundClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(foundClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Clients.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Client foundClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(foundClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client foundClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(foundClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}