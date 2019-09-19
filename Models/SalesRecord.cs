using System;
using ProjetoWebMVC.Models.Enums;

namespace ProjetoWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Vendas { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime data, double valor, SaleStatus status, Seller vendas)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendas = vendas;
        }
    }
}
