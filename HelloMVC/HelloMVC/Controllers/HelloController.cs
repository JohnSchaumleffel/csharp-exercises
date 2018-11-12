using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult LangPage()
        {
            return Content(htmlString, "text/html");
        }

        [HttpPost]
        public IActionResult LangPage(string firstname, string languageSelect)
        {
            //if languageSelect == '';
                return Content("{languageSelect} {firstname}");
        }

        string htmlString = @"<body>
                                    <form action='/hello/hellopage' method='post'>
                                    <input type='text' name='firstname'/>
                                    <select id='languageSelect'>
                                        <option value=''>English</option>
                                        <option value='french'>French</option>
                                        <option value='spanish'>Spanish</option>
                                        <option value='german'>German</option>
                                        <option value='italian'>Italian</option>
                                    </select>
                                    <button type='submit'/>
                              </body>";
    }
}
