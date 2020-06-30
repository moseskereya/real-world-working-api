using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api3.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public Price Price { get; set; }
        public string ImgUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Format { get; set; }
        public int AvailableInStock { get; set; }
    }
}
