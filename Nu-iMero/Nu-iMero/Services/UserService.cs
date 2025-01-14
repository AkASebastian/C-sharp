using Microsoft.EntityFrameworkCore;
using Nu_iMero.Data;
using System.Threading.Tasks;

namespace Nu_iMero.Services  // Make sure to adjust this namespace to your project
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        // Constructor for UserService that takes ApplicationDbContext
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Method to count the number of users
        public async Task<int> GetUserCountAsync()
        {
            return await _context.Users.CountAsync();  // Fetch the user count asynchronously
        }
    }
}
