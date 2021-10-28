using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string  Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string Welcome2(string name, int numTimes= 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public string Welcome3(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello: {name}, Id: {id}");
        }
    }
}
