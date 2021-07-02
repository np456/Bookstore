using BookStore.Enums;
using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Helpers
{
    public static class BookHelper
    {
        private const decimal GST = 1.1m;
        private const decimal DELIVERY_FEE = 5.95m;
        private const decimal DISCOUNT = 0.95m;

        public static decimal CalculateOrderWithTax(decimal total)
        {
            total = GST * total;

            return calcDelivery(total);
        }

        public static decimal CalculateOrderWithoutTax(decimal total)
        {           

            return calcDelivery(total); ;
        }

        public static decimal calcTotal(this IEnumerable<Book> bookOrder)
        {
            var order = 0.0m;

            foreach (var book in bookOrder)
            {
                if (book.Genre == Genre.Crime)
                {
                    order += DISCOUNT * book.UnitPrice;
                }
                else
                {
                    order += book.UnitPrice;
                }               
            }

            return order;
        }

        private static decimal calcDelivery(decimal total)
        {
            if (total < 20)
            {
                total += DELIVERY_FEE;
            }

            return total;
        }

    }
}
