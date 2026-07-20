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

            Console.WriteLine("===== Hotel Management System =====");
            Console.WriteLine("1. Add New Room");
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

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.ReadKey();
        }
    }
}