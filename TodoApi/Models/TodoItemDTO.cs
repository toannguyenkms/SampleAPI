using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public string Name { get; set; }

        public long CategoryId { get; set; }

        public string Description { get; set; }

        public string ManufacturerUrl { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
