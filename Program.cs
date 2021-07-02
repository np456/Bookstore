using BookStore.Helpers;
using BookStore.Models;
using System;
using System.Collections.Generic;

namespace BookStore
{
    /// <summary>
    /// Simple console application to calculate an order cost.
    /// </summary>
    class Program
    { 
        static void Main(string[] args)
        {
            var bookOrder = new List<Book>();

            bookOrder.AddRange(BookCreator.CustomerOrder());
            
            var order = BookHelper.calcTotal(bookOrder);

            Console.WriteLine("The price of your order with tax: " + BookHelper.CalculateOrderWithTax(order));
            Console.WriteLine("The price of your order without tax: " + BookHelper.CalculateOrderWithoutTax(order));
        }

    }
}
