using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSignature.Models;
using SmartSignature.Repository;

namespace SmartSignature.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listUser = userRepository.List();
            return View(listUser);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(Models.User user)
        {
            if (ModelState.IsValid)
            {
                userRepository.Insert(user);
                @TempData["message"] = "User has been successfully registered.";
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            var user = userRepository.Find(Id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(Models.User user)
        {
            if (ModelState.IsValid)
            {
                userRepository.Update(user);
                @TempData["message"] = "Changes has been successfully completed.";
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Find(int Id)
        {
            var user = userRepository.Find(Id);
            return View(user);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            userRepository.Delete(Id);
            @TempData["message"] = "The user has been successfully deleted.";
            return RedirectToAction("Index", "User");
        }
    }
}