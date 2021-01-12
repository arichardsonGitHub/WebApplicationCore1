using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationCore1.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string EyeColor { get; set; }
    }
}
