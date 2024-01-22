using BaseCrud.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseCrud.Controllers
{
    public class CmsController(CmsContext context) : Controller
    {
        private readonly CmsContext _context = context;

        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var employee = await _context.Employee.ToListAsync();
            return View(employee);
        }

        /// <summary>
        /// 單一員工明細頁
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null) return NotFound();
            return View(employee);
        }
    }
}
