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
    
    
  }


}