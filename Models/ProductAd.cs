using System;
namespace Web.Models
{
    public class ProductAd : Ad
    {
        public ProductAd()
        {
        }

        public ProductAd(string linkUrl, string imageUrl, string content, decimal price, AdSource source) : base(linkUrl, imageUrl, content)
        {
            this.Price = price;
            this.Source = source;
        }

        public decimal Price { get; set; }
        public AdSource Source { get; set; }
    }

    public enum AdSource
    {
        Amazon = 1,
        Other = 2
    }
}
