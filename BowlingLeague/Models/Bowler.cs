using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public long BowlerID { get; set; }

        [Required(ErrorMessage ="Bowler must have a last name")]
        public string BowlerLastName { get; set; }

        [Required(ErrorMessage = "Bowler must have a first name")]
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }

        public string BowlerAddress { get; set; }

        public string BowlerCity { get; set; }

        [StringLength(2, MinimumLength = 0)]
        public string BowlerState { get; set; }
        // Bowler State can only be the two letter version of the state

        public string BowlerZip { get; set; }

        public string BowlerPhoneNumber { get; set; }
        public long? TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}
