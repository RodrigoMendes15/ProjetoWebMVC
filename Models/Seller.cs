using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ProjetoWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigarório!")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "Endereço Eletrônico")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} obrigarório!")]
        [EmailAddress(ErrorMessage = "{0} obrigatório!")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} obrigarório!")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} obrigarório!")]
        [Range(100.0, 50000.0, ErrorMessage = "O {0} deve estar entre {1} a {2}")]
        public double SalarioBase { get; set; }
        public Department Departamento { get; set; }
        public int DepartmentId { get; set; }
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
