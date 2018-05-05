using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SimpleBugTracker.Models;

namespace SimpleBugTracker.Controllers
{
    public class MainController
    {
        [Route("api/[controller]")]
        public class ValuesController : Controller
        {
            static readonly List<User> _users;
            static ValuesController()
            {
                _users = new List<User>
            {
                new User { FirstName="S", SecondName="S", Login = "Krolik", Password="krolik"},
                new User {  FirstName="S", SecondName="S", Login = "Krolik1", Password="krolik" },
            };
            }
            [HttpGet]
            public IEnumerable<User> Get()
            {
                return _users;
            }

            [HttpPost]
            public IActionResult LogIn([FromBody]User phone)
            {
                return Ok(phone);
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(string id)
            {
                return Ok(id);
            }
        }
    }
}
