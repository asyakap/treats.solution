using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace Orders.Controllers
{
  public class OrdersController : Controller
  {
    private readonly TreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public OrdersController(UserManager<ApplicationUser> userManager, TreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
  
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        Order[] orders = _db.Orders
                        .Where(entry => entry.User.Id == currentUser.Id)
                        .ToArray();
        model.Add("orders", orders);
      }
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Order order)
    {
      if (!ModelState.IsValid)
      {
        return View(order);
      }
      else
      {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        order.User = currentUser;
        _db.Orders.Add(order);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ViewBag.CurrentUser = userId;

      Order thisOrder = _db.Orders.FirstOrDefault(order => order.OrderId == id);
      return View(thisOrder);
    }

    public ActionResult Edit(int id)
    {
      Order thisOrder = _db.Orders.FirstOrDefault(order => order.OrderId == id);
      return View(thisOrder);
    }

    [HttpPost]
    public ActionResult Edit(Order order)
    {
      _db.Orders.Update(order);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  }


}