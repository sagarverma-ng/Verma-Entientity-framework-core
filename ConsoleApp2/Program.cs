using ConsoleApp2.Models;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SaveSingleRecord();
            // SaveMultipleRecord();
            // EditSingleRecord();
            // EditMultipleRecord();
            // DeleteSingleRecord();
            // DeleteMultipleRecord();
            //SelectRecord();
        }



        private static void EditSingleRecord()
        {
            ProductContext _context = new ProductContext();

            Product objProduct = _context.Products.Where(obj => obj.Id == 0).Select(a => a).FirstOrDefault();
            objProduct.NameData = "zero";
            _context.SaveChanges();
        }

        private static void EditMultipleRecord()
        {
            ProductContext _context = new ProductContext();

            IQueryable<Product> objProduct = _context.Products.Select(a => a).Select(a => a);
            //IQueryable<Product> objProduct = _context.Products.Select(a => a).Take(5);

            foreach (Product item in objProduct)
            {
                item.NameData = "New Update";
            }

            _context.SaveChanges();
        }

        static void SaveSingleRecord()
        {
            ProductContext _context = new ProductContext();
            Product objProduct = new Product();
            objProduct.NameData = "New entry";
            objProduct.Id = 6;
            _context.Products.Add(objProduct);
            _context.SaveChanges();
        }

        private static void SaveMultipleRecord()
        {
            ProductContext _context = new ProductContext();
            for (int i = 0; i < 10; i++)
            {

                Product objProduct = new Product();
                objProduct.NameData = "New entry_" + i;
                objProduct.Id = 7 + i;
                _context.Products.Add(objProduct);

            }
            _context.SaveChanges();
        }

        private static void DeleteSingleRecord()
        {
            ProductContext _context = new ProductContext();
            Product objProduct = _context.Products.Where(obj => obj.Id == 9).Select(a => a).FirstOrDefault();
            _context.Remove(objProduct);
            _context.SaveChanges();
        }

        static void DeleteMultipleRecord()
        {
            ProductContext _context = new ProductContext();
            IQueryable<Product> objProduct = _context.Products.Where(obj => obj.NameData == "Student Class").Select(a => a);

            foreach (Product item in objProduct)
            {
                _context.Remove(item);

            }
            _context.SaveChanges();
        }

        private static void SelectRecord()
        {
            //  ProductContext _context = new ProductContext();
            // Product objProduct2 = _context.Products.Where(obj => obj.NameData == "Student Class").Select(a => a).FirstOrDefault();
            // Product objProduct1 = _context.Products.Where(obj => obj.NameData == "Student Class").Select(a => a).First();
            // Product objProduct3 = _context.Products.Where(obj => obj.Id == 100).Select(a => a).Single();
            // Product objProduct4 = _context.Products.Where(obj => obj.Id == 100).Select(a => a).SingleOrDefault();
        }


    }
}
