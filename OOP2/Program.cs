using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room
            {
                RoomNumber = 101,
                RoomType = "Single",
                PricePerNight = 25,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 102,
                RoomType = "Single",
                PricePerNight = 25,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 201,
                RoomType = "Double",
                PricePerNight = 40,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 202,
                RoomType = "Double",
                PricePerNight = 40,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 301,
                RoomType = "Suite",
                PricePerNight = 80,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 302,
                RoomType = "Suite",
                PricePerNight = 90,
                IsAvailable = true
            });

            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("===== Hotel Management System =====");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("===== Add New Room =====");

                        Console.Write("Enter Room Number: ");
                        int roomNumber = Convert.ToInt32(Console.ReadLine());

                        bool roomExists = rooms.Any(room => room.RoomNumber == roomNumber);

                        if (roomExists)
                        {
                            Console.WriteLine("Room number already exists.");
                        }
                        else
                        {
                            Console.Write("Enter Room Type: ");
                            string roomType = Console.ReadLine();

                            Console.Write("Enter Price Per Night: ");
                            double pricePerNight = Convert.ToDouble(Console.ReadLine());

                            Room newRoom = new Room();

                            newRoom.RoomNumber = roomNumber;
                            newRoom.RoomType = roomType;
                            newRoom.PricePerNight = pricePerNight;
                            newRoom.IsAvailable = true;

                            rooms.Add(newRoom);

                            Console.WriteLine("Room added successfully.");
                            newRoom.DisplayRoom();
                        }

                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("===== Register New Guest =====");

                        Console.Write("Enter Guest Name: ");
                        string guestName = Console.ReadLine();

                        Console.Write("Enter Check-In Date: ");
                        string checkInDate = Console.ReadLine();

                        Console.Write("Enter Number of Nights: ");
                        int totalNights;

                        if (!int.TryParse(Console.ReadLine(), out totalNights) || totalNights <= 0)
                        {
                            Console.WriteLine("Invalid number of nights.");
                            break;
                        }

                        string guestId = "G" + (guests.Count() + 1).ToString("D3");

                        Guest newGuest = new Guest();

                        newGuest.GuestId = guestId;
                        newGuest.GuestName = guestName;
                        newGuest.RoomNumber = "Not Assigned";
                        newGuest.CheckInDate = checkInDate;
                        newGuest.TotalNights = totalNights;

                        guests.Add(newGuest);

                        Console.WriteLine();
                        Console.WriteLine("Guest registered successfully.");
                        newGuest.DisplayGuest();

                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("===== Book a Room =====");

                        Console.Write("Enter Guest ID: ");
                        string guestIdSearch = Console.ReadLine();

                        Console.Write("Enter Room Number: ");
                        int roomNumberSearch = Convert.ToInt32(Console.ReadLine());

                        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestIdSearch);
                        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumberSearch);

                        if (guest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        if (room == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        if (room.IsAvailable == false)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }

                        guest.RoomNumber = room.RoomNumber.ToString();
                        room.IsAvailable = false;

                        Console.WriteLine();
                        Console.WriteLine("Booking Successful!");
                        Console.WriteLine("Guest Name: " + guest.GuestName);
                        Console.WriteLine("Room Number: " + room.RoomNumber);
                        Console.WriteLine("Room Type: " + room.RoomType);
                        Console.WriteLine("Price Per Night: " + room.PricePerNight);
                        Console.WriteLine("Total Nights: " + guest.TotalNights);
                        Console.WriteLine("Total Cost: " +
                            guest.CalculateTotalCost(room.PricePerNight));

                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("===== View All Rooms =====");

                        if (rooms.Count() == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }

                        Console.WriteLine("Total Rooms: " + rooms.Count());
                        Console.WriteLine();

                        var sortedRooms = rooms.OrderBy(r => r.RoomNumber);

                        foreach (Room currentRoom in sortedRooms)
                        {
                            Console.WriteLine("Room Number: " + currentRoom.RoomNumber);
                            Console.WriteLine("Room Type: " + currentRoom.RoomType);
                            Console.WriteLine("Price Per Night: " + currentRoom.PricePerNight);
                            Console.WriteLine("Availability: " +
                                (currentRoom.IsAvailable ? "Available" : "Booked"));

                            Console.WriteLine("-------------------------");
                        }

                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("===== View All Guests =====");

                        if (guests.Count() == 0)
                        {
                            Console.WriteLine("No guests have been registered yet.");
                            break;
                        }

                        Console.WriteLine("Total Guests: " + guests.Count());
                        Console.WriteLine();

                        var sortedGuests = guests.OrderBy(g => g.GuestName);

                        foreach (Guest currentGuest in sortedGuests)
                        {
                            Console.WriteLine("Guest ID: " + currentGuest.GuestId);
                            Console.WriteLine("Guest Name: " + currentGuest.GuestName);
                            Console.WriteLine("Room Number: " + currentGuest.RoomNumber);
                            Console.WriteLine("Check-In Date: " + currentGuest.CheckInDate);
                            Console.WriteLine("Total Nights: " + currentGuest.TotalNights);
                            Console.WriteLine("-------------------------");
                        }

                        break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("===== Search & Filter Rooms =====");
                        Console.WriteLine("1. Show All Available Rooms");
                        Console.WriteLine("2. Filter By Room Type");
                        Console.WriteLine("3. Filter By Maximum Price");
                        Console.WriteLine("4. Room Price Statistics");
                        Console.WriteLine("0. Back");
                        Console.Write("Choose an option: ");

                        int subChoice = Convert.ToInt32(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                var availableRooms = rooms
                                    .Where(r => r.IsAvailable == true)
                                    .OrderBy(r => r.PricePerNight);

                                Console.WriteLine();
                                Console.WriteLine("Total Available Rooms: " + availableRooms.Count());

                                if (!availableRooms.Any())
                                {
                                    Console.WriteLine("No rooms found for the selected criteria.");
                                }
                                else
                                {
                                    foreach (Room currentRoom in availableRooms)
                                    {
                                        Console.WriteLine("-------------------------");
                                        Console.WriteLine("Room Number: " + currentRoom.RoomNumber);
                                        Console.WriteLine("Room Type: " + currentRoom.RoomType);
                                        Console.WriteLine("Price Per Night: " +
                                            currentRoom.PricePerNight.ToString("F2"));
                                        Console.WriteLine("Availability: Available");
                                    }
                                }

                                break;

                            case 2:
                                Console.Write("Enter Room Type (Single / Double / Suite): ");
                                string searchRoomType = Console.ReadLine();

                                var roomsByType = rooms
                                    .Where(r => r.RoomType.ToLower() == searchRoomType.ToLower())
                                    .OrderBy(r => r.RoomNumber);

                                Console.WriteLine();
                                Console.WriteLine("Total Matching Rooms: " + roomsByType.Count());

                                if (!roomsByType.Any())
                                {
                                    Console.WriteLine("No rooms found for the selected criteria.");
                                }
                                else
                                {
                                    foreach (Room currentRoom in roomsByType)
                                    {
                                        Console.WriteLine("-------------------------");
                                        Console.WriteLine("Room Number: " + currentRoom.RoomNumber);
                                        Console.WriteLine("Room Type: " + currentRoom.RoomType);
                                        Console.WriteLine("Price Per Night: " +
                                            currentRoom.PricePerNight.ToString("F2"));
                                        Console.WriteLine("Availability: " +
                                            (currentRoom.IsAvailable ? "Available" : "Booked"));
                                    }
                                }

                                break;

                            case 3:
                                Console.Write("Enter Maximum Price: ");
                                double maximumPrice;

                                if (!double.TryParse(Console.ReadLine(), out maximumPrice) ||
                                    maximumPrice <= 0)
                                {
                                    Console.WriteLine("Invalid price.");
                                    break;
                                }

                                var roomsByPrice = rooms
                                    .Where(r => r.IsAvailable == true &&
                                                r.PricePerNight <= maximumPrice)
                                    .OrderBy(r => r.PricePerNight);

                                Console.WriteLine();
                                Console.WriteLine("Total Matching Rooms: " + roomsByPrice.Count());

                                if (!roomsByPrice.Any())
                                {
                                    Console.WriteLine("No rooms found for the selected criteria.");
                                }
                                else
                                {
                                    foreach (Room currentRoom in roomsByPrice)
                                    {
                                        Console.WriteLine("-------------------------");
                                        Console.WriteLine("Room Number: " + currentRoom.RoomNumber);
                                        Console.WriteLine("Room Type: " + currentRoom.RoomType);
                                        Console.WriteLine("Price Per Night: " +
                                            currentRoom.PricePerNight.ToString("F2"));
                                        Console.WriteLine("Availability: Available");
                                    }
                                }

                                break;

                            case 4:
                                Console.WriteLine();
                                Console.WriteLine("===== Room Price Statistics =====");

                                if (!rooms.Any())
                                {
                                    Console.WriteLine("No rooms have been added yet.");
                                    break;
                                }

                                int totalRooms = rooms.Count();
                                int totalAvailableRooms = rooms.Count(r => r.IsAvailable);
                                double averagePrice = rooms.Average(r => r.PricePerNight);
                                double cheapestPrice = rooms.Min(r => r.PricePerNight);
                                double mostExpensivePrice = rooms.Max(r => r.PricePerNight);

                                Console.WriteLine("Total Rooms: " + totalRooms);
                                Console.WriteLine("Available Rooms: " + totalAvailableRooms);
                                Console.WriteLine("Average Price: " +
                                    averagePrice.ToString("F2"));
                                Console.WriteLine("Cheapest Price: " +
                                    cheapestPrice.ToString("F2"));
                                Console.WriteLine("Most Expensive Price: " +
                                    mostExpensivePrice.ToString("F2"));

                                break;

                            case 0:
                                Console.WriteLine("Returning to main menu.");
                                break;

                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }

                        break;

                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("===== Guest & Booking Statistics =====");

                        int totalRegisteredGuests = guests.Count();

                        int totalBookedGuests = guests
                            .Where(g => g.RoomNumber != "Not Assigned")
                            .Count();

                        int totalRoomsCount = rooms.Count();

                        int totalBookedRooms = rooms
                            .Where(r => r.IsAvailable == false)
                            .Count();

                        Console.WriteLine("Total Registered Guests: " + totalRegisteredGuests);
                        Console.WriteLine("Guests With Active Booking: " + totalBookedGuests);
                        Console.WriteLine("Total Rooms: " + totalRoomsCount);
                        Console.WriteLine("Booked Rooms: " + totalBookedRooms);

                        var activeBookings = guests
                            .Where(g => g.RoomNumber != "Not Assigned");

                        if (!activeBookings.Any())
                        {
                            Console.WriteLine();
                            Console.WriteLine("No active bookings recorded.");
                            break;
                        }

                        double averageNights = activeBookings
                            .Average(g => g.TotalNights);

                        Console.WriteLine("Average Number of Nights: " +
                            averageNights.ToString("F2"));

                        var topGuests = activeBookings
                            .OrderByDescending(g =>
                            {
                                Room bookedRoom = rooms.FirstOrDefault(
                                    r => r.RoomNumber.ToString() == g.RoomNumber);

                                if (bookedRoom == null)
                                {
                                    return 0;
                                }

                                return g.CalculateTotalCost(bookedRoom.PricePerNight);
                            })
                            .Take(3);

                        Console.WriteLine();
                        Console.WriteLine("===== Top 3 Highest-Spending Guests =====");

                        foreach (Guest currentGuest in topGuests)
                        {
                            Room bookedRoom = rooms.FirstOrDefault(
                                r => r.RoomNumber.ToString() == currentGuest.RoomNumber);

                            if (bookedRoom != null)
                            {
                                double totalCost =
                                    currentGuest.CalculateTotalCost(bookedRoom.PricePerNight);

                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Guest Name: " + currentGuest.GuestName);
                                Console.WriteLine("Room Number: " + currentGuest.RoomNumber);
                                Console.WriteLine("Total Cost: OMR " +
                                    totalCost.ToString("F2"));
                            }
                        }

                        var bookingSummaries = activeBookings.Select(g =>
                        {
                            Room bookedRoom = rooms.FirstOrDefault(
                                r => r.RoomNumber.ToString() == g.RoomNumber);

                            double totalCost = 0;

                            if (bookedRoom != null)
                            {
                                totalCost =
                                    g.CalculateTotalCost(bookedRoom.PricePerNight);
                            }

                            return g.GuestName +
                                   " — Room " + g.RoomNumber +
                                   " — " + g.TotalNights +
                                   " nights — OMR " +
                                   totalCost.ToString("F2");
                        });

                        Console.WriteLine();
                        Console.WriteLine("===== Booking Summary =====");

                        foreach (string summary in bookingSummaries)
                        {
                            Console.WriteLine(summary);
                        }

                        break;

                    case 8:
                        Console.WriteLine();
                        Console.WriteLine("===== Update Room Price =====");

                        Console.Write("Enter Room Number: ");
                        int updateRoomNumber;

                        if (!int.TryParse(Console.ReadLine(), out updateRoomNumber) ||
                            updateRoomNumber <= 0)
                        {
                            Console.WriteLine("Invalid room number.");
                            break;
                        }

                        Room roomToUpdate = rooms.FirstOrDefault(
                            r => r.RoomNumber == updateRoomNumber);

                        if (roomToUpdate == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        Console.Write("Enter New Price Per Night: ");
                        double newPrice;

                        if (!double.TryParse(Console.ReadLine(), out newPrice) ||
                            newPrice <= 0)
                        {
                            Console.WriteLine("Invalid price.");
                            break;
                        }

                        double oldPrice = roomToUpdate.PricePerNight;

                        roomToUpdate.PricePerNight = newPrice;

                        Console.WriteLine();
                        Console.WriteLine("Room price updated successfully.");
                        Console.WriteLine("Room Number: " + roomToUpdate.RoomNumber);
                        Console.WriteLine("Old Price: OMR " + oldPrice.ToString("F2"));
                        Console.WriteLine("New Price: OMR " + newPrice.ToString("F2"));

                        break;

                    case 9:
                        Console.WriteLine();
                        Console.WriteLine("===== Guest Lookup by Name =====");

                        Console.Write("Enter Guest Name or Partial Name: ");
                        string searchName = Console.ReadLine();

                        var matchingGuests = guests
                            .Where(g => g.GuestName.ToLower().Contains(searchName.ToLower()));

                        Console.WriteLine();
                        Console.WriteLine("Total Matches: " + matchingGuests.Count());

                        if (matchingGuests.Count() == 0)
                        {
                            Console.WriteLine("No guests matched that search.");
                        }
                        else
                        {
                            foreach (Guest currentGuest in matchingGuests)
                            {
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Guest ID: " + currentGuest.GuestId);
                                Console.WriteLine("Guest Name: " + currentGuest.GuestName);
                                Console.WriteLine("Room Number: " + currentGuest.RoomNumber);
                            }
                        }

                        break;

                    case 0:
                        running = false;
                        Console.WriteLine("Program closed.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}