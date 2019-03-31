using System;
using System.Linq;
using Finance.Entity;
using Finance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finance.Controllers
{
    public class AccountController : BaseController
    {
        public FinanceContext _context;
        public AccountController(FinanceContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login()
        {
            var username = GetRequestString("username","");
            var password = GetRequestString("password", "");
            if (!string.IsNullOrEmpty(username))
            {
                var user = _context.Users.SingleOrDefault(x=>x.UserName == username);
                if(user != null)
                {
                    if(user.Password == password)
                    {
                        user.LoginTime = DateTime.Now;
                        _context.SaveChanges();
                        SetUserInfoSession(user);
                        return Json(new { code = 1, src = "/home/index" });
                    }
                }                
            }            
            return Json(new { code = 0, msg = "账号或密码错误" });
        }

        [HttpPost]
        public JsonResult AddAccount()
        {
            var username = GetRequestString("username","");
            var password = GetRequestString("password", "");
            if (!string.IsNullOrEmpty(username))
            {
                var user = _context.Users.SingleOrDefault(x => x.UserName == username);
                if (user == null)
                {
                    user = new User {
                        LoginError = 0,
                        LoginTime = DateTime.Now,
                        Password = password,
                        UserName = username                        
                    };
                     _context.Users.Add(user);
                    var result = _context.SaveChanges();
                    if(result > 0)
                    {
                        return Json(new { code = 1, src = "/account/index" });
                    }                    
                }
                else
                {
                    return Json(new { code = 0, msg = "该用户名已被使用" });
                }
            }
            return Json(new { code = 0, msg = "账号或密码错误" });
        }
    }
}