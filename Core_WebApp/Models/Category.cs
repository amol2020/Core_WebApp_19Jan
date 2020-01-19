using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_WebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryRowId { get; set; }
        [Required(ErrorMessage = "Category Id is required")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Base Price is required")]
        public int BasePrice { get; set; }
        //one to many relationship
        public IList<Product> Products { get; set; }

    }

    public class Product
    {
        [Key]
        public int ProductRowId { get; set; }
        [Required(ErrorMessage = "Product Row Id is required")]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Manufacturer is required")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
        //reference of product
        ////[Required(ErrorMessage = "CategoryRow is required")]
        ////public int CategoryRowId { get; set; }cmd
        public Category category { get; set; }

    }
}
