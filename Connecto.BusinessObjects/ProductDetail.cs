﻿using System;

namespace Connecto.BusinessObjects
{
    public class ProductDetail : Connecto
    {
        public int ProductDetailId { get; set; }
        public Guid ProductDetailGuid { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
