using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public SpecialtyOptions Specialty { get; set; }
    public List<Client> Clients { get; set; }
  }

  public enum SpecialtyOptions
  {
    Wax,
    Spiky,
    Gel,
    Shmear,
    Twists,
    Braids,
    Color,
    Buzz,
    Trim,
    Bangs
  }
}