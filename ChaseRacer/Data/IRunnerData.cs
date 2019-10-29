using ChaseRacer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaseRacer.Data
{
    interface IRunnerData
    {
        IEnumerable<Runner> GetRunners();
        void AddRunner();
        void RemoveRunner();
    }
}
