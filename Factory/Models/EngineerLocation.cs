namespace Factory.Models
{
  public class EngineerLocation
  {
    public int EngineerLocationId { get; set; }
    public int EngineerId { get; set; }
    public int LocationId { get; set; }
    public virtual Engineer Engineer { get; set; }
    public virtual Location Location { get; set; }
  }
}