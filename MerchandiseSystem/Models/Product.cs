using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseSystem.Models
{
    public class Product : Merchandise
    {
        public string product {  get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public bool discountSecondUnit { get; set; }

        public Product(string merchandiseCode, string product, double price, double discount, bool discountSecondUnit)
        {
            this.MerchandiseCode = merchandiseCode;
            this.product = product;
            this.price = price;
            this.discount = discount;
            this.discountSecondUnit = discountSecondUnit;
        }

        public override double calculateFinalPrice()
        {
            if (this.discountSecondUnit)
            {
                var discountToApply = (this.discount / 2) / 100;
                return this .price - (this.price * discountToApply);
            }
            else
            {
                return this.price;
            }
        }
    }
}
