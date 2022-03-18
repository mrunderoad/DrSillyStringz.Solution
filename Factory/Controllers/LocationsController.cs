using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  
  public class LocationsController : Controller
  {
    
    private readonly FactoryContext _db;
    public LocationsController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Location> model = _db.Locations.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Location location, int LocationId)
    {
      _db.Locations.Add(location);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisLocation = _db.Locations
        .Include(location => location.JoinEntities1)
        .ThenInclude(join => join.Engineer)
        .Include(location => location.JoinEntities2)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(location => location.LocationId == id);
      return View(thisLocation);
    }

    public ActionResult Edit(int id)
    {
      var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
      return View(thisLocation);
    }

    [HttpPost]
    public ActionResult Edit(Location location)
    {
      _db.Entry(location).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
      return View(thisLocation);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
      _db.Locations.Remove(thisLocation);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
      var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisLocation);
    }

    [HttpPost]
    public ActionResult AddMachine(Location location, int MachineId)
    {
      if (MachineId != 0)
      {
        _db.MachineLocation.Add(new MachineLocation() { MachineId = MachineId, LocationId = location.LocationId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
      var joinEntry = _db.MachineLocation.FirstOrDefault(joinEntry => joinEntry.MachineLocationId == joinId);
      _db.MachineLocation.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddEngineer(int id)
    {
      var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisLocation);
    }

    [HttpPost]
    public ActionResult AddEngineer(Location location, int EngineerId)
    {
      if (EngineerId != 0)
      {
        _db.EngineerLocation.Add(new EngineerLocation() { EngineerId = EngineerId, LocationId = location.LocationId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteEngineer(int joinId)
    {
      var joinEntry = _db.EngineerLocation.FirstOrDefault(joinEntry => joinEntry.EngineerLocationId == joinId);
      _db.EngineerLocation.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}