
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Entity
{
    public class Model:Base
    {
        public string ModelName { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
        [Range(1, int.MaxValue)]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Price { get; set; }
        [Range(1, int.MaxValue)]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Km { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }

    }
}
