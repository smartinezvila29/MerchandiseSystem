using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseSystem.Models
{
    public abstract class Merchandise
    {
        public string MerchandiseCode {  get; set; }

        public abstract double calculateFinalPrice();
    }
}
