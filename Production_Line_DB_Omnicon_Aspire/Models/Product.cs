using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Production_Line_DB_Omnicon_Aspire.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Modified_date { get; set; }
        public decimal Quantity { get; set; }
    }
    public class myDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}