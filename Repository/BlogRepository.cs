using Microsoft.EntityFrameworkCore;
using simple_blog_api_with_C_.Data;
using simple_blog_api_with_C_.Models;

namespace simple_blog_api_with_C_.Repository
{
    public class BlogRepository : IGenericRepository<Blog>
    {
        private readonly DatabaseContext _context;

        public BlogRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            var data = await _context.Blogs
                .Include(b => b.Category) // Include the related Category entity
                .ToListAsync(); // Fetch all blogs with their categories
            return data;
        }

        public async Task<Blog?> GetByIdAsync(int id)
        {
            var data = await _context.Blogs
                .Include(b => b.Category) // Include the related Category entity
                .FirstOrDefaultAsync(b => b.Id == id); // Fetch the blog by ID with its category
            return data;
        }


        public async Task<Blog>? AddAsync(Blog entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Blog>? UpdateAsync(Blog entity)
        {
            throw new NotImplementedException();
        }



        public async Task<Blog>? DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }




    }
}
