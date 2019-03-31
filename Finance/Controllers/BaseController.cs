using Finance.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Finance.Controllers
{
    public class BaseController : Controller
    {        
        public string GetRequestString(string key, string defaultStr)
        {
            try
            {
                var value = Request.Form[key].ToString().Trim();
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
                return defaultStr;
            }
            catch (Exception)
            {
                return defaultStr;
            }            
        }

        public int GetRequestInt(string key, int defaultValue)
        {
            try
            {
                var value = Request.Form[key].ToString().Trim();
                int num;
                if (int.TryParse(value, out num))
                {
                    return num;
                }
                return defaultValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }            
        }

        public decimal GetRequestDecimal(string key, decimal defaultValue)
        {
            try
            {
                var value = Request.Form[key].ToString().Trim();
                decimal num;
                if (decimal.TryParse(value, out num))
                {
                    return num;
                }
                return defaultValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }           
        }

        public DateTime GetRequestDateTime(string key, DateTime defaultValue)
        {
            try
            {
                var value = Request.Form[key].ToString().Trim();
                DateTime time;
                if (DateTime.TryParse(value, out time))
                {
                    return time;
                }
                return defaultValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }            
        }

        protected void SetSessiong(string key,object value)
        {
            HttpContext.Session.SetString(key, JsonConvert.SerializeObject(value));
        }

        protected string GetSessiongString(string key)
        {
            return HttpContext.Session.GetString(key);
        }

        protected T GetSessiongString<T>(string key)
        {
            var value = HttpContext.Session.GetString(key);
            return JsonConvert.DeserializeObject<T>(value);
        }

        protected void SetUserInfoSession(User user)
        {
            HttpContext.Session.SetString("FinanceUserInfo", JsonConvert.SerializeObject(user));
        }

        protected bool IsLogined()
        {
            var value = HttpContext.Session.GetString("FinanceUserInfo");
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return true;
        }

        protected User GetUserInfoSession()
        {
            var value = HttpContext.Session.GetString("FinanceUserInfo");
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<User>(value);
            }
            return null;
        }
    }
}