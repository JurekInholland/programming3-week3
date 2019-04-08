using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Ticket
    {
        private string name;
        private int room;
        private DateTime startDate;
        public double Price { get; set; }
        private int minimumAge;


        public Ticket(string name, int room, DateTime startDate, int minimumAge, double price)
        {
            Name = name;
            Room = room;
            StartDate = startDate;
            Age = minimumAge;
            Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                } else
                {
                    Console.WriteLine("Name must be > 0");

                }
            }
        }

        public int Room
        {
            get
            {
                return room;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    room = value;
                } else
                {
                    Console.WriteLine("Room nr invalid! ", value.ToString());
                    //throw new Exception("Room nr invalid!");
                }
            }
        }
        
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                if(value.Minute == 30 || value.Minute == 0)
                {
                    startDate = value;
                } else
                {
                    Console.WriteLine("Start date invalid! {0}", value.ToString());
                }
            }
        }

        public int Age
        {
            get
            {
                return minimumAge;

            }

            set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                {
                    minimumAge = value;
                } else
                {
                    Console.WriteLine("Min age invalid!", value.ToString());
                }
            }
        }

        public bool Discount
        {
            get
            {
                if (startDate.DayOfWeek.ToString() == "Monday" || startDate.DayOfWeek.ToString() == "Tuesday")
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public string toString()
        {
            string output = string.Format("{0}, starttime: {1}, price: {2}, room: {3}", Name, StartDate.ToShortDateString(), Price, Room);
            return output;
        }
    }
}
