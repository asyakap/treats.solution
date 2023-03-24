using System;
using System.ComponentModel.DataAnnotations;

namespace Treats.Models
{
  public class Order
  {
    public int OrderId { get; set; }

    [Required(ErrorMessage = "Order's date can't be empty!")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Order's details can't be empty!")]
    public string Details { get; set; }
    public ApplicationUser User { get; set; }
    
}

}