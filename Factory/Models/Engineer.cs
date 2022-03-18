using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}