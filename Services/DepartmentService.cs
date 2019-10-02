using System.Linq;
using ProjetoWebMVC.Models;
using System.Collections.Generic;

namespace ProjetoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebMVCContext _context;

        public DepartmentService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Nome).ToList();
        }
    }
}
