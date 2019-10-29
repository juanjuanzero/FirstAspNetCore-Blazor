using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaseRacer.Models
{
    public class Runner
    {
        public int RunnerId { get; set; }
        public int RunnerNumber { get; set; }
        public string NickName { get; set; }
        public int PaceMinutes { get; set; }
        public int PaceSeconds { get; set; }
        public Van VanDesignation { get; set; }
        public List<Leg> Legs { get; set; }
    }
}
