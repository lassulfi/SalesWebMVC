﻿using System;
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
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB já populado
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.00, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.00, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.00, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.00, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.00, d3);
            Seller s6 = new Seller(6, "Alex Pink", "pink@gmail.com", new DateTime(1997, 3, 4), 3000.00, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.0, SaleStatus.BILLED, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 9, 4), 7000.0, SaleStatus.BILLED, s5);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 9, 13), 4000.0, SaleStatus.CANCELED, s4);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 9, 1), 8000.0, SaleStatus.BILLED, s1);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 9, 21), 3000.0, SaleStatus.BILLED, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 9, 15), 2000.0, SaleStatus.BILLED, s1);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 9, 28), 13000.0, SaleStatus.BILLED, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 9, 11), 4000.0, SaleStatus.BILLED, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 9, 14), 11000.0, SaleStatus.PENDING, s6);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 9, 7), 9000.0, SaleStatus.BILLED, s6);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 9, 13), 6000.0, SaleStatus.BILLED, s2);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 9, 25), 7000.0, SaleStatus.PENDING, s3);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 9, 29), 10000.0, SaleStatus.BILLED, s4);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 9, 4), 3000.0, SaleStatus.BILLED, s5);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 9, 12), 4000.0, SaleStatus.BILLED, s1);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.BILLED, s4);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.BILLED, s1);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.BILLED, s3);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.BILLED, s5);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.BILLED, s6);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.CANCELED, s2);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 10, 24), 6000.0, SaleStatus.BILLED, s4);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.CANCELED, s2);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.BILLED, s5);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.BILLED, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.BILLED, s4);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.PENDING, s1);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.BILLED, s3);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.BILLED, s5);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.BILLED, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, 
                sr13, sr4, sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, 
                sr28, sr29, sr30);

            _context.SaveChanges();
        }
    }
}
