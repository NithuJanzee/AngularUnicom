using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Address
    {

        [Key]
        public int Id { get; set; }
        public string? Line1 { get; set; }
        public string? City { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }
    }
}
