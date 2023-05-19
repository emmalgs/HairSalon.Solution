using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly HairSalonContext _db;
    public AppointmentsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Appointment> appointments = _db.Appointments
                                    .Include(model => model.Client)
                                    .Include(model => model.Stylist)
                                    .ToList();
      return View(appointments);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment appointment)
    {
      // update client to stylist if stylist does not have client in list
      // Stylist foundStylist = _db.Stylists.Include(stylist => stylist.Clients).FirstOrDefault(stylist => stylist.StylistId == appointment.StylistId);
      // List<Client> clients = foundStylist.Clients;
      // foreach (Client client in clients)
      // {
      //   if (client.ClientId == appointment.ClientId)
      //   {
      //     client.StylistId = appointment.StylistId;
      //     _db.Clients.Update(client);
      //     _db.SaveChanges();
      //   }
      // }
      _db.Appointments.Add(appointment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Appointment foundApt = _db.Appointments.Include(model => model.Client)
                                            .Include(model => model.Stylist)
                                            .FirstOrDefault(model => model.AppointmentId == id);
      return View(foundApt);
    }

    public ActionResult Edit(int id)
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
      Appointment foundApt = _db.Appointments.FirstOrDefault(model => model.AppointmentId == id);
      return View(foundApt);
    }

    [HttpPost]
    public ActionResult Edit(Appointment appointment)
    {
      int id = appointment.AppointmentId;
      _db.Appointments.Update(appointment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    } 
  }
}