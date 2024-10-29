using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Number { get; set; }



        public Address? Addreess { get; set; }

        public ICollection<TaskItems>? Tasks { get; set; } = new List<TaskItems>();

        
    }
}
