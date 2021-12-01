using System;
using System.Collections;
using System.Text;

namespace Expert
{
    public class Ticket
    {
        private ArrayList offeritem = new ArrayList();

        public DateTime DateTime { get; set; }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (Ticket item in this.offerItem)
                {
                    result = result + (item.Quantity * item.OfferItem.Price);
                }

                return result;
            }
        }

        public void AddLineItem(Ticket item)
        {
            this.offerItems.Add(item);
        }

        public void RemoveLineItem(Ticket item)
        {
            this.offerItems.Remove(item);
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Fecha: {this.DateTime}");
            foreach (Ticket item in this.offerItems)
            {
                Console.WriteLine($"{item.Quantity} de '{item.ResidueType.Type}' a ${item.Product.Price}");
            }

            Console.WriteLine($"Total: ${this.Total}");
        }
    }
}