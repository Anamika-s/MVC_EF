using Microsoft.AspNetCore.Mvc;
using MVC_EF.Models;
using MVC_EF.Repository;

namespace MVC_EF.Controllers
{

    //class Car
    //{
    //      Wheel _wheel;
    //      Engine _engine;
    //    public Car()
    //    {
    //        Wheel wheel = new Wheel();
    //        Engine engine = new Engine();
    //    }
    //    public Car(Wheel wheel, Engine engine)
    //    {
    //        _wheel = wheel;
    //          _engine = engine;
    //    }
    //}
    public class UserController : Controller
    {
        IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {

            return View(_repo.GetUsers());
        }
        public IActionResult Create() {
        
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user) {
            _repo.Create(user);
            return RedirectToAction("Index");
        }
    }
}
