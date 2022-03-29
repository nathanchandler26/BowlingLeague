using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models
{
    public class Team
    {
        [Key]
        [Required]
        public long TeamID { get; set; }

        //[Required]
        public string TeamName { get; set; }
        public long? CaptainID { get; set; }
        public virtual ICollection<Bowler> Bowlers { get; set; }
    }
}
