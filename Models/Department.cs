using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public ICollection<Seller> Vendedor { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Seller vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedor.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }
    }
}
