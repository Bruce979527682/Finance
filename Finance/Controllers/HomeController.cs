using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Finance.Models;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace Finance.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinanceContext _context;

        public HomeController(FinanceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public string getmsg(string id,string name)
        {
            //使用 HtmlEncoder.Default.Encode 防止恶意输入（即 JavaScript）损害应用。
            return HtmlEncoder.Default.Encode($"Id is {id}, Name is: {name}");
        }

        /// <summary>
        /// 查询单条数据返回视图
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> GetSingle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var learn = await _context.LearnClass.FindAsync(id);//异步
            var learn = await _context.LearnClass.FirstOrDefaultAsync(m => m.Id == id);            
            if (learn == null)
            {
                return NotFound();
            }

            return View(learn);
        }

        /// <summary>
        /// 查询多条数据返回视图
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> GetList()
        {
            return View(await _context.LearnClass.ToListAsync());
        }

        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]//验证表单标记帮助程序中的防伪标记生成器生成的隐藏的 XSRF 标记
        public async Task<IActionResult> SearchData(string searchString)
        {
            var learns = from m in _context.LearnClass
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                learns = learns.Where(s => s.Name.Contains(searchString));
            }

            return View(await learns.ToListAsync());
        }

        // POST: Movies/Delete/5 删除数据的 [HttpPost] 方法命名为 DeleteConfirmed，以便为 HTTP POST 方法提供一个唯一的签名或名称。
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var learn = await _context.LearnClass.FindAsync(id);
            _context.LearnClass.Remove(learn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
