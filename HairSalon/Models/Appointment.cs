using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public string Time { get; set; }

    public int ClientId { get; set; }
    // navigation property
    public Client Client { get; set; }

    public int StylistId { get; set; }
    // navigation property
    public Stylist Stylist { get; set; }

  }
}