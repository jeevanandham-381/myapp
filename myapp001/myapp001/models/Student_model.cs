using System.ComponentModel.DataAnnotations;

namespace myapp001.models
{
    public class Student_model
    {
        [Key, Required]

        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;
    }
}
