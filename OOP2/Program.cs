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