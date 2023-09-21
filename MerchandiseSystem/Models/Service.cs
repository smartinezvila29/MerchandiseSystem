using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseSystem.Models
{
    public class Service : Merchandise
    {
        public string service {  get; set; }
        public double budget { get; set; }
        public double discount { get; set; }
        public bool onOffer { get; set; }

        public Service(string merchandiseCode, string service, double budget, double discount, bool onOffer)
        {
            this.MerchandiseCode = merchandiseCode;
            this.service = service;
            this.budget = budget;
            this.discount = discount;
            this.onOffer = onOffer;
        }

        public override double calculateFinalPrice()
        {
            if (this.onOffer)
            {
                return this.budget - (this.budget * (this.discount/100));
            }
            else
            {
                return this.budget;
            }
        }
    }
}
