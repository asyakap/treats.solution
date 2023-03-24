using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Treats.Models
{
  public class Flavor
    {
        public int FlavorId { get; set; }

        [Required(ErrorMessage = "The flavor's name can't be left empty!")]
        public string Name { get; set; }
        public List<FlavorTreat> JoinEntities { get;}
        public ApplicationUser User { get; set; } 
    }
}