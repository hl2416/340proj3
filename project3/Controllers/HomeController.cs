using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using project3.Services;

namespace project3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //load, get, and populate the model with the data then calls the view for About
        public async Task<IActionResult> About()
        {
            var getAbout = new GetAbout();
            var loadedAbout = await getAbout.getAbout();
            var aboutModel = new AboutRootModel()
            {
                About = loadedAbout
            };
            return View(aboutModel);
        }
        //load, get, and populate the model with the data then calls the view for Degrees
        public async Task<IActionResult> Degrees()
        {
            var getUD = new GetUDegrees();
            var loadedUD = await getUD.getUDegrees();
            var getGD = new GetGDegrees();
            var loadedGD = await getGD.getGDegrees();
            var degreeModel = new DegreesRootModel()
            {
                undergraduate = loadedUD.ToList(),
                graduate = loadedGD.ToList()
            };
            return View(degreeModel);
        }
        //load, get, and populate the model with the data then calls the view for Minors
        public async Task<IActionResult> UgMinors()
        {
            var getUgM = new GetUgMinors();
            var loadedUgM = await getUgM.getUgMinors();
            var getC = new GetCourses();
            var loadedC = await getC.getCourses();
            var ugMinorsModel = new UgMinorsRootModel()
            {
                ugMinors = loadedUgM.ToList(),
                courses = loadedC
            };
            return View(ugMinorsModel);
        }
        //load, get, and populate the model with the data then calls the view for Employment
        public async Task<IActionResult> Employment()
        {
            var getEmp = new GetEmployment();
            var loadedEmp = await getEmp.getEmployment();
            var employmentModel = new EmploymentRootModel()
            {
                introduction = loadedEmp.introduction,
                degreeStatistics = loadedEmp.degreeStatistics,
                employers = loadedEmp.employers,
                careers = loadedEmp.careers,
                coopTable = loadedEmp.coopTable,
                employmentTable = loadedEmp.employmentTable
            };
            return View(employmentModel);
        }
        //load, get, and populate the model with the data then calls the view for Faculty
        public async Task<IActionResult> Faculty()
        {
            var getFac = new GetFaculty();
            var loadedFac = await getFac.getAllFaculty();
            var facultyModel = new FacultyRootModel()
            {
                faculty = loadedFac.ToList()
            };
            return View(facultyModel);
        }
        //load, get, and populate the model with the data then calls the view for Staff
        public async Task<IActionResult> Staff()
        {
            var getSta = new GetStaff();
            var loadedSta = await getSta.getAllStaff();
            var staffModel = new StaffRootModel()
            {
                staff = loadedSta.ToList()
            };
            return View(staffModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
