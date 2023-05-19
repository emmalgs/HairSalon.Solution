using System;

namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
  }
}