using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSignature.Models;

namespace SmartSignature.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            IList<Models.User> userList = new List<Models.User>();
            userList.Add(new Models.User()
            {
                CaixaAccount = 123456789,
                Password = 123456,
                Name = "Robert Watson",
                Rg = 123456789,
                Cpf = 12312312312
            });
            userList.Add(new Models.User()
            {
                CaixaAccount = 987654321,
                Password = 654321,
                Name = "Ellie Watson",
                Rg = 987654321,
                Cpf = 32132132121
            });
            userList.Add(new Models.User()
            {
                CaixaAccount = 123456780,
                Password = 123450,
                Name = "Carl Smith",
                Rg = 123456780,
                Cpf = 12312312310
            });
            return View(userList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            System.Diagnostics.Debug.Print("Running 'Add()' Action: true");
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(Models.User user)
        {
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.Print("Caixa's account: " + user.CaixaAccount);
                System.Diagnostics.Debug.Print("Password: " + user.Password);
                System.Diagnostics.Debug.Print("Name: " + user.Name);
                System.Diagnostics.Debug.Print("RG: " + user.Rg);
                System.Diagnostics.Debug.Print("CPF: " + user.Cpf);
                System.Diagnostics.Debug.Print("Adding user...");
                TempData["message"] = "User has been successfully registered.";
                return RedirectToAction("Index", "User");
            } else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Update(int CaixaAccount)
        {
            System.Diagnostics.Debug.Print("Checking data about the Caixa's Account " + CaixaAccount);
            User user = new User()
            {
                CaixaAccount = 123456789,
                Password = 123456,
                Name = "Robert Watson",
                Rg = 123456789,
                Cpf = 12312312312
            };
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(Models.User user)
        {
            System.Diagnostics.Debug.Print("Caixa's Account: " + user.CaixaAccount);
            System.Diagnostics.Debug.Print("Password: " + user.Password);
            System.Diagnostics.Debug.Print("Name: " + user.Name);
            System.Diagnostics.Debug.Print("RG: " + user.Rg);
            System.Diagnostics.Debug.Print("CPF: " + user.Cpf);
            System.Diagnostics.Debug.Print("Saving changes");
            return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public IActionResult Find(int Id)
        {
            System.Diagnostics.Debug.Print("Listing data for Caixa's Account " + Id);
            User user = new User()
            {
                CaixaAccount = Id,
                Password = 123456,
                Name = "Robert Watson",
                Rg = 123456789,
                Cpf = 12312312312
            };
            return View(user);
        }

        [HttpGet]
        public IActionResult Delete(int CaixaAccount)
        {
            System.Diagnostics.Debug.Print("Deleting Caixa's Account " + CaixaAccount);
            return RedirectToAction("Index", "User");
        }
    }
}