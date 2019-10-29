using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaseRacer.Models;

namespace ChaseRacer.Data
{
    public interface ILegData
    {
        IEnumerable<Leg> GetLegs();
        bool AddLeg(Leg leg);
        bool RemoveLeg(Leg leg);

        bool EditLeg(Leg leg);
        Leg GetLeg(int id);
    }
}
