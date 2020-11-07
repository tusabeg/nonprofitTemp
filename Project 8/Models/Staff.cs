using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_8.Models
{
   public class Staff
   {
      // Fields and properties

      public int Id { get; set; }
      
      [Required(ErrorMessage = "Staff Name Is Required")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Age Is Required")]
      public string Age { get; set; }

      // Constructors

      // Methods
   }
}
