using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entity
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
