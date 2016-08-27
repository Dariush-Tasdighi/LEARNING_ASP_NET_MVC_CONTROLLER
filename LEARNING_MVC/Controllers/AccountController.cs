using System.Linq;
//using System.Data.Entity;

namespace LEARNING_MVC.Controllers
{
	public class AccountController : System.Web.Mvc.Controller
	{
		public AccountController()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Login()
		{
			return (Content("Login..."));
		}
	}
}
