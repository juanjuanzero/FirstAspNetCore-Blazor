using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaseRacer.Data;
using ChaseRacer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaseRacer.Controllers
{
    public class LegController : Controller
    {
        private ILegData legData;
        public LegController(ILegData legData)
        {
            this.legData = legData;
        }
        public IActionResult Index()
        {
            var legs = legData.GetLegs();
            return View(legs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var leg = new Leg();
            return View(leg);
        }

        [HttpPost]
        public IActionResult Create(Leg leg)
        {
            var a = legData.AddLeg(leg);
            if (a)
            {
                return RedirectToAction("Index");
            } else
            {
                return View(leg);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var leg = legData.GetLeg(id);
            return View(leg);
        }

        [HttpPost]
        public IActionResult Edit(Leg leg)
        {
            var a = legData.EditLeg(leg);
            if (a)
            {
                return RedirectToAction("Index");
            } else
            {
                return View(leg);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var leg = legData.GetLeg(id);
            return View(leg);
        }

        public IActionResult Delete(Leg leg)
        {
            var a = legData.RemoveLeg(leg);
            if (a)
            {
                return RedirectToAction("Index");
            }
            else { return View(leg); }
        }

        public IActionResult Details(int id)
        {
            var leg = legData.GetLeg(id);
            return View(leg);
        }
    }
}