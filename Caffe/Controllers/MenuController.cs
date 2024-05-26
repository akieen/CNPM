using Caffe.Data;
using Caffe.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Web;
using Caffe.Models.DTO;

namespace Caffe.Controllers
{
    public class MenuController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AppDbContext _context;
        public MenuController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }

        public IActionResult Index()
        {
            return View();
        }
      
    }

}
