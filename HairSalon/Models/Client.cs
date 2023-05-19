namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string Appointments { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}