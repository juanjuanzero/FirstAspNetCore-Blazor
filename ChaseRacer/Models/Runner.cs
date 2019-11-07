using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChaseRacer.Models
{
    public class Runner
    {
        public int RunnerId { get; set; }
        [Display(Name ="Runner Number")]
        public int RunnerNumber { get; set; }
        [Display(Name = "Nickname")]
        public string NickName { get; set; }

        [Range(1,60, ErrorMessage ="The value must be between 1 and 60 minutes")]
        [Display(Name ="Pace Minutes")]
        public int PaceMinutes { get; set; }
        [Range(1, 60, ErrorMessage = "The value must be between 1 and 60 seconds")]
        [Display(Name ="Pace Seconds")]
        public int PaceSeconds { get; set; }
        [Display(Name = "Van Designation")]
        public Van VanDesignation { get; set; }
        public List<Leg> Legs { get; set; }

        public string RunnerPace()
        {
            return PaceMinutes.ToString().PadLeft(2,'0') + ":" + PaceSeconds.ToString();
        }
    }
}
