using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora.VendingItems
{
    public class VendingItems
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }

        public VendingItems(int id, string code, double price)
        {
            Id = id;
            Code = code;
            Price = price;
        }
    }
}
