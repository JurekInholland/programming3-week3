using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Reservation
    {
        private Customer customer { get; set; }
        private List<Ticket> tickets = new List<Ticket>();

        public Reservation(Customer customer)
        {
            this.customer = customer;
        }

        public double TotalPrice
        {
            get
            {
                double total = 0;
                double price = 0;
                foreach (Ticket ticket in tickets)
                {

                    if (ticket.Discount)
                    {
                        price = ticket.Price * 0.95;
                    } else
                    {
                        price = ticket.Price;
                    }
                    total += price;
                    
                }

                if (customer.Discount)
                {
                    total = total * 0.9;
                }
                Console.WriteLine("total price of reservation: {0:N2}", total);
                return total;
                
            }
        }

        public List<Ticket> Tickets
        {
            get
            {
                return tickets;
            }
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
            Console.WriteLine("created ticket " + ticket.toString());
        }
    }


   
}
