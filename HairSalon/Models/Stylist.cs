using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string EmployeeName { get; set; }
    public string Title { get; set; }
    public string Speciality { get; set; }
    
    public List<Client> Clients { get; set; }
    public List<Stylist> Stylists { get; set; }

    public List<Appointment> Appointments { get; set; }
  }
}