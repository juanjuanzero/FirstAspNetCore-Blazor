using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaseRacer.Models;

namespace ChaseRacer.Data
{
    public class InMemoryLegData : ILegData
    {
        public List<Leg> LegsDb { get; set; }

        public InMemoryLegData()
        {
            LegsDb = new List<Leg>()
            {
                new Leg {LegId =1, LegNumber = 1, LegDistance = 7.4 },
                new Leg {LegId =2, LegNumber = 2, LegDistance = 7.3 },
                new Leg {LegId =3, LegNumber = 3, LegDistance = 3.5 },
                new Leg {LegId =4, LegNumber = 4, LegDistance = 5.2 },
                new Leg {LegId =5, LegNumber = 5, LegDistance = 4.5 },
                new Leg {LegId =6, LegNumber = 6, LegDistance = 6.2 },
                new Leg {LegId =7, LegNumber = 7, LegDistance = 4.9 },
                new Leg {LegId =8, LegNumber = 8, LegDistance = 4.8 },
                new Leg {LegId =9, LegNumber = 9, LegDistance = 9 },
                new Leg {LegId =10, LegNumber = 10, LegDistance = 7.4 },
                new Leg {LegId =11, LegNumber = 11, LegDistance = 6.3 },
                new Leg {LegId =12, LegNumber = 12, LegDistance = 5.8 },
                new Leg {LegId =13, LegNumber = 13, LegDistance = 4.5 },
                new Leg {LegId =14, LegNumber = 14, LegDistance = 6.5 },
                new Leg {LegId =15, LegNumber = 15, LegDistance = 3.2 },
                new Leg {LegId =16, LegNumber = 16, LegDistance = 6.6 },
                new Leg {LegId =17, LegNumber = 17, LegDistance = 5.4 },
                new Leg {LegId =18, LegNumber = 18, LegDistance = 6.3 },
                new Leg {LegId =19, LegNumber = 19, LegDistance = 3.4 },
                new Leg {LegId =20, LegNumber = 20, LegDistance = 5.7 },
                new Leg {LegId =21, LegNumber = 21, LegDistance = 5.1 },
                new Leg {LegId =22, LegNumber = 22, LegDistance = 5.3 },
                new Leg {LegId =23, LegNumber = 23, LegDistance = 4.3 },
                new Leg {LegId =24, LegNumber = 24, LegDistance = 4.6 },
                new Leg {LegId =25, LegNumber = 25, LegDistance = 7.3 },
                new Leg {LegId =26, LegNumber = 26, LegDistance = 7.8 },
                new Leg {LegId =27, LegNumber = 27, LegDistance = 5.3 },
                new Leg {LegId =28, LegNumber = 28, LegDistance = 3.7 },
                new Leg {LegId =29, LegNumber = 29, LegDistance = 7.7 },
                new Leg {LegId =30, LegNumber = 30, LegDistance = 5 },
                new Leg {LegId =31, LegNumber = 31, LegDistance = 4.6 },
                new Leg {LegId =32, LegNumber = 32, LegDistance = 8.4 },
                new Leg {LegId =33, LegNumber = 33, LegDistance = 4.6 },
                new Leg {LegId =34, LegNumber = 34, LegDistance = 6.6 },
                new Leg {LegId =35, LegNumber = 35, LegDistance = 4.1 },
                new Leg {LegId =36, LegNumber = 36, LegDistance = 4.8 }
            };
        }


        public IEnumerable<Leg> GetLegs()
        {
            return LegsDb;
        }


        public bool AddLeg(Leg leg)
        {
            try
            {
                var count = LegsDb.Count + 1;
                var newLeg = new Leg() { LegId = count, LegNumber = leg.LegNumber, LegDistance = leg.LegDistance };
                LegsDb.Add(newLeg);
                return true;
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                return false;
            }

        }

        public bool RemoveLeg(Leg leg)
        {
            try
            {
                LegsDb.Remove(leg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Leg GetLeg(int id)
        {
            var leg = LegsDb.FirstOrDefault(l => l.LegId == id);
            return leg;
        }

        public bool EditLeg(Leg leg)
        {
            try
            {
                var editedLeg = GetLeg(leg.LegId);
                editedLeg.LegDistance = leg.LegDistance;
                editedLeg.LegNumber = leg.LegNumber;
                return true;
            } catch (Exception)
            {
                return false;
            }
            
        }
    }
}
