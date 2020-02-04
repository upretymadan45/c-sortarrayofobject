using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Booking[] bookings = new Booking[9];
            bookings[0] = new Booking { Name = "Zebra", Guests = 10 };
            bookings[1] = new Booking { Name = "Usama", Guests = 15 };
            bookings[2] = new Booking { Name = "Alias", Guests = 12 };

            bookings[3] = new Booking { Name = "Ram", Guests = 10 };
            bookings[4] = new Booking { Name = "Shyam", Guests = 15 };
            bookings[5] = new Booking { Name = "Hari", Guests = 12 };

            bookings[6] = new Booking { Name = "Suman", Guests = 10 };
            bookings[7] = new Booking { Name = "Madan", Guests = 15 };
            bookings[8] = new Booking { Name = "Gopal", Guests = 12 };

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    int lth = bookings[i].Name.Length < bookings[j].Name.Length ? bookings[i].Name.Length : bookings[j].Name.Length;
                    for (int k = 0; k < lth; k++)
                    {
                        if (bookings[i].Name[k] > bookings[j].Name[k])
                        {
                            var temp = bookings[i];
                            bookings[i] = bookings[j];
                            bookings[j] = temp;
                            break;
                        }
                        else if (bookings[i].Name[k] < bookings[j].Name[k])
                        {
                            break;
                        }
                    }
                }
            }

            // Display Result by Following Code

            foreach (Booking s in bookings)
            {
                Console.WriteLine(s.Name+" "+s.Guests);
            }

            Console.ReadLine();
        }
    }

    public class Booking
    {
        public string Name { get; set; }
        public int Guests { get; set; }
    }
}
