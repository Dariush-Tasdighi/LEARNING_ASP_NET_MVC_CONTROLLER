using System.Linq;
//using System.Data.Entity;

namespace LEARNING_MVC.Controllers
{
	//[System.Web.Mvc.Authorize]
	//[System.Web.Mvc.Authorize(Roles = "Supervisor,Manager")]
	public class HomeController : System.Web.Mvc.Controller
	{
		public HomeController()
			: base()
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
		/// http://localhost:30847/HOME/LEARN1020?NUMBER=15 -> Note: Url and the parameter names are not Case Sensitive!
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
			return ("Hello, World!");
		}

		/// <summary>
		/// اين گزينه توصيه می شود
		/// </summary>
		public System.Web.Mvc.ContentResult Learn1120()
		{
			return (Content("Hello, World!"));
		}

		public System.Web.Mvc.ActionResult Learn1130()
		{
			return (Content("Hello, World!"));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.ContentResult Learn1140()
		{
			return (Content("<b>Hello, World!</b>"));
		}

		public System.Web.Mvc.ContentResult Learn1150()
		{
			// می‌خواهيم اثر تگ را کاملا خنثی کنيم
			string strContent =
				Server.HtmlEncode("<b>Hello, World!</b>");

			return (Content(strContent));
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
					//return (null);
					// /Old Solution

					// New Solution (1)
					//return (RedirectToAction("Action1"));
					// /New Solution (1)

					// New Solution (2)
					return (RedirectToAction(actionName: "Action1"));
					// /New Solution (2)
				}

				case 2:
				{
					// ی در همين کنترلر برويم Action اگر بخواهيم به
					//return (RedirectToAction(actionName: "Action2"));

					// Solution (1)
					// ی در کنترلر ديگری برويم Action اگر بخواهيم به
					//return (RedirectToAction(actionName: "Action2", controllerName: "Home"));
					// /Solution (1)

					// Solution (2)
					return (RedirectToAction(controllerName: "Home", actionName: "Action2"));
					// /Solution (2)
				}

				default:
				{
					string strContent = "Id value is not valid!";

					return (Content(strContent));
				}
			}
		}

		public System.Web.Mvc.ContentResult Action1()
		{
			string strContent = "Action (1)";

			return (Content(strContent));
		}

		public System.Web.Mvc.ContentResult Action2()
		{
			string strContent = "Action (2)";

			return (Content(strContent));
		}

		public System.Web.Mvc.ActionResult Learn1165(int? id)
		{
			if (id.HasValue == false)
			{
				return (Content("You should specify id value!"));
			}

			switch (id.Value)
			{
				case 1:
				{
					return (RedirectToAction(actionName: "Action1"));
				}

				case 2:
				{
					return (RedirectToAction(actionName: "Action2"));
				}

				default:
				{
					string strContent = "Id value is not valid!";

					return (Content(strContent));
				}
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		public System.Web.Mvc.ContentResult Action3(int firstNumber, int secondNumber)
		{
			string strResult =
				string.Format("Frist Number: {0}, Second Number: {1}",
				firstNumber, secondNumber);

			return (Content(strResult));
		}

		public System.Web.Mvc.RedirectToRouteResult Learn1170()
		{
			// Solution (1)
			//Models.SomeClass oSomeClass = new Models.SomeClass();

			//oSomeClass.FirstNumber = 10;
			//oSomeClass.SecondNumber = 20;

			//return (RedirectToAction(actionName: "Action3", routeValues: oSomeClass));
			// /Solution (1)

			// Solution (2)
			return (RedirectToAction(actionName: "Action3",
				routeValues: new { FirstNumber = 10, SecondNumber = 20 }));
			// /Solution (2)
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

			return (RedirectToAction(actionName: "Action4"));
		}

		public System.Web.Mvc.ContentResult Action4()
		{
			string strResult = string.Empty;

			if (TempData["MyNumber"] != null)
			{
				int intMyNumber =
					System.Convert.ToInt32(TempData["MyNumber"]);

				strResult =
					string.Format("My Number is {0}", intMyNumber);
			}

			if (TempData["MyName"] != null)
			{
				string strMyName =
					TempData["MyName"].ToString();

				strResult =
					string.Format("My Name is {0}", strMyName);
			}

			return (Content(strResult));
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

			return (Content(TempData["MyNumber"].ToString()));
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

			return (Content(TempData["MyNumber"].ToString()));
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

			return (Content(TempData["MyNumber"].ToString()));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1220()
		{
			return (Content("Hello, World!"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ContentResult Learn1230()
		{
			return (Content("Hello, World!"));
		}

		// نوشتن هر دو بی معنی است
		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ContentResult Learn1240()
		{
			return (Content("Hello, World!"));
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
		//public System.Web.Mvc.ActionResult Learn1250()
		//{
		//	return (Content("Hello, World!"));
		//}

		/// <summary>
		/// Compile Error!
		/// </summary>
		//[System.Web.Mvc.HttpGet]
		//public System.Web.Mvc.ActionResult Learn1250()
		//{
		//	return (Content("Hello, World!"));
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
		public System.Web.Mvc.ActionResult Learn1260()
		{
			return (Content("Hello, World!"));
		}

		/// <summary>
		/// MVC Error!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Learn1260(string name)
		{
			return (Content("Hello, World!"));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Learn1270()
		{
			return (Content("[GET] Hello, World!"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.ActionResult Learn1270(string name)
		{
			return (Content("[POST] Hello, World!"));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Learn1280()
		{
			return (Content("[GET] Hello, World!"));
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.ActionName(name: "Learn1280_AliasName")]
		public System.Web.Mvc.ActionResult Learn1280(string name)
		{
			return (Content("[GET] Hello, World!"));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.RedirectToRouteResult Learn1290()
		{
			return (RedirectToAction(actionName: "Action1"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.RedirectResult Learn1300()
		{
			return (RedirectPermanent(url: "Action1"));
			//return (RedirectPermanent(url: "Home/Action1"));
			//return (RedirectPermanent(url: "~/Home/Action1"));
			//return (RedirectPermanent(url: "http://www.CNN.com"));
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
			string strContent =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return (Content(strContent));
		}

		/// <remarks>
		/// Note: Duration in Second(s)
		/// </remarks>
		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 10)]
		public System.Web.Mvc.ContentResult Learn1320()
		{
			string strContent =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return (Content(strContent));
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 120)]
		public System.Web.Mvc.ContentResult Learn1330(int id)
		{
			switch (id)
			{
				case 1:
				{
					return (Content("Hello World (1)!"));
				}

				case 2:
				{
					return (Content("Hello World (2)!"));
				}

				default:
				{
					return (Content("Hello, World!"));
				}
			}
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.OutputCache(Duration = 120)]
		public System.Web.Mvc.ContentResult Learn1340()
		{
			string strContent =
				System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");

			return (Content(strContent));
		}

		/// <summary>
		/// Tanx To Mr. Hossein Shojaee
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public void Learn1350()
		{
			string strUrl =
				Url.Action(actionName: "Learn1340");

			Response.RemoveOutputCacheItem(strUrl);
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ContentResult Learn1360()
		{
			return (Content("Hello, World!"));
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize]
		public System.Web.Mvc.ContentResult Learn1370()
		{
			return (Content("Hello, World!"));
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize(Roles = "Supervisor,Manager")]
		public System.Web.Mvc.ContentResult Learn1380()
		{
			return (Content("Hello, World!"));
		}

		[System.Web.Mvc.AllowAnonymous]
		public System.Web.Mvc.ContentResult Learn1390()
		{
			return (Content("Hello, World!"));
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
			string strResult =
				"{\"FullName\":\"Dariush Tasdighi\",\"Age\":40}";

			// Wrong Usage!
			//string strResult =
			//	"{'FullName':'Dariush Tasdighi','Age':40}";

			return (strResult);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult Learn1410()
		{
			Models.Person oPerson = new Models.Person();

			oPerson.Age = 40;
			oPerson.FullName = "Dariush Tasdighi";

			return (Json(data: oPerson,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult Learn1420()
		{
			return (Json(data: new { FullName = "Dariush Tasdighi", Age = 40 },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1430()
		{
			// شرايط دريافت فايل

			string strRootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string strPathName =
				Server.MapPath(strRootRelativePathName);

			return (File(fileName: strPathName, contentType: "text/html"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1440()
		{
			// شرايط دريافت فايل

			string strRootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string strPathName =
				Server.MapPath(strRootRelativePathName);

			return (File(fileName: strPathName, contentType: "image/jpeg"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1450()
		{
			// شرايط دريافت فايل

			string strRootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string strPathName =
				Server.MapPath(strRootRelativePathName);

			return (File(fileName: strPathName, contentType: "googooli/magooli"));
			//return (File(fileName: strPathName, contentType: "application/octet-stream"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.FileResult Learn1460()
		{
			// شرايط دريافت فايل

			string strRootRelativePathName =
				"~/App_Data/Images/Dariush.jpg";

			string strPathName =
				Server.MapPath(strRootRelativePathName);

			return (File(fileName: strPathName, contentType: "googooli/magooli", fileDownloadName: "Dariush.jpg"));
		}

		/// <summary>
		/// Download Large Files! For example more than 100MB!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public void Download(int id)
		{
			// **************************************************
			string strFileName =
				string.Format("{0}.zip", id);

			string strRootRelativePathName =
				string.Format("~/App_Data/Files/{0}", strFileName);

			string strPathName =
				Server.MapPath(strRootRelativePathName);

			if (System.IO.File.Exists(strPathName) == false)
			{
				return;
			}
			// **************************************************

			System.IO.Stream oStream = null;

			try
			{
				// Open the file
				oStream =
					new System.IO.FileStream
						(path: strPathName,
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
				// the [strFileName] name instead of [download]!
				Response.AddHeader("Content-Disposition", "attachment; filename=" + strFileName);

				long lngFileLength = oStream.Length;

				// Notify user (client) the total file length
				Response.AddHeader("Content-Length", lngFileLength.ToString());
				// **************************************************

				// Total bytes that should be read
				long lngDataToRead = lngFileLength;

				// Read the bytes of file
				while (lngDataToRead > 0)
				{
					// The below code is just for testing! So we commented it!
					//System.Threading.Thread.Sleep(1000);

					// Verify that the client is connected or not?
					if (Response.IsClientConnected)
					{
						// 8KB
						int intBufferSize = 8 * 1024;

						// Create buffer for reading [intBufferSize] bytes from file
						byte[] bytBuffers =
							new System.Byte[intBufferSize];

						// Read the data and put it in the buffer.
						int intTheBytesThatReallyHasBeenReadFromTheStream =
							oStream.Read(buffer: bytBuffers, offset: 0, count: intBufferSize);

						// Write the data from buffer to the current output stream.
						Response.OutputStream.Write
							(buffer: bytBuffers, offset: 0,
							count: intTheBytesThatReallyHasBeenReadFromTheStream);

						// Flush (Send) the data to output
						// (Don't buffer in server's RAM!)
						Response.Flush();

						lngDataToRead =
							lngDataToRead - intTheBytesThatReallyHasBeenReadFromTheStream;
					}
					else
					{
						// Prevent infinite loop if user disconnected!
						lngDataToRead = -1;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (oStream != null)
				{
					//oStream.Close();
					oStream.Dispose();
					oStream = null;
				}

				Response.Close();
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
