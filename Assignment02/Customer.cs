using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Customer
    {
        private string name;
        //private int age;
        private DateTime date_of_birth;
        //private bool discount;

        public DateTime registration_date { get; private set; }


        public Customer(string name, DateTime birthDate)
        {
            this.Name = name;
            this.DateOfBirth = birthDate;
            this.registration_date = DateTime.Now;
        }


        // Only for debugging 
        public void setRegDate(DateTime regDate)
        {
            registration_date = regDate;
        }

        public string Name
        {
            get { return name; }
            set {
                if (value.Length > 0)
                {
                    name = value;
                }
            }
        }

        public int Age
        {

            get {
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = DateTime.Now - date_of_birth;
                int years = (zeroTime + span).Year - 1;

                return years; }
        }

        public DateTime DateOfBirth
        {
            get { return date_of_birth; }
            set
            {
                if (value < DateTime.Now && value > DateTime.Today.AddYears(-80))
                {
                    date_of_birth = value;
                }
            }
        }

        public bool Discount
        {
            get
            {
                TimeSpan span = DateTime.Today - registration_date;

                if ( span.Days > 365)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
