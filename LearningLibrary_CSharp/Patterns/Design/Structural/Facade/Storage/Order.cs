﻿using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Facade.Storage
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}