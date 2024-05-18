﻿namespace HotelClientMVC.DTOs
{
    public class ReservationCreateDTO
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? SpecialRequests { get; set; }
        public string? EmergencyContact { get; set; }
    }
}
