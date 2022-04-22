using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace T_System_Working_With_Model.Models
{
    public class Student
    {
        [Key]
        public int rollNo { get; set; }

        [Required (ErrorMessage ="Name is required")]
        [DataType(DataType.Text)]
        [MinLength(2)]
        public string name { get; set; }

        [Required(ErrorMessage ="Percentage is required")]
        
        public decimal percentage { get; set; }
    }
}
