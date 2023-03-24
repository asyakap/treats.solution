using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Treats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "The treat's name can't be empty!")]
    public string TreatName { get; set; }

    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
    
}

}