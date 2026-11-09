using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ProductItem
    {
        //iniistore ang info bawat register ng product
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string UnitPerMeasure { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    //temporary storage na shared by product reg at inventory management
    public static class ProductData
    {
        //lahat ng registered products dine nakalagay
        public static BindingList<ProductItem> Products = new BindingList<ProductItem>();
    }
}
