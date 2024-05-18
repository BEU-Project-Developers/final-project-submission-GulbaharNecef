﻿namespace HotelClientMVC.Models
{
    public class Room
    {
        public string Id { get; set; }//Guid idi string eledim error olsa deyisecem
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        //public ICollection<ReservationGetDTO>? Reservations { get; set; }// RoomGetDTO includes a nested DTO for Reservation
        //public DateTime CreatedDate { get; set; }
        //public DateTime UpdatedDate { get; set; } //=DateTime.Now
    }
}
