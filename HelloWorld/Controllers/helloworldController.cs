using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class helloworldController : Controller
    {
        // GET: helloworld 
       public string getstring()
        {
            return "Hello World!!";
        }
    }
}