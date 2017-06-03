using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;

namespace Client.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult DisplayCourse()
        {
            ApiConnection conn = new ApiConnection();
            ViewBag.listcourses = conn.FindAllCourse();
            return View();
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        // GET: Course/Create
        public ActionResult Create()
        {
            return View("CourseCreate");
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(CourseViewModel courseView)
        {
            try
            {
                ApiConnection conn = new ApiConnection();
                conn.Create(courseView.Course);

                return RedirectToAction("DisplayCourse");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
