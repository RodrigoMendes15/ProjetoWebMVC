using System.Linq;
using ProjetoWebMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebMVCContext _context;

        public DepartmentService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
