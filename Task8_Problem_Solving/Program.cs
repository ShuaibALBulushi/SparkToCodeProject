namespace Task8_Problem_Solving
{
    class Room
    {
        public int roomNumber {  get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void DisplayRoom()
        {
            Console.WriteLine("### Room Details ###");
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Price Per Night: " + pricePerNight);
            if (isAvailable)
            {
                Console.WriteLine("Room is available");
            }
            else
            {
                Console.WriteLine("Room is not available");
            }
            
        }
    }

    class Guest
    {
        public int guestID { get; set; }
        public string guestName { get; set; }
        public int roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }

        public Guest (int guestID, string guestName, int roomNumber, string checkInDate, int totalNights)
        {
            this.guestID = guestID;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine("### Guest Details ###");
            Console.WriteLine("Guest ID: " + guestID);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Check-in Date: " + checkInDate);
            Console.WriteLine("Total Nights: " + totalNights);
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return totalNights * pricePerNight;
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(101, "Single", 75.0, true));
            rooms.Add(new Room(102, "Single", 75.0, false));
            rooms.Add(new Room(201, "Double", 120.0, true));
            rooms.Add(new Room(202, "Double", 130.0, false));
            rooms.Add(new Room(301, "Suite", 250.0, true));
            rooms.Add(new Room(302, "Suite", 300.0, false));


        }
    }
}
