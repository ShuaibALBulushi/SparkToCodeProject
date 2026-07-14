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

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("GRAND VISTA HOTEL – MANAGEMENT SYSTEM");
                Console.WriteLine("=================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("=================================================");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoomForGuest(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchAndFilterRooms(); break;
                    case 7: GuestAndBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookupByName(); break;
                    case 10: RoomTypeBreakdownReport(); break;
                    case 11: CheckOutGuest(); break;
                    case 12: RemoveUnavailableRooms(); break;
                    case 13: ExtendGuestStay(); break;
                    case 14: HighestRevenueBooking(); break;
                    case 15: GuestPaginationViewer(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Thank you for using Grand Vista Hotel Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 0 and 15.");
                        break;
                }

                if (!exitApp)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            // Case 1
            void AddNewRoom()
            {
                Console.WriteLine("### Add New Room ###");
                Console.WriteLine("Enter the room number: ");
                int roomNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the room type (Single / Double / Suite): ");
                string roomtype = Console.ReadLine();

                Console.WriteLine("Enter the Price per night: ");
                double price = double.Parse(Console.ReadLine());

                bool roomExist = rooms.Any(r => r.roomNumber == roomNum);

                if (roomNum > 0 && price > 0)
                {
                    if (roomExist)
                    {
                        Console.WriteLine("Error: Room with same number already exist");
                        return;
                    }
                    else
                    {
                        Room newRoom = new Room(roomNum, roomtype, price, true);
                        rooms.Add(newRoom);

                        Console.WriteLine("New room added successfully");
                        Console.WriteLine("Room Number: " + newRoom.roomNumber);
                        Console.WriteLine("Room Type: " + newRoom.roomType);
                        Console.WriteLine("Price Per Night: " + newRoom.pricePerNight);
                        Console.WriteLine("Total Rooms in System: " + rooms.Count);
                    }
                }
                else
                {
                    Console.WriteLine("both room number and price per night must be positive");
                }
               
            }

        }

    }
}
