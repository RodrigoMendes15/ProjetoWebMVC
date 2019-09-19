using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Department Departamento { get; set; }
        public ICollection<SalesRecord> Vendas { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Department departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(SalesRecord sr)
        {
            Vendas.Add(sr);
        }

        public void RemoverVendas(SalesRecord sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Valor);   
        }
    }
}
