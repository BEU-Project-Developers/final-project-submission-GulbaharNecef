﻿namespace HotelClientMVC.ViewModels
{
	public class AuthData
	{
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
		public DateTime Expiration { get; set; }
	}
}
