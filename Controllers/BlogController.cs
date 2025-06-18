using Microsoft.AspNetCore.Mvc;
using simple_blog_api_with_C_.Models;
using simple_blog_api_with_C_.Repository;

namespace simple_blog_api_with_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IGenericRepository<Blog> _context;
        public BlogController(IGenericRepository<Blog> context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {
            var blogs = await _context.GetAllAsync();
            return Ok(blogs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var blog = await _context.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

    }

}
