namespace LEARNING_MVC.Controllers
{
	//[System.Web.Mvc.Authorize]
	//[System.Web.Mvc.Authorize(Roles = "Supervisor,Manager")]
	public class HomeController : System.Web.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		public void Index()
		{
		}

		public void Learn1000()
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1010 -> Error!
		/// http://localhost:30847/Home/Learn1010?id=15
		/// http://localhost:30847/Home/Learn1010/15 // شیک تر است
		/// http://localhost:30847/Home/Learn1010/Something -> Error!
		/// </summary>
		public void Learn1010(int id)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1020 -> Error!
		/// http://localhost:30847/Home/Learn1020/15 -> Error!
		/// http://localhost:30847/Home/Learn1020?number=15
		/// http://localhost:30847/HOME/LEARN1020?NUMBER=15 -> Note: Url (Controller and Action name) and the input parameter name(s) are not Case Sensitive!
		/// </summary>
		public void Learn1020(int number)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1030 -> Error!
		/// http://localhost:30847/Home/Learn1030/15 -> Error!
		/// http://localhost:30847/Home/Learn1030?firstNumber=15 -> Error!
		/// http://localhost:30847/Home/Learn1030?firstNumber=15&secondNumber=20
		/// http://localhost:30847/Home/Learn1030?secondNumber=20&firstNumber=15 -> Note: The parameters ordering is not important!
		/// </summary>
		public void Learn1030(int firstNumber, int secondNumber)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1040 -> Error!
		/// http://localhost:30847/Home/Learn1040/15 -> Error!
		/// http://localhost:30847/Home/Learn1040?id=15&number=20
		/// http://localhost:30847/Home/Learn1040?number=20&id=15
		/// http://localhost:30847/Home/Learn1040/15?number=20 // شیک تر است
		/// </summary>
		public void Learn1040(int id, int number)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1050 -> Error!
		/// http://localhost:30847/Home/Learn1050/15 -> Error!
		/// http://localhost:30847/Home/Learn1050?id=15&number=20
		/// http://localhost:30847/Home/Learn1050?number=20&id=15
		/// http://localhost:30847/Home/Learn1050/15?number=20 // شیک تر است
		/// </summary>
		public void Learn1050(int number, int id)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1060 -> number = null
		/// http://localhost:30847/Home/Learn1060/15 -> number = null
		/// http://localhost:30847/Home/Learn1060?number=15 -> number = 15
		/// </summary>
		public void Learn1060(int? number)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1070 -> name = null
		/// http://localhost:30847/Home/Learn1070/Something -> name = null
		/// http://localhost:30847/Home/Learn1070?name=Something -> name = "Something"
		/// </summary>
		public void Learn1070(string name)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1080 -> id = null
		/// http://localhost:30847/Home/Learn1080?id=Something -> id = "Something"
		/// http://localhost:30847/Home/Learn1080/Something -> id = "Something" شيک تر است
		/// </summary>
		public void Learn1080(string id)
		{
			// Do Something...
		}

		/// <summary>
		/// http://localhost:30847/Home/Learn1090 -> number = 110
		/// http://localhost:30847/Home/Learn1090/200 -> number = 110
		/// http://localhost:30847/Home/Learn1090?number=200 -> number = 200
		/// http://localhost:30847/Home/Learn1090?number=Something -> number = 110
		/// </summary>
		public void Learn1090(int number = 110)
		{
			// Do Something...
		}

		private void NonAction1()
		{
			// Do Something...
		}

		protected void NonAction2()
		{
			// Do Something...
		}

		internal void NonAction3()
		{
			// Do Something...
		}

		protected internal void NonAction4()
		{
			// Do Something...
		}

		[System.Web.Mvc.NonAction]
		public void NonAction5()
		{
			// Do Something...
		}

		[System.Web.Mvc.ActionName("MyActionName")]
		public void Learn1100()
		{
			// Do Something...
		}

		// **************************************************
		// **************************************************
		// **************************************************
		public string Learn1110()
		{
			return "Hello, World!";
		}

		/// <summary>
		/// اين گزينه توصيه می شود
		/// </summary>
		public System.Web.Mvc.ContentResult Learn1120()
		{
			return Content("Hello, World!");
		}

		public System.Web.Mvc.ActionResult Learn1130()
		{
			return Content("Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.ContentResult Learn1140()
		{
			return Content("<b>Hello, World!</b>");
		}

		public System.Web.Mvc.ContentResult Learn1150()
		{
			// می‌خواهيم اثر تگها را کاملا خنثی نماییم
			string content =
				Server.HtmlEncode("<b>Hello, World!</b>");

			return Content(content);
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.ActionResult Learn1160(int id)
		{
			switch (id)
			{
				case 1:
				{
					// Old Solution
					//Response.Redirect("~/Home/Action1", endResponse: false);
					//return null;
					// /Old Solution

					// New Solution (1)
					//return Redirect(url: "~/Home/Action1");
					// /New Solution (1)

					// New Solution (2)
					return RedirectToAction(actionName: "Action1");
					// /New Solution (2)
				}

				case 2:
				{
					// ی در همين کنترلر برويم Action اگر بخواهيم به
					//return RedirectToAction(actionName: "Action2");

					// Solution (1)
					// ی در کنترلر ديگری برويم Action اگر بخواهيم به
					//return RedirectToAction(actionName: "Action2", controllerName: "Home");
					// /Solution (1)

					// Solution (2)
					return RedirectToAction(controllerName: "Home", actionName: "Action2");
					// /Solution (2)
				}

				default:
				{
					string content = "Id value is not valid!";

					return Content(content);
				}
			}
		}

		public System.Web.Mvc.ContentResult Action1()
		{
			string content = "Action (1)";

			return Content(content);
		}

		public System.Web.Mvc.ContentResult Action2()
		{
			string content = "Action (2)";

			return Content(content);
		}

		/// <summary>
		/// یک موضوع فلسفی در تفکر جدید مایکروسافت
		/// </summary>
		//public System.Web.Mvc.ActionResult Edit(int id)
		//{
		//	return Content("We display the edit page!");
		//}

		public System.Web.Mvc.ActionResult Edit(int? id)
		{
			//if (id == null)
			//if (!id.HasValue)
			if (id.HasValue == false)
			{
				return Content("You should specify id value!");
			}

			return Content("We display the edit page!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.ContentResult Action3(int firstNumber, int secondNumber)
		{
			// Solution (1)
			//string result =
			//	"First Number: " + firstNumber + ", Second Number: " + secondNumber;
			// /Solution (1)

			// Solution (2)
			//string result =
			//	string.Format("Frist Number: {0}, Second Number: {1}",
			//	firstNumber, secondNumber);
			// /Solution (2)

			// Solution (3)
			//string result =
			//	$"Frist Number: {firstNumber}, Second Number: {secondNumber}";
			// /Solution (3)

			// Solution (4)
			string result =
				$"Frist Number: { firstNumber }, Second Number: { secondNumber }";
			// /Solution (4)

			return Content(result);
		}

		public System.Web.Mvc.RedirectToRouteResult Learn1170()
		{
			// Solution (1)
			//Models.SomeClass someClass = new Models.SomeClass();

			//someClass.FirstNumber = 10;
			//someClass.SecondNumber = 20;

			//return RedirectToAction(actionName: "Action3", routeValues: someClass);
			// /Solution (1)

			// Solution (2)
			//Models.SomeClass someClass = new Models.SomeClass
			//{
			//	FirstNumber = 10,
			//	SecondNumber = 20,
			//};

			//return RedirectToAction(actionName: "Action3", routeValues: someClass);
			// /Solution (2)

			// Solution (3)
			//return RedirectToAction(actionName: "Action3",
			//	routeValues: new { FirstNumber = 10, SecondNumber = 20 });
			// /Solution (3)

			// Solution (4)
			return RedirectToAction(actionName: "Action3",
				routeValues: new { SecondNumber = 20, FirstNumber = 10 });
			// /Solution (4)
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.RedirectToRouteResult Learn1180()
		{
			TempData["MyNumber"] = 10;

			return RedirectToAction(actionName: "Action4");
		}

		public System.Web.Mvc.ContentResult Action4()
		{
			string result = string.Empty;

			if (TempData["MyNumber"] != null)
			{
				int myNumber =
					System.Convert.ToInt32(TempData["MyNumber"]);

				result =
					$"My Number is { myNumber }";

				return Content(result);
			}

			if (TempData["MyName"] != null)
			{
				string myName =
					TempData["MyName"].ToString();

				result =
					$"My Name is { myName }";

				return Content(result);
			}

			result = "I do not have any passed parameter!";

			return Content(result);
		}

		public System.Web.Mvc.ContentResult Learn1190()
		{
			if (TempData["MyNumber"] == null)
			{
				TempData["MyNumber"] = 10;
			}
			else
			{
				TempData["MyNumber"] =
					(int)TempData["MyNumber"] + 1;
			}

			return Content(TempData["MyNumber"].ToString());
		}

		public System.Web.Mvc.ContentResult Learn1200()
		{
			if (TempData["MyNumber"] == null)
			{
				TempData["MyNumber"] = 10;

				//TempData.Keep();
				TempData.Keep("MyNumber");
			}
			else
			{
				TempData["MyNumber"] =
					(int)TempData["MyNumber"] + 1;
			}

			return Content(TempData["MyNumber"].ToString());
		}

		public System.Web.Mvc.ContentResult Learn1210()
		{
			if (TempData["MyNumber"] == null)
			{
				TempData["MyNumber"] = 10;
			}
			else
			{
				TempData["MyNumber"] =
					(int)TempData["MyNumber"] + 1;
			}

			//TempData.Keep();
			TempData.Keep("MyNumber");

			return Content(TempData["MyNumber"].ToString());
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// Check POST Actions by PostMan Application!

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1220()
		{
			return Content("Hello, World!");
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ContentResult Learn1230()
		{
			return Content("Hello, World!");
		}

		// نوشتن هر دو بی معنی است
		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ContentResult Learn1240()
		{
			return Content("Hello, World!");
		}

		/// <summary>
		/// Without Attribute, this action will response with two action methods!
		/// GET, POST
		/// </summary>
		/// <returns></returns>
		public System.Web.Mvc.ContentResult Learn1245()
		{
			return Content("Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		/// <summary>
		/// Compile Error!
		/// </summary>
		//[System.Web.Mvc.HttpGet]
		//public System.Web.Mvc.ContentResult Learn1250()
		//{
		//	return Content("Hello, World!");
		//}

		/// <summary>
		/// Compile Error!
		/// </summary>
		//[System.Web.Mvc.HttpGet]
		//public System.Web.Mvc.ContentResult Learn1250()
		//{
		//	return Content("Hello, World!");
		//}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		/// <summary>
		/// MVC Error!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1260()
		{
			return Content("Hello, World!");
		}

		/// <summary>
		/// MVC Error!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1260(string name)
		{
			return Content("Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1270()
		{
			return Content("[GET] Hello, World!");
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ContentResult Learn1270(string name)
		{
			return Content("[POST] Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1280()
		{
			return Content("[GET] Hello, World!");
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.ActionName(name: "Learn1280_AliasName")]
		public System.Web.Mvc.ContentResult Learn1280(string name)
		{
			return Content("[GET] Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// Note: باشد GET نمود که پذیرای Redirect ی Action در صورتی می‌توان به
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.RedirectToRouteResult Learn1290()
		{
			return RedirectToAction(actionName: "Action1");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.RedirectResult Learn1300()
		{
			return RedirectPermanent(url: "Action1");
			//return RedirectPermanent(url: "Home/Action1");
			//return RedirectPermanent(url: "~/Home/Action1");
			//return RedirectPermanent(url: "https://www.CNN.com");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.RedirectResult AboutUs()
		{
			return RedirectPermanent(url: "About");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult About()
		{
			return Content("Hi! I'm Dariush Tasdighi!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1310()
		{
			string content =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return Content(content);
		}

		/// <remarks>
		/// Note: Duration in Second(s)
		/// </remarks>
		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 10)]
		public System.Web.Mvc.ContentResult Learn1320()
		{
			string content =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return Content(content);
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 600)]
		public System.Web.Mvc.ContentResult Learn1330(int id)
		{
			switch (id)
			{
				case 1:
				{
					return Content("Hello World (1)!");
				}

				case 2:
				{
					return Content("Hello World (2)!");
				}

				default:
				{
					return Content("Hello, World!");
				}
			}
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 600)]
		public System.Web.Mvc.ContentResult Learn1340()
		{
			string content =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return Content(content);
		}

		/// <summary>
		/// Tanx To Mr. Hossein Shojaee
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public void Learn1350()
		{
			string url =
				Url.Action(actionName: "Learn1340");

			Response.RemoveOutputCacheItem(url);
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		// AZMan
		// Identity
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1360()
		{
			return Content("Hello, World!");
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize]
		public System.Web.Mvc.ContentResult Learn1370()
		{
			return Content("Hello, World!");
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize(Roles = "Supervisor,Manager")]
		public System.Web.Mvc.ContentResult Learn1380()
		{
			return Content("Hello, World!");
		}

		[System.Web.Mvc.AllowAnonymous]
		public System.Web.Mvc.ContentResult Learn1390()
		{
			return Content("Hello, World!");
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public string Learn1400()
		{
			string result =
				"{\"FullName\":\"Dariush Tasdighi\",\"Age\":47}";

			// Wrong Usage!
			//string result =
			//	"{'FullName':'Dariush Tasdighi','Age':47}";

			return result;
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1405()
		{
			string result =
				"{\"FullName\":\"Dariush Tasdighi\",\"Age\":47}";

			return Content(result);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult Learn1410()
		{
			Models.Person person = new Models.Person
			{
				Age = 47,
				FullName = "Dariush Tasdighi",
			};

			return Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult Learn1420()
		{
			var result =
				new { FullName = "Dariush Tasdighi", Age = 47 };

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult Learn1425()
		{
			var result =
				new System.Collections.ArrayList();

			for (int index = 1; index <= 5; index++)
			{
				var entity =
					new { FullName = $"Full Name {index}", Age = 40 + index };

				result.Add(entity);
			}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// در تمام پروژه‌هایی که می‌نویسید
		// خصوصا پروژه‌های وب، به هیچ عنوان
		// از آدرس فیزیکی نباید استفاده کنیم
		// C:\INETPUT\WWWROOT\...

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1430()
		{
			// شرايط دريافت فايل

			string rootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string pathName =
				Server.MapPath(rootRelativePathName);

			// Content Type == Mime Type
			return File(fileName: pathName, contentType: "text/html");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1440()
		{
			// شرايط دريافت فايل

			string rootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string pathName =
				Server.MapPath(rootRelativePathName);

			return File(fileName: pathName, contentType: "image/jpeg");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1450()
		{
			// شرايط دريافت فايل

			string rootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string strPathName =
				Server.MapPath(rootRelativePathName);

			return File(fileName: strPathName, contentType: "googooli/magooli");
			//return File(fileName: strPathName, contentType: "application/octet-stream");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1460()
		{
			// شرايط دريافت فايل

			string rootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string pathName =
				Server.MapPath(rootRelativePathName);

			return File(fileName: pathName, contentType: "googooli/magooli", fileDownloadName: "Dariush.jpg");
		}

		/// <summary>
		/// Download Large Files! For example more than 100MB!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public void Download(int id)
		{
			// **************************************************
			string fileName =
				string.Format("{0}.zip", id);

			string rootRelativePathName =
				string.Format("~/App_Data/Files/{0}", fileName);

			string pathName =
				Server.MapPath(path: rootRelativePathName);

			if (System.IO.File.Exists(pathName) == false)
			{
				return;
			}
			// **************************************************

			System.IO.Stream stream = null;

			try
			{
				// Open the file
				stream =
					new System.IO.FileStream
						(path: pathName,
						mode: System.IO.FileMode.Open,
						share: System.IO.FileShare.Read,
						access: System.IO.FileAccess.Read);

				// **************************************************
				Response.Buffer = false;

				// Setting the unknown [ContentType]
				// will display the saving dialog for the user
				Response.ContentType = "application/octet-stream";

				// With setting the file name,
				// in the saving dialog, user will see
				// the [fileName] name instead of [download]!
				Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);

				long fileLength = stream.Length;

				// Notify user (client) the total file length
				Response.AddHeader("Content-Length", fileLength.ToString());
				// **************************************************

				// Total bytes that should be read
				long dataToRead = fileLength;

				// Read the bytes of file
				while (dataToRead > 0)
				{
					// The below code is just for testing! So we commented it!
					//System.Threading.Thread.Sleep(1000);

					// Verify that the client is connected or not?
					if (Response.IsClientConnected)
					{
						// 8KB
						int bufferSize = 8 * 1024;

						// Create buffer for reading [intBufferSize] bytes from file
						byte[] buffers =
							new System.Byte[bufferSize];

						// Read the data and put it in the buffer.
						int theBytesThatReallyHasBeenReadFromTheStream =
							stream.Read(buffer: buffers, offset: 0, count: bufferSize);

						// Write the data from buffer to the current output stream.
						Response.OutputStream.Write
							(buffer: buffers, offset: 0,
							count: theBytesThatReallyHasBeenReadFromTheStream);

						// Flush (Send) the data to output
						// (Don't buffer in server's RAM!)
						Response.Flush();

						dataToRead =
							dataToRead - theBytesThatReallyHasBeenReadFromTheStream;
					}
					else
					{
						// Prevent infinite loop if user disconnected!
						dataToRead = -1;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (stream != null)
				{
					//oStream.Close();
					stream.Dispose();
					stream = null;
				}

				Response.Close();
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
