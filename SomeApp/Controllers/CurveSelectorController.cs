using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SomeApp.Controllers
{
    


    /// <summary>
    /// MVC controller that displays the Wind turbine curve selector.
    /// </summary>
    [RoutePrefix("curveselector")]
    [Authorize]
    public class CurveSelectorController : Controller
    {
        /// <summary>
        /// Logging.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger<CurveSelectorController>();


        // GET: CurveSelector        
        public ActionResult Index()
        {
            try
            {
                return View(); // 200
            }
            catch (Exception e)
            {
                Log.Error($"An error occurred in {nameof(CurveSelectorController)}.{nameof(Index)}.", e);
                throw; // 500
            }
        }

        // GET: CurveSelector/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CurveSelector/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CurveSelector/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
    }
}
