using System.Collections.Generic;

namespace Factory.Models
{
  public class Location
  {
    public Location()
    {
      this.JoinEntities1 = new HashSet<EngineerLocation>();
      this.JoinEntities2 = new HashSet<MachineLocation>();
    }

    public int LocationId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<EngineerLocation> JoinEntities1 { get; set; } 
    public virtual ICollection<MachineLocation> JoinEntities2 { get; set; }
  }
}