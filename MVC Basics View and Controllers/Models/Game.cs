using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics_View_and_Controllers.Models
{
    public class GameModel
    {
        [Required(ErrorMessage = "Please enter number")]
        public int Number { get; set; }
    }
}
