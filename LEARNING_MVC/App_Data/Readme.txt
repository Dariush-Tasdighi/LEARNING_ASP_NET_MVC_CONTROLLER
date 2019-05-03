آدرس تلگرام
@IranianExperts

--------------------------------------------------

C#
OOP
LINQ TO ENTITY FRAMEWORK CODE FIRST (۴ فیلم)

	تاریخچه
	ADO.NET 1, 2, 3
HTML
CSS

	BOOTSTRAP

--------------------------------------------------

http://www.x.com/x.asp
http://www.x.com/x.php
http://www.x.com/x.cgi
http://www.x.com/x.jsp
http://www.x.com/x.aspx
...

http://www.x.com/Users/List
http://www.x.com/Users/Details/17

ASP.NET
	Web Form
	MVC
		Model	View	Controller	Action

		EF		html	class		Method (Function)

--------------------------------------------------

	Tech.  Patterns
	Design Patterns
	Arti.  Patterns

		n-layer
		n-tier
		MVP

		معماری‌های مدرن

		MVVM (WPF, Silverlight, JavaScript Lib. Fr.)
		MVC

--------------------------------------------------

		Controller		Class

		Home			HomeController


	http://.../HomeController/Index	-> Error!
	http://.../Home/Index			-> OK

--------------------------------------------------

http://localhost:53299/

64K = 65655 Port

--------------------------------------------------

طریقه پاس کردن پارامتر

https://x.com/m/n?a=1&b=2&c=3

--------------------------------------------------

تعریف پارامترهای ورودی اختیاری

void F(int x = 10)
{
}

obj.F();

--------------------------------------------------

	Home/Index

	Home -> Controller -> Map (Route) -> Class -> HomeControlller

	Index -> Action -> Map (Route) -> Funtion (Method) -> Index

	در نهایت در این دوره یاد خواهیم گرفت

	http://x.com/M/N -> PController, F

--------------------------------------------------

		object

		M

		N

		P

	P1	P2	P3

	P1 SomeFunction()
	{
	}

	P SomeFunction()
	{
	}

	SomeFunction(P1 p)
	{
	}

	SomeFunction(P p)
	{
	}

					ActionResult


ContentResult		JsonResult		FileResult		ViewResult		...

--------------------------------------------------

class Person
{
	public int Age { get; set; }
	public string FullName { get; set; }
}

Person p = new Person();

p.Age = 20;
p.FullName = "Ali Reza Alavi";

--------------------------------------------------

// Anonymous Object

var p = new { Age = 20, FullName = "Ali Reza Alavi" };

--------------------------------------------------

AAA = Triple A

Authentication	طریقه شناسایی کاربر
Authorization	اجازه دسترسی به کاربر
Auditing		اقدامات کاربر را لاگ کنیم

--------------------------------------------------

{ "Full Name" : "Ali Reza Alaiv" , "Age" : 20 , "Salary" : 12.34 , "Active" : true , "Job" : null }

Key(s) should be surrounded by ""

{ "FullName" : "Ali Reza Alaiv" , "FavoriteColors" : [ "Red", "Blue" ] }

{ "FullName" : "Ali Reza Alaiv" , "Father" : { "FirstName" : "Ahmad" , "LastName" : "Alavi" } }

[
	{ "FullName" : "Full Name 1" , "Age" : 21 , "Salary" : 11 },
	{ "FullName" : "Full Name 2" , "Age" : 22 , "Salary" : 12 },
	{ "FullName" : "Full Name 3" , "Age" : 23 , "Salary" : 13 },
]
--------------------------------------------------

Circle myCircle = new Circle();

myCircle.Draw(10, 20, 30, 5);

myCircle.Draw(x: 10, y: 20, radius: 30, width: 5);

myCircle.Draw(width: 5, y: 20, x: 10, radius: 30);

myCircle.Draw(10, 20, radius: 30, width: 5);

myCircle.Draw(10, 20, radius: 30, 5); // Compile Error!

myCircle.Draw(10, 20, width: 5, radius: 30);

--------------------------------------------------
