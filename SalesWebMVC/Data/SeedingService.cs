using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
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
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d1);
            Seller s3 = new Seller(3, "Alex Grey", "alexg@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d1);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d1);
            Seller s6 = new Seller(6, "Alex Pink", "alexp@gmail.com", new DateTime(1997, 3, 4), 3000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 4000.0, SaleStatus.Pending, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 5), 8000.0, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 2), 8500.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 18), 10500.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 18), 7500.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 19), 1500.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 21), 500.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 7), 9500.0, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 7), 2200.0, SaleStatus.Pending, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 3), 2250.0, SaleStatus.Pending, s5);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 11), 1550.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 15), 7880.0, SaleStatus.Billed, s6);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 09, 16), 17810.0, SaleStatus.Billed, s6);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 09, 18), 21000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17
            );

            _context.SaveChanges();
        }
    }
}
