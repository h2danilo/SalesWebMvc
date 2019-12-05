using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }


            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Danilo", "danilo@idxsistemas.com.br", new DateTime(1987, 10, 7), 1000, d1);
            Seller s2 = new Seller(2, "Paulo", "paulo@idxsistemas.com.br", new DateTime(1984, 2, 20), 2000, d2);
            Seller s3 = new Seller(3, "Mair", "mair@idxsistemas.com.br", new DateTime(1982, 10, 15), 3000, d3);
            Seller s4 = new Seller(4, "Matheus", "matheus@idxsistemas.com.br", new DateTime(1990, 11, 11), 4000, d4);
            Seller s5 = new Seller(5, "Joao", "joao@idxsistemas.com.br", new DateTime(1991, 12, 22), 4000, d1);
            Seller s6 = new Seller(6, "Jose", "jose@idxsistemas.com.br", new DateTime(1970, 01, 11), 4000, d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 12, 4), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 12, 4), 10000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2019, 12, 4), 19000.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2019, 12, 4), 1000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2019, 12, 4), 13500.0, SaleStatus.Billed, s5);

            SalesRecord sr6 = new SalesRecord(6, new DateTime(2019, 11, 20), 1000.0, SaleStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2019, 12, 15), 15000.0, SaleStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2019, 10, 10), 13500.0, SaleStatus.Billed, s3);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2019, 09, 7), 100.0, SaleStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2019, 01, 8), 1590.0, SaleStatus.Billed, s5);

            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 12, 4), 11500.0, SaleStatus.Billed, s1);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2019, 1, 19), 1000.0, SaleStatus.Billed, s2);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2019, 9, 29), 1900.0, SaleStatus.Billed, s3);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2019, 10, 24), 12000.0, SaleStatus.Billed, s4);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2019, 4, 4), 2000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15);

            _context.SaveChanges();
        }

    }
}
