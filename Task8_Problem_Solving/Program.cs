using System.Reflection.Metadata.Ecma335;

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
        public string guestID { get; set; }
        public string guestName { get; set; }
        public int roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }

        public Guest (string guestID, string guestName, int roomNumber, string checkInDate, int totalNights)
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

            // Case 2
            void RegisterNewGuest()
            {
                Console.WriteLine("### Register New Guest ###");

                Console.WriteLine("Enter guest name: ");
                string gname = Console.ReadLine();

                Console.WriteLine("Enter check-in date: ");
                string checkIN = Console.ReadLine();

                Console.WriteLine("Enter number of nights: ");
                int nightNum = int.Parse(Console.ReadLine());

                int nextIdNumber = guests.Count + 1;
                string guestId = "G" + nextIdNumber.ToString("D3");
                if (nightNum > 0)
                {
                    Guest newGuest = new Guest(guestId, gname, 0, checkIN, nightNum);
                    guests.Add(newGuest);

                    Console.WriteLine("New guest added successfully");
                    Console.WriteLine("Guest ID: " + newGuest.guestID);
                    Console.WriteLine("Guest Name: " + newGuest.guestName);
                    Console.WriteLine("Room Number: Not Assinged");
                    Console.WriteLine("Total Nights: " + newGuest.totalNights);
                }
                else
                {
                    Console.WriteLine("Error: number of nights must be positive");
                }
                
            }

            // Case 3
            void BookRoomForGuest()
            {
                Console.WriteLine("Enter Guest ID: ");
                string guestId = Console.ReadLine();

                Console.WriteLine("Enter the room number: ");
                int rooNum = int.Parse(Console.ReadLine());

                Guest foundGuest = guests.FirstOrDefault(g => g.guestID == guestId);
                Room foundRoom = rooms.FirstOrDefault(r => r.roomNumber == rooNum);

                if(foundGuest != null)
                {
                    if(foundRoom != null)
                    {
                        if (foundRoom.isAvailable)
                        {
                            foundGuest.roomNumber = foundRoom.roomNumber;
                            foundRoom.isAvailable = false;

                            Console.WriteLine("### room is booked successfuly ###");
                            Console.WriteLine("Guest Name: " + foundGuest.guestName);
                            Console.WriteLine("Room Number: " + foundGuest.roomNumber);
                            Console.WriteLine("Room Type: " + foundRoom.roomType);
                            Console.WriteLine("Price Per Night: " + foundRoom.pricePerNight);
                            Console.WriteLine("Total Nights: " + foundGuest.totalNights);
                            Console.WriteLine("Total Cost: " + foundGuest.CalculateTotalCost(foundRoom.pricePerNight));
                            
                        }
                        else
                        {
                            Console.WriteLine("Room is already booked");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Room is Not Found");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Guest is Not Found");
                    return;
                }

            }

            // Case 4
            void ViewAllRooms()
            {
                var sortedRooms = rooms.OrderBy(r => r.roomNumber);

                Console.WriteLine("Total Rooms: " + sortedRooms.Count());

                if(sortedRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms have been added yet");
                }
                else
                {
                    foreach (Room room in sortedRooms)
                    {
                        Console.WriteLine("### Room Info ###");
                        Console.WriteLine("Room Number: " + room.roomNumber);
                        Console.WriteLine("Room Type: " + room.roomType);
                        Console.WriteLine("Price Per Night: " + room.pricePerNight);
                        if (room.isAvailable)
                        {
                            Console.WriteLine("Available\n");
                        }
                        else
                        {
                            Console.WriteLine("Booked\n");
                        }
                    }
                }

            }

            // Case 5
            void ViewAllGuests()
            {
                var sortedGuests = guests.OrderBy(g => g.guestName);

                Console.WriteLine("Total Number of Guests: " + sortedGuests.Count());

                if(sortedGuests.Count() == 0)
                {
                    Console.WriteLine("No guests have been registered yet.");
                }
                else
                {
                    foreach(Guest guest in sortedGuests)
                    {
                        Console.WriteLine("### Guest Info ###");
                        Console.WriteLine($"Guest ID: {guest.guestID}");
                        Console.WriteLine($"Guest Name: {guest.guestName}");
                        if(guest.roomNumber == 0)
                        {
                            Console.WriteLine("Room number: Not Assigned");
                        }
                        else
                        {
                            Console.WriteLine($"Room Number: {guest.roomNumber}");
                        }
                        Console.WriteLine($"Check-In date: {guest.checkInDate}");
                        Console.WriteLine($"Total Nights: {guest.totalNights}\n");
                    }
                }
            }

            // Case 6
            void SearchAndFilterRooms()
            {
                bool exitSub = false;
                while (!exitSub)
                {
                    Console.WriteLine("### Sub Menu ###");
                    Console.WriteLine(" 1. Show all available rooms");
                    Console.WriteLine(" 2. Filter by room type");
                    Console.WriteLine(" 3. Filter by max price");
                    Console.WriteLine(" 4. Room price statistics");
                    Console.WriteLine(" 0. Back");
                    Console.WriteLine("=========================================");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            var AllRooms = rooms.Where(r => r.isAvailable == true).OrderBy(r => r.pricePerNight);

                            if (AllRooms.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Available rooms " + AllRooms.Count());
                                foreach (var room in AllRooms)
                                {
                                    Console.WriteLine("### Room Info ###");
                                    Console.WriteLine("Room Number: " + room.roomNumber);
                                    Console.WriteLine("Room Type: " + room.roomType);
                                    Console.WriteLine("Price Per Night: " + room.pricePerNight.ToString("F2"));
                                    Console.WriteLine("Room Available\n");
                                }
                            }
                            break;

                        case "2":
                            Console.WriteLine("Enter the room type (Single / Double / Suite): ");
                            string roomtype = Console.ReadLine();

                            var FilterByType = rooms.Where(r => r.roomType.ToLower() == roomtype.ToLower());

                            if (FilterByType.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Matching rooms " + FilterByType.Count());
                                foreach (var room in FilterByType)
                                {
                                    Console.WriteLine("### Room Info ###");
                                    Console.WriteLine("Room Number: " + room.roomNumber);
                                    Console.WriteLine("Room Type: " + room.roomType);
                                    Console.WriteLine("Price Per Night: " + room.pricePerNight.ToString("F2"));
                                    if (room.isAvailable)
                                    {
                                        Console.WriteLine("Room Available\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Room Booked\n");
                                    }
                                }
                            }
                            break;

                        case "3":
                            Console.WriteLine("Enter the maximum price: ");
                            double maxPrice = double.Parse(Console.ReadLine());

                            var FilterbyPrice = rooms.Where(r => r.isAvailable == true && r.pricePerNight <= maxPrice).OrderBy(r => r.pricePerNight);

                            if (FilterbyPrice.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Available rooms " + FilterbyPrice.Count());
                                foreach (var room in FilterbyPrice)
                                {
                                    Console.WriteLine("### Room Info ###");
                                    Console.WriteLine("Room Number: " + room.roomNumber);
                                    Console.WriteLine("Room Type: " + room.roomType);
                                    Console.WriteLine("Price Per Night: " + room.pricePerNight.ToString("F2"));
                                    Console.WriteLine("Room Available\n");
                                }
                            }
                            break;

                        case "4":
                            if (rooms.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                int totalRooms = rooms.Count();
                                int availableRooms = rooms.Count(r => r.isAvailable == true);
                                double avgPrice = rooms.Average(r => r.pricePerNight);
                                double minPrice = rooms.Min(r => r.pricePerNight);
                                double maxPriceStat = rooms.Max(r => r.pricePerNight);

                                Console.WriteLine("Total Rooms: " + totalRooms);
                                Console.WriteLine("Available Rooms: " + availableRooms);
                                Console.WriteLine("Average Price: " + avgPrice.ToString("F2"));
                                Console.WriteLine("Cheapest Price: " + minPrice.ToString("F2"));
                                Console.WriteLine("Most Expensive Price: " + maxPriceStat.ToString("F2"));
                            }
                            break;

                        case "0":
                            exitSub = true;
                            break;
                    }
                }
            }

            // Case 7
            void GuestAndBookingStatistics()
            {
                Console.WriteLine("### Guest and Booking Statistics ###");
                Console.WriteLine($"Number of registered guests: {guests.Count}");

                var guestsAssigned = guests.Where(g => g.roomNumber != 0);
                Console.WriteLine($"Number of registered guests with assigned rooms: {guestsAssigned.Count()}");

                var guestsNotAssigned = guests.Where(g => g.roomNumber == 0);
                Console.WriteLine($"Number of registered guests with no assigned rooms: {guestsNotAssigned.Count()}");

                Console.WriteLine($"Number of Rooms: {rooms.Count}");

                var bookedRooms = rooms.Where(r => r.isAvailable == false);
                Console.WriteLine($"Number of booked Rooms: {bookedRooms.Count()}");

                if (!guests.Any(g => g.roomNumber != 0))
                {
                    Console.WriteLine("No active bookings recorded.");
                }
                else
                {
                    var AvgGuestsAssigned = guests.Where(g => g.roomNumber != 0).Average(g => g.totalNights);
                    Console.WriteLine($"Average number of nights across all guests who have an active booking: {AvgGuestsAssigned.ToString("F2")}");

                    var topGuests = guests
                        .Where(g => g.roomNumber != 0)
                        .OrderByDescending(g => g.CalculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber).pricePerNight))
                        .Take(3);

                    foreach (var guest in topGuests)
                    {
                        double roomPrice = rooms.FirstOrDefault(r => r.roomNumber == guest.roomNumber).pricePerNight;
                        double totalCost = guest.CalculateTotalCost(roomPrice);
                        Console.WriteLine($"Guest Name: {guest.guestName}, Room Number: {guest.roomNumber}, Total Cost: OMR {totalCost.ToString("F2")}");
                    }

                    var summaries = guests
                        .Where(g => g.roomNumber != 0)
                        .Select(g => {
                            double roomPrice = rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber).pricePerNight;
                            double totalCost = g.CalculateTotalCost(roomPrice);
                            return $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {totalCost.ToString("F2")}";
                        });

                    foreach (var summary in summaries)
                    {
                        Console.WriteLine(summary);
                    }
                }
            }

            // Case 8
            void UpdateRoomPrice()
            {
                Console.WriteLine("Enter a room number: ");
                int rnum = int.Parse(Console.ReadLine());
                var room = rooms.FirstOrDefault(r => r.roomNumber == rnum);

                if(room != null)
                {
                    Console.WriteLine("Enter the updated  new price per night: ");
                    double perNight = double.Parse(Console.ReadLine());

                    if(perNight >= 0)
                    {
                        Console.WriteLine($"Old price per night: {room.pricePerNight}");
                        room.pricePerNight = perNight;
                        Console.WriteLine($"new price per night: {room.pricePerNight}");
                    }
                    else
                    {
                        Console.WriteLine("Error: the newly entered price must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: room with {rnum} number is not found");
                    return;
                }
            }

            // Case 9
            void GuestLookupByName()
            {
                Console.WriteLine("Enter name or partial name to search for: ");
                string searchName = Console.ReadLine();

                var guestFound = guests.Where(g => g.guestName.ToLower().Contains(searchName.ToLower()));

                if(guestFound.Count() != 0)
                {
                    Console.WriteLine($"{guestFound.Count()} guests found with name '{searchName}' ");
                    foreach (var guest in guestFound)
                    {
                        Console.WriteLine("### Found guest by name info ###");
                        Console.WriteLine($"Guest ID: {guest.guestID}");
                        Console.WriteLine($"Guest Name: {guest.guestName}");
                        Console.WriteLine($"Guest Room number: {guest.roomNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("No guests matched that search");
                }
            }

            // Case 10
            void RoomTypeBreakdownReport()
            {
                var singleRoom = rooms.Where(r => r.roomType.Contains("Single"));
                var doubleRoom = rooms.Where(r => r.roomType.Contains("Double"));
                var suiteRoom = rooms.Where(r => r.roomType.Contains("Suite"));

                if (singleRoom.Count() != 0)
                {
                    Console.WriteLine($"{singleRoom.Count()} Single type of rooms available");
                    Console.WriteLine($"Average price per night for Single type of rooms = {Math.Round(singleRoom.Average(r => r.pricePerNight), 2)} OMR");
                }
                else
                {
                    Console.WriteLine("'N/A' Single type of rooms");
                }

                if (doubleRoom.Count() != 0)
                {
                    Console.WriteLine($"{doubleRoom.Count()} Double type of rooms available");
                    Console.WriteLine($"Average price per night for Double type of rooms = {Math.Round(doubleRoom.Average(r => r.pricePerNight),2)} OMR");
                }
                else
                {
                    Console.WriteLine("'N/A' double type of rooms");
                }

                if (suiteRoom.Count() != 0)
                {
                    Console.WriteLine($"{suiteRoom.Count()} Suite type of rooms available");
                    Console.WriteLine($"Average price per night for Suite type of rooms = {Math.Round(suiteRoom.Average(r => r.pricePerNight), 2)} OMR");
                }
                else
                {
                    Console.WriteLine("'N/A' Suite type of rooms");
                }

                Console.WriteLine($"overall average price across all rooms = {Math.Round(rooms.Average(r => r.pricePerNight),2)}");
            }


            // Case 11
            void CheckOutGuest()
            {
                Console.WriteLine("Enter guest ID to check out");
                string GID = Console.ReadLine();

                Guest guestFound = guests.FirstOrDefault(g => g.guestID.Contains(GID));
                if (guestFound != null)
                {
                    if(guestFound.roomNumber != 0)
                    {
                        Room roomFound = rooms.FirstOrDefault(r => r.roomNumber == guestFound.roomNumber);
                        Console.WriteLine("### Full Final Bill ###");
                        Console.WriteLine($"Guest Name: {guestFound.guestName}");
                        Console.WriteLine($"Guest Room number: {guestFound.roomNumber}");
                        Console.WriteLine($"Guest Room type: {roomFound.roomType}");
                        Console.WriteLine($"Guest Check-In date: {guestFound.checkInDate}");
                        Console.WriteLine($"Guest Total Nights: {guestFound.totalNights}");
                        Console.WriteLine($"Room price per night: {roomFound.pricePerNight}");
                        Console.WriteLine($"Total Cost: {guestFound.CalculateTotalCost(roomFound.pricePerNight)}\n");

                        Console.WriteLine("confirm checkout (Y/N)");
                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "y")
                        {
                            roomFound.isAvailable = true;
                            guests.Remove(guestFound);

                            Console.WriteLine("Checkout summary:");
                            Console.WriteLine($"Updated guest count: {guests.Count}");
                            Console.WriteLine($"Updated room count: {rooms.Count}");

                            bool isRoomAvailable = rooms.Any(r => r.roomNumber == roomFound.roomNumber && r.isAvailable == true);
                            Console.WriteLine($"Is room {roomFound.roomNumber} available: {isRoomAvailable}");
                        }

                        else if (choice.ToLower() == "n")
                        {
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Error: you must confirm checkout with either 'y' or 'n'");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This guest has no active booking");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: no guest found with '{GID}' guest ID");
                    return;
                }
            }

            // Case 12
            void RemoveUnavailableRooms()
            {
                var filteredRooms = rooms.Where(r => r.isAvailable == false && !guests.Any(g => g.roomNumber == r.roomNumber));
                var removableRooms = filteredRooms.OrderBy(r => r.roomNumber);

                if (!removableRooms.Any())
                {
                    Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                    return;
                }

                Console.WriteLine("### Safely Removable Rooms ###");
                foreach (var room in removableRooms)
                {
                    Console.WriteLine($"Room Number: {room.roomNumber}");
                    Console.WriteLine($"Room Type: {room.roomType}");
                    Console.WriteLine($"Room Price: {room.pricePerNight.ToString("F2")} OMR\n");
                }

                Console.WriteLine($"Total removable rooms found: {removableRooms.Count()}");
                Console.WriteLine("Confirm decommission of these rooms? (Y/N)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "y")
                {
                    rooms.RemoveAll(r => r.isAvailable == false && !guests.Any(g => g.roomNumber == r.roomNumber));

                    Console.WriteLine("Decommission Successful!");
                    Console.WriteLine($"Updated total room count: {rooms.Count}");

                    Console.WriteLine("### Remaining Rooms ###");
                    var remainingRooms = rooms.Select(r => new { r.roomNumber, r.roomType });
                    foreach (var room in remainingRooms)
                    {
                        Console.WriteLine($"Room Number: {room.roomNumber}");
                        Console.WriteLine($"Room Type: {room.roomType}\n");
                    }
                }
                else if (choice.ToLower() == "n")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Error: you must confirm decommission with either 'y' or 'n'");
                    return;
                }
            }

            // Case 13
            void ExtendGuestStay()
            {
                Console.WriteLine("Enter guest ID to check out");
                string GID = Console.ReadLine();

                Guest guest = guests.FirstOrDefault(g => g.guestID.Contains(GID));

                if (guest != null)
                {
                    if(guest.roomNumber != 0)
                    {
                        Console.WriteLine("Enter the number of night you want to add: ");
                        int nights = int.Parse(Console.ReadLine());

                        if (nights > 0)
                        {
                            Room room = rooms.FirstOrDefault(r => r.roomNumber == guest.roomNumber);
                            guest.totalNights += nights;
                            Console.WriteLine("updated total nights: " + guest.totalNights);
                            Console.WriteLine("new total cost: " + guest.CalculateTotalCost(room.pricePerNight));
                        }
                        else
                        {
                            Console.WriteLine("Error: Number of nights must be positive");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This guest has no active booking to extend");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Error: guest not found");
                    return;
                }
            }

            // Case 14
            void HighestRevenueBooking()
            {
                var activeGuests = guests.Where(g => g.roomNumber != 0);

                if (activeGuests.Count() != 0)
                {
                    var selectedGuests = activeGuests.Select(g => new
                    {
                        g.guestName,
                        g.roomNumber,
                        TotalCost = g.CalculateTotalCost(rooms.First(r => r.roomNumber == g.roomNumber).pricePerNight)
                    }).ToList();

                    var topEarner = selectedGuests.OrderByDescending(g => g.TotalCost).FirstOrDefault();

                    if (topEarner != null)
                    {
                        Console.WriteLine("### Top Revenue Booking ###");
                        Console.WriteLine($"Guest Name: {topEarner.guestName}");
                        Console.WriteLine($"Room Number: {topEarner.roomNumber}");
                        Console.WriteLine($"Total Cost: {topEarner.TotalCost.ToString("F2")} OMR");
                    }
                }
                else
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }
            }

            // Case 15
            void GuestPaginationViewer()
            {
                int totalPages = (guests.Count + 2) / 3;

                if (totalPages == 0)
                {
                    Console.WriteLine("No guests are currently registered.");
                    return;
                }

                Console.WriteLine($"Enter page number (1 to {totalPages}):");
                int page = int.Parse(Console.ReadLine());

                if (page < 1 || page > totalPages)
                {
                    Console.WriteLine("That page does not exist.");
                    return;
                }

                Console.WriteLine($"\n--- Page {page} of {totalPages} ---");
                foreach (var g in guests.Skip((page - 1) * 3).Take(3))
                {
                    Console.WriteLine($"Guest ID: {g.guestID}");
                    Console.WriteLine($"Name: {g.guestName}");
                    Console.WriteLine($"Room: {(g.roomNumber == 0 ? "Not Assigned" : g.roomNumber)}");
                }
            }
        }

    }
}
