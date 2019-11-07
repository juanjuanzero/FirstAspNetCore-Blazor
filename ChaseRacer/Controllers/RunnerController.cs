using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaseRacer.Data;
using ChaseRacer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaseRacer.Controllers
{
    public class RunnerController : Controller
    {
        private readonly IRunnerData runnerData;
        public RunnerController(IRunnerData runnerData)
        {
            this.runnerData = runnerData;
        }
        public IActionResult Index()
        {
            var model = runnerData.GetRunners();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Runner() { };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Runner runner)
        {
            if (ModelState.IsValid)
            {
                runnerData.AddRunner(runner);
                return RedirectToAction("Index");
            }
            else
            {
                return View(runner);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = runnerData.GetRunner(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Runner runner)
        {
            if (ModelState.IsValid)
            {
                runnerData.UpdateRunner(runner);
                return RedirectToAction("Index");
            } else
            {
                return View(runner);
            }
        }

        public IActionResult Details(int id)
        {
            var model = runnerData.GetRunner(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = runnerData.GetRunner(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Runner runner)
        {
            if (ModelState.IsValid)
            {
                runnerData.RemoveRunner(runner);
                return RedirectToAction("Index");
            }
            else
            {
                return View(runner);
            }
        }


    }
}