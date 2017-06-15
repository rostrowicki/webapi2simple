﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id=1, Name="Tomato Soup", Category="Grocieries", Price=2.5M},
            new Product {Id=2, Name="Yo-yo", Category="Toys", Price = 3.75M},
            new Product {Id=3, Name="Hammer", Category="Hardware", Price=16.99M}
        };


        // GET: Products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}