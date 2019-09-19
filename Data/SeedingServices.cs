using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoWebMVC.Models;
using ProjetoWebMVC.Models.Enums;

namespace ProjetoWebMVC.Data
{
    public class SeedingServices
    {
        private ProjetoWebMVCContext _context;

        public SeedingServices(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //BD já foi populado.
            }

            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletrônicos");
            Department d3 = new Department(3, "Livraria");
            Department d4 = new Department(4, "Moda");
            Department d5 = new Department(5, "Cama, Mesa e Banho");
            Department d6 = new Department(6, "Games");

            Seller s1 = new Seller(1, "Rodrigo Mendes", "rodrigo.mendes@gmail.com", new DateTime(1988, 03, 15), 3000.00, d1);
            Seller s2 = new Seller(2, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s3 = new Seller(3, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s4 = new Seller(4, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d2);
            Seller s5 = new Seller(5, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s6 = new Seller(6, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s7 = new Seller(7, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);
            Seller s8 = new Seller(8, "Larissa Mendes", "larissa.mendes@gmail.com", new DateTime(1991, 10, 23), 4000.0, d5);
            Seller s9 = new Seller(9, "Bibinha Pikachu", "bp@gmail.com", new DateTime(1997, 3, 4), 3000.0, d6);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 09, 25), 11000.0, SaleStatus.Processado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 09, 4), 7000.0, SaleStatus.Processado, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 09, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 09, 1), 8000.0, SaleStatus.Processado, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 09, 21), 3000.0, SaleStatus.Processado, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 09, 15), 2000.0, SaleStatus.Processado, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 09, 28), 13000.0, SaleStatus.Processado, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 09, 11), 4000.0, SaleStatus.Processado, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 09, 14), 11000.0, SaleStatus.Pendente, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 09, 7), 9000.0, SaleStatus.Processado, s7);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 09, 13), 6000.0, SaleStatus.Processado, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 09, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 09, 29), 10000.0, SaleStatus.Processado, s7);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 09, 4), 3000.0, SaleStatus.Processado, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 09, 12), 4000.0, SaleStatus.Processado, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 08, 5), 2000.0, SaleStatus.Processado, s8);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 08, 1), 12000.0, SaleStatus.Processado, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 08, 24), 6000.0, SaleStatus.Processado, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 08, 22), 8000.0, SaleStatus.Processado, s8);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 08, 15), 8000.0, SaleStatus.Processado, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 08, 17), 9000.0, SaleStatus.Processado, s9);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 08, 24), 4000.0, SaleStatus.Processado, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 08, 19), 1000.0, SaleStatus.Cancelado, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 08, 12), 8000.0, SaleStatus.Processado, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 08, 31), 7000.0, SaleStatus.Processado, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 08, 6), 5000.0, SaleStatus.Processado, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 08, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 08, 7), 4000.0, SaleStatus.Processado, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 08, 23), 12000.0, SaleStatus.Processado, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 08, 12), 5000.0, SaleStatus.Processado, s2);

            _context.Department.AddRange(d1, d2, d3, d4, d5, d6);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
