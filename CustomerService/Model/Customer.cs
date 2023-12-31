﻿using Commons;

namespace CustomerService.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public LoyaltyPoints AccumulatedPoints { get; set; }
    }
}
