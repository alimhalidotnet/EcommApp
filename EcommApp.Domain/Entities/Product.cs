using System;
using System.Collections.Generic;
using System.Text;

namespace EcommApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProdName {  get; set; }=string.Empty; 
        public string Description { get; set; } = string.Empty;

    }
}
