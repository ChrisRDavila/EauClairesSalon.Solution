namespace HairSalon.Models
{
  public class Stylist
  {
    public string StylistName { get; set; }
    public int StylistId { get; set; }
    public string HireDate { get; set; }
    public List<Client> Clients { get; set; }
  }
}