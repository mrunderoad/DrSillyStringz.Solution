namespace Factory.Models
{
  public class MachineLocation
  {
    public int MachineLocationId { get; set; }
    public int LocationId { get; set; }
    public int MachineId { get; set; }
    public virtual Location Location { get; set; }
    public virtual Machine Machine { get; set; }
  }
}