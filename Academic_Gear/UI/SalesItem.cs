using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UI
{
    public class SalesItem
    {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get; set; }
            public DateTime Date { get; set; }
            public string PaymentMethod { get; set; }
        }
    public static class SalesData
    {
        public static BindingList<SalesItem> SalesHistory =
            new BindingList<SalesItem>();
    }
}