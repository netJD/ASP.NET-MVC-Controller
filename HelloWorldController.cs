using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HelloWorldController : Controller
    {
        // when you access your localhost https://localhost:1234/HelloWorld/
        
        // GET: /HelloWorld/ 
        
        // this will return : "This is my default action..."

        public string Index()
        {
            return "This is my default action...";
        }

        // when you access your localhost https://localhost:1234/HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        
        // this will return : "This is the Welcome action method..."


        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
