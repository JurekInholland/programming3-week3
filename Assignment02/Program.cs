using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {

            Program myProgram = new Program();
            myProgram.Start();
        }

        public void Start()
        {
            Customer c1 = new Customer("Lionel", DateTime.Today.AddYears(-25));
            Customer c2 = new Customer("Piet", new DateTime(1992, 3, 13));
            //PrintCustomer(c1);
            //PrintCustomer(c2);


            c2.setRegDate(new DateTime(1999, 3, 12));

            DateTime testDate = new DateTime(2019, 2, 23);
            DateTime testDate2 = new DateTime(2019, 2, 25);
            //testDate = testDate.AddMinutes(15);
            Ticket t1 = new Ticket("Movie1", 2, testDate, 16, 10.5);
            Ticket t2 = new Ticket("Movie1", 2, testDate, 16, 10.5);
            Ticket t3 = new Ticket("Movie1", 2, testDate2, 16, 10.5);


            Reservation r1 = new Reservation(c1);
            Reservation r2 = new Reservation(c2);

            r1.AddTicket(t1);
            r1.AddTicket(t2);
            r1.AddTicket(t3);
            double total = r1.TotalPrice;


            r2.AddTicket(t1);
            r2.AddTicket(t2);
            r2.AddTicket(t3);
            double total2 = r2.TotalPrice;
            Console.ReadKey();

        }

        public void PrintCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(customer.Name);
            Console.ResetColor();

            Console.WriteLine("date of birth: {0}", customer.DateOfBirth.ToShortDateString());
            Console.WriteLine("age: {0}", customer.Age);
            Console.WriteLine("date of registration: {0}", customer.registration_date);
            Console.WriteLine("discount: {0}", customer.Discount.ToString());
        }
    }
}
