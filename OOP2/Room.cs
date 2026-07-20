using System;

namespace OOP2
{
    class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public void DisplayRoom()
        {
            Console.WriteLine("Room Number: " + RoomNumber);
            Console.WriteLine("Room Type: " + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);
            Console.WriteLine("Availability: " + (IsAvailable ? "Available" : "Booked"));
        }
    }
}