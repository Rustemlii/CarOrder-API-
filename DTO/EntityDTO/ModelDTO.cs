using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.EntityDTO
{
    public class ModelDTO
    {
        public string ModelName { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Km { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int MarkaID { get; set; }
        public DateTime Time { get; set; }
    }
}
