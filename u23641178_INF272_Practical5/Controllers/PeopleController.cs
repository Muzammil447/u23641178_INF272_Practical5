using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23641178_INF272_Practical5.Models;

namespace u23641178_INF272_Practical5.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public static List<PersonModel> people = new List<PersonModel>()
        {
            new PersonModel{
                StuNumber = "u0001",
                FirstName = "Name 1",
                LastName = "Surname 1",
                Email = "person1@tuks.co.za",


            },
            new Models.PersonModel
            {
                StuNumber = "u0002",
                FirstName = "Name 2",
                LastName = "Surname 2",
                Email = "person2@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u0003",
                FirstName = "Name 3",
                LastName = "Surname 3",
                Email = "person3@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u0004",
                FirstName = "Name 4",
                LastName = "Surname 4",
                Email = "person4@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u0005",
                FirstName = "Name 5",
                LastName = "Surname 5",
                Email = "person5@tuks.co.za",

            }
        };


        //get request for create
        public ActionResult Create()
        {
            return View();
        }

        //create a post request for create
        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                people.Add(person);
                return RedirectToAction("ListPeople");
            }
            return View(person);
        }

        public ActionResult ListPeople()
        {


            return View(people);

        }
    }
}
