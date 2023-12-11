using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string StName { get; set; }

        public string Course { get; set; }
    }
}
