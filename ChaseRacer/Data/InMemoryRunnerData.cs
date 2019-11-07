using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaseRacer.Models;

namespace ChaseRacer.Data
{
    public class InMemoryRunnerData : IRunnerData
    {
        public List<Runner> RunnerDb;

        public InMemoryRunnerData()
        {
            RunnerDb = new List<Runner>
            {
                new Runner{
                    RunnerId = 1, RunnerNumber = 1,
                    NickName = "Speedy",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van1
                },
                new Runner{
                    RunnerId = 2, RunnerNumber = 2,
                    NickName = "Quick",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van1
                },
                new Runner{
                    RunnerId = 3, RunnerNumber = 3,
                    NickName = "Swift",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van1
                },
                new Runner{
                    RunnerId = 4, RunnerNumber = 4,
                    NickName = "Rapid",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                },
                new Runner{
                    RunnerId = 5, RunnerNumber = 5,
                    NickName = "Turbo",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van1
                },
                new Runner{
                    RunnerId = 6, RunnerNumber = 6,
                    NickName = "Agile",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van1
                },
                new Runner{
                    RunnerId = 7, RunnerNumber = 7,
                    NickName = "Lightning",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                },
                new Runner{
                    RunnerId = 8, RunnerNumber = 8,
                    NickName = "Flash",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                },
                new Runner{
                    RunnerId = 9, RunnerNumber = 9,
                    NickName = "Blaze",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                },
                new Runner{
                    RunnerId = 10, RunnerNumber = 10,
                    NickName = "Hare",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                },
                new Runner{
                    RunnerId = 11, RunnerNumber = 11,
                    NickName = "Dart",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                },
                new Runner{
                    RunnerId = 12, RunnerNumber = 12,
                    NickName = "Zoom",
                    PaceMinutes = 7,
                    PaceSeconds = 30,
                    VanDesignation = Van.Van2
                }
            };
        }

        public bool AddRunner(Runner runner)
        {
            var id = RunnerDb.Count + 1;
            runner.RunnerId = id;
            RunnerDb.Add(runner);
            return true;
        }

        public Runner GetRunner(int id)
        {
            var runner = RunnerDb.FirstOrDefault(r => r.RunnerId == id);
            return runner;
        }

        public IEnumerable<Runner> GetRunners()
        {
            return RunnerDb;
        }

        public bool RemoveRunner(Runner runner)
        {
            RunnerDb.Remove(runner);
            return true;
        }

        public bool UpdateRunner(Runner runner)
        {
            var oldRunner = GetRunner(runner.RunnerId);
            oldRunner.Legs = runner.Legs;
            oldRunner.NickName = runner.NickName;
            oldRunner.PaceMinutes = runner.PaceMinutes;
            oldRunner.PaceSeconds = runner.PaceSeconds;
            oldRunner.RunnerNumber = runner.RunnerNumber;
            oldRunner.VanDesignation = runner.VanDesignation;

            return true;
        }
    }
}
