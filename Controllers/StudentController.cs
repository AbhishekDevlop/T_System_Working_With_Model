using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using T_System_Working_With_Model.Data;
using T_System_Working_With_Model.Models;

namespace T_System_Working_With_Model.Controllers
{
    public class StudentController : Controller
    {
        //ApplicationDbContext applicationDbContext;
        public readonly ApplicationDbContext applicationDbContext;

        public StudentController(ApplicationDbContext applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
        }


        public IActionResult Index()
        {

            return View(applicationDbContext.Student.ToList());
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student stud) 
            {

            applicationDbContext.Student.Add(stud);
            applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int rollNo) 
        { 
            
            var studDb = applicationDbContext.Student.FirstOrDefault(e => e.rollNo == rollNo);
            return View(studDb);
        }

        [HttpPost]

        public IActionResult Edit(Student stud) 
        {
            applicationDbContext.Entry(stud).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

      

        [HttpGet]

        public IActionResult Delete(int rollNo)
        { 
            var result = applicationDbContext.Student.FirstOrDefault(e => e.rollNo == rollNo);
            return View(result); 
        }
        
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int rollNo) 
        {
            //var result = applicationDbContext.Student.FirstOrDefault(e => e.rollNo == rollNo);
            var res = applicationDbContext.Student.Find(rollNo);
            applicationDbContext.Remove(res);
            applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
