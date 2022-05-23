using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLTV2._0.Models.CartComponentModels
{
    public class CartItems
    {
        public Sach items { get; set; }
        public int qty { get; set; }
        [DisplayFormat(DataFormatString = "{0:N}")]
        public decimal total { get; set; }

        public CartItems(Sach items, int qty)
        {
            this.items = items;
            this.qty = qty;
            total=items!=null?(decimal)(qty * items.Giaban):0;
        }
        public decimal TotalPrice()
        {
            return (qty * total);
        }
    }
}
