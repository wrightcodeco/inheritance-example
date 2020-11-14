using System;

namespace TestApplication.Services.Webhooks.ProductOnSale
{
    public class ProductOnSaleEvent
    {
        public string ProductName { get; set; }

        public DateTime SaleEndDate { get; set; }

        public decimal SalePercentage { get; set; }
    }
}