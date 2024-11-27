using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    //ICollection : Koleksiyon türleri için temel bir arayüzdür. List, HashSet,LinkedList, Dictionary...
    public class Category : Entity
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        //Navigation Property
        public ICollection<Product>? Products { get; set; }

    }
}
