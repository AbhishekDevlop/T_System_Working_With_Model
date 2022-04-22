using Microsoft.AspNetCore.Mvc;
using System.Linq;
using T_System_Working_With_Model.Data;

namespace T_System_Working_With_Model.Controllers
{
    public class ProductController : Controller
    {
        public readonly ApplicationDbContext DbContext;

        public ProductController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public IActionResult Index()
        {
            return View(DbContext.Product.ToList());
        }
    }
}
