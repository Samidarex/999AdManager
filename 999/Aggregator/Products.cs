

namespace _999.Aggregator
{
    public class Products
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Price { get; set; }

        public override string ToString()
        {
            return $"{this.Title} | {this.ImageUrl} | {this.Price}";
        }
    }
}
