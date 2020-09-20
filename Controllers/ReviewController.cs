using System.Collections.Generic;
using System.Linq;
using eurasia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurasia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private readonly ApplicationContext _applicationContext;
        
        public ReviewController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return _applicationContext.Reviews.Include(review => review).ToList();
        }
    }
}