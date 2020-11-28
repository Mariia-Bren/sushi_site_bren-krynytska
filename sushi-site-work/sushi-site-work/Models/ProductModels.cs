using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sushi_site_work.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [Display(Name = "Категорія")]        
        public string Name { get; set; }
        [Display(Name = "Опис категорії")]
        public string Description { get; set; }
        public ICollection<Product> products { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [Display(Name = "Вартість")]
        public int Cost { get; set; }
        [Display(Name = "Фото")]
        public string PhotoPath { get; set; }
        [Display(Name = "Категорія")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string PhotoPath { get; set; }
    }
}