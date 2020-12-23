using System;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Client : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActived { get; set; }
    }
}