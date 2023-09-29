using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseSystem.Models
{
    public class MainSystem
    {

        public List<Merchandise> listMerchandise = new List<Merchandise>();

        public Merchandise GetMerchandise(string merchandiseCode)
        {
            return listMerchandise.Where(x => x.MerchandiseCode == merchandiseCode).FirstOrDefault();
        }

        public List<Merchandise> GetMerchandise(bool onOffer)
        {
            List<Merchandise> listOnOffer = new List<Merchandise>();
            foreach (var item in listMerchandise.OfType<Product>().ToList())
            {
                if (item.discountSecondUnit.Equals(onOffer)) { listOnOffer.Add(item); }
            }
            foreach(var item in listMerchandise.OfType<Service>().ToList())
            {
                if (item.discount.Equals(onOffer)) { listOnOffer.Add(item); }
            }
            return listOnOffer;
        }

        public bool AddProduct(string merchCode, string product, double price, bool secondDiscount, double discount = 0)
        {
            if(GetMerchandise(merchCode) == null)
            {
                listMerchandise.Add(new Product(merchCode, product, price, discount, secondDiscount));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddService(string merchCode, string service, double budget, bool onOffer, double discount = 0)
        {
            if(GetMerchandise(merchCode) == null){
                listMerchandise.Add(new Service(merchCode, service, budget, discount, onOffer));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
