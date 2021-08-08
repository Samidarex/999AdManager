using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _999.Models
{
    public class _999Products
    {
        public string Title { get; set; }

        public string[] Categories { get; set; }

        public string[] SubCategories { get; set; }

        public string Description { get; set; }

        public string[] ImagesUrl { get; set; }

        public _999OfferType OfferType { get; set; }

        public _999State State { get; set; }

        public float Price { get; set; }
    }
}
