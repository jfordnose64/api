using System;
using System.Linq;

namespace api.Models
{
  public class Address
  {
    public int Id { get; set; }
    public int Latitude { get; set; }
    public int Longitude { get; set; }
    public Boolean damage { get; set; }
    public DateTime DateReported { get; set; } = DateTime.Now;
  }
}