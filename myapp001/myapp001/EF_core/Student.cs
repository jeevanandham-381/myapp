using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myapp001.EF_core
{
    [Table("students")]
    public class Student
    {
        [Key,Required]

        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

    }
}
