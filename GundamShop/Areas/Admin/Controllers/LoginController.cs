using GundamShop.Areas.Admin.Models;
using Models.Framework;
using System.Web;
using System.Web.Mvc;


namespace GundamShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.Password);
            if (result && ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Không Đúng.");
            }
            return View(model);

        }

        
        
    }
}