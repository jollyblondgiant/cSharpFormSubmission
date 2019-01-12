using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("")]
        public IActionResult Index(RegViewForm newForm)
        {
            RegViewForm NewForm = newForm;
            if(ModelState.IsValid){
                return RedirectToAction("Success", newForm);
            }
            else{
                return View();
            }
            
        }
        [HttpGet("result")]
        public IActionResult Success(RegViewForm newForm)
        {
            return View("Success", newForm);
        }
       
    }
}
