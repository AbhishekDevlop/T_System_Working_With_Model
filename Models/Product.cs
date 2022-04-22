using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace T_System_Working_With_Model.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required (ErrorMessage ="Field is mandatory*")]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string ProductName { get; set; }
        
        [Required(ErrorMessage = "Field is mandatory*")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Field is mandatory*")]
        [DataType (DataType.Text)]
        public string DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Field is mandatory*")]
        public int Pincode { get; set; }
    }
}
