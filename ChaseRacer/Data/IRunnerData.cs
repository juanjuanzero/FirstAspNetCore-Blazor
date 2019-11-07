using ChaseRacer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaseRacer.Data
{
    public interface IRunnerData
    {
        IEnumerable<Runner> GetRunners();
        bool AddRunner(Runner runner);
        bool RemoveRunner(Runner runner);
        Runner GetRunner(int id);
        bool UpdateRunner(Runner runner);
    }
}
